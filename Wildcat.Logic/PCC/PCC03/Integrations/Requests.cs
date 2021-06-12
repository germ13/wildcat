using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.PCC.PCC03Integration;
using Wildcat.Utilities;

namespace Wildcat.Logic.PCC.PCC03.Integrations
{
    public class Requests
    {
        #region Private Fields

        private PCC03_IntegrationContext _context;
        private IViewRenderService _viewRenderService;

        #endregion Private Fields



        #region Public Properties

        public enum Status
        {
            Active = 0,
            InProcess = 1,
            Completed = 2,
            Failed = 3
        }

        public class RequestsDTO
        {
            public Guid Id { get; set; }
            public long? OracleId { get; set; }
            public long? Pcc03Id { get; set; }
            public string Json { get; set; }
            public string JsonChild { get; set; }
            public string Response { get; set; }
            public string Exception { get; set; }
            public string Status { get; set; }
            public bool Active { get; set; }
            public DateTime Added { get; set; }
            public string AddedBy { get; set; }
            public DateTime? Updated { get; set; }
            public string UpdatedBy { get; set; }
        }

        public class Item
        {
            public int sourceId { get; set; }
            public string sourceColumn { get; set; }
            public string partNumber { get; set; }
            public string material { get; set; }
            public string partType { get; set; }
            public string endUser { get; set; }
            public string customerPN { get; set; }
            public string description { get; set; }
            public string engComments { get; set; }
            public bool military { get; set; }
            public string materialSpecs { get; set; }
            public string jurisdiction { get; set; }
            public double receivingWeight { get; set; }
            public string engineName { get; set; }
        }

        public class MasterRouter
        {
            public int sourceId { get; set; }
            public string sourceColumn { get; set; }
            public string partNumber { get; set; }
            public string revision { get; set; }
            public DateTime date { get; set; }
            public string user { get; set; }
            public bool active { get; set; }
            public List<Operation> Operations { get; set; }
        }

        public class Operation
        {
            public int opSeqNum { get; set; }
            public string opType { get; set; }
            public string comment { get; set; }
            public DateTime date { get; set; }
            public string description { get; set; }
            public int setup { get; set; }
            public double cycleTime { get; set; }
            public string machineGroup { get; set; }
        }

        public class JobOrder
        {
            public int sourceId { get; set; }
            public string sourceColumn { get; set; }
            public DateTime? poDate { get; set; }
            public string user { get; set; }
            public string poNum { get; set; }
            public string customer { get; set; }
            public DateTime? dueDate { get; set; }
            public string deliveryTo { get; set; }
            public DateTime? commitDate { get; set; }
            public string addComments { get; set; }
            public string fobTerms { get; set; }
            public string shippingMethod { get; set; }
            public string id_via_name { get; set; }
            public string deliveryType { get; set; }
            public string partNumber { get; set; }
            public short qty { get; set; }
            public decimal? unitPrice { get; set; }
            public string jobNumber { get; set; }
            public string customerWorkOrder { get; set; }
            public short customerLineNumber { get; set; }
            public string cocInstructions { get; set; }
            public string testRings { get; set; }
            public bool chipReturn { get; set; }
            public List<serials> snRange { get; set; }
        }

        public class serials
        {
            public string SN { get; set; }
            public string HeatSN { get; set; }
            public string CustSN { get; set; }
            //public int TestRing { get; set; }
        }

        public class JobOrder6
        {
            public int? oracleId { get; set; }
            public int jobNumber { get; set; }
            //public string  operations { get; set; }
            public List<JobOrderOperation> operations { get; set; }
        }

        public class JobOrderOperation
        {
            public string opSeqNum { get; set; }
            public string opType { get; set; }
            public string comment { get; set; }
            public DateTime date { get; set; }
            public string description { get; set; }
            public int setup { get; set; }
            public double cycleTime { get; set; }
            public string machineGroup { get; set; }
        }

        #endregion Public Properties



        #region Constructors

        public Requests(PCC03_IntegrationContext context, IViewRenderService viewRenderService)
        {
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Public Methods 

        public string GetJsonObject(string table, Guid ID)
        {
            string result = null;

            if (table == "2")
            {
                var ob = _context.Int002Item.Where(x => x.Id == ID).FirstOrDefault().JsonParentObject;
                dynamic parsedJson = JsonConvert.DeserializeObject(ob);
                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            else if (table == "4")
            {
                var ob = _context.Int004Router.Where(x => x.Id == ID).FirstOrDefault().JsonParentObject;
                dynamic parsedJson = JsonConvert.DeserializeObject(ob);
                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            else if (table == "5")
            {
                var ob = _context.Int005Job.Where(x => x.Id == ID).FirstOrDefault().JsonParentObject;
                var obchild = _context.Int005Job.Where(x => x.Id == ID).FirstOrDefault().JsonChildObject;
                JobOrder parsedJson = JsonConvert.DeserializeObject<JobOrder>(ob);
                List<serials> parsedJsonChild = JsonConvert.DeserializeObject<List<serials>>(obchild);

                parsedJson.snRange = new List<serials>();

                parsedJson.snRange = parsedJsonChild;

                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            else if (table == "6")
            {
                var ob = _context.Int006Job.Where(x => x.Id == ID).FirstOrDefault().JsonParentObject;
                var obchild = _context.Int006Job.Where(x => x.Id == ID).FirstOrDefault().JsonChildObject;
                JobOrder6 parsedJson = JsonConvert.DeserializeObject<JobOrder6>(ob);
                List<JobOrderOperation> parsedJsonChild = JsonConvert.DeserializeObject<List<JobOrderOperation>>(obchild);

                parsedJson.operations = new List<JobOrderOperation>();

                parsedJson.operations = parsedJsonChild;

                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            else if (table == "8")
            {
                var ob = _context.Int008MoveTran.Where(x => x.Id == ID).FirstOrDefault().JsonParentObject;
                dynamic parsedJson = JsonConvert.DeserializeObject(ob);
                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            else
            {
                var ob = _context.Int010CompleteTran.Where(x => x.Id == ID).FirstOrDefault().JsonParentObject;
                dynamic parsedJson = JsonConvert.DeserializeObject(ob);
                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }

            return result;
        }

        public string GetResponseObject(string table, Guid ID)
        {
            string result = null;

            if (table == "2")
            {
                var ob = _context.Int002Item.Where(x => x.Id == ID).FirstOrDefault().ResponseObject == null ? "" : _context.Int002Item.Where(x => x.Id == ID).FirstOrDefault().ResponseObject;
                dynamic parsedJson = JsonConvert.DeserializeObject(ob);
                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            else if (table == "4")
            {
                var ob = _context.Int004Router.Where(x => x.Id == ID).FirstOrDefault().ResponseObject == null ? "" : _context.Int004Router.Where(x => x.Id == ID).FirstOrDefault().ResponseObject;
                dynamic parsedJson = JsonConvert.DeserializeObject(ob);
                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            else if (table == "5")
            {
                var ob = _context.Int005Job.Where(x => x.Id == ID).FirstOrDefault().ResponseObject == null ? "" : _context.Int005Job.Where(x => x.Id == ID).FirstOrDefault().ResponseObject;
                dynamic parsedJson = JsonConvert.DeserializeObject(ob);
                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            else if (table == "6")
            {
                var ob = _context.Int006Job.Where(x => x.Id == ID).FirstOrDefault().ResponseObject == null ? "" : _context.Int006Job.Where(x => x.Id == ID).FirstOrDefault().ResponseObject;
                dynamic parsedJson = JsonConvert.DeserializeObject(ob);
                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            else if (table == "8")
            {
                var ob = _context.Int008MoveTran.Where(x => x.Id == ID).FirstOrDefault().ResponseObject == null ? "" : _context.Int008MoveTran.Where(x => x.Id == ID).FirstOrDefault().ResponseObject;
                dynamic parsedJson = JsonConvert.DeserializeObject(ob);
                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            else
            {
                var ob = _context.Int010CompleteTran.Where(x => x.Id == ID).FirstOrDefault().ResponseObject == null ? "" : _context.Int010CompleteTran.Where(x => x.Id == ID).FirstOrDefault().ResponseObject;
                dynamic parsedJson = JsonConvert.DeserializeObject(ob);
                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }

            return result;
        }

        public string GetExceptionObject(string table, Guid ID)
        {
            string result = null;

            if (table == "2")
            {
                var ob = _context.Int002Item.Where(x => x.Id == ID).FirstOrDefault().ExceptionObject == null ? "" : _context.Int002Item.Where(x => x.Id == ID).FirstOrDefault().ExceptionObject;
                dynamic parsedJson = JsonConvert.DeserializeObject(ob);
                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            else if (table == "4")
            {
                var ob = _context.Int004Router.Where(x => x.Id == ID).FirstOrDefault().ExceptionObject == null ? "" : _context.Int004Router.Where(x => x.Id == ID).FirstOrDefault().ExceptionObject;
                dynamic parsedJson = JsonConvert.DeserializeObject(ob);
                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            else if (table == "5")
            {
                var ob = _context.Int005Job.Where(x => x.Id == ID).FirstOrDefault().ExceptionObject == null ? "" : _context.Int005Job.Where(x => x.Id == ID).FirstOrDefault().ExceptionObject;
                dynamic parsedJson = JsonConvert.DeserializeObject(ob);
                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            else if (table == "6")
            {
                var ob = _context.Int006Job.Where(x => x.Id == ID).FirstOrDefault().ExceptionObject == null ? "" : _context.Int006Job.Where(x => x.Id == ID).FirstOrDefault().ExceptionObject;
                dynamic parsedJson = JsonConvert.DeserializeObject(ob);
                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            else if (table == "8")
            {
                var ob = _context.Int008MoveTran.Where(x => x.Id == ID).FirstOrDefault().ExceptionObject == null ? "" : _context.Int008MoveTran.Where(x => x.Id == ID).FirstOrDefault().ExceptionObject;
                dynamic parsedJson = JsonConvert.DeserializeObject(ob);
                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            else
            {
                var ob = _context.Int010CompleteTran.Where(x => x.Id == ID).FirstOrDefault().ExceptionObject == null ? "" : _context.Int010CompleteTran.Where(x => x.Id == ID).FirstOrDefault().ExceptionObject;
                dynamic parsedJson = JsonConvert.DeserializeObject(ob);
                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }

            return result;
        }

        public MasterTable EditJobMasterNote(Guid Id, string note, string requestor)
        {
            var obj = _context.MasterTable.Where(x => x.Id == Id).FirstOrDefault();
            obj.Note = note;
            obj.Updated = DateTime.UtcNow;
            obj.UpdatedBy = requestor;
            _context.SaveChanges();

            return obj;
        }

        public void ReleaseJob(Guid Id, string Table, string requestor)
        {
            string result = null;

            if (Table == "2")
            {
                var ob = _context.Int002Item.Where(x => x.Id == Id).FirstOrDefault();
                ob.Status = (int)Status.Active;
                ob.InProcess = false;
                ob.Processor = null;
                ob.Active = true;
                ob.Updated = DateTime.UtcNow;
                ob.UpdatedBy = requestor;
                _context.SaveChanges();

                var obj = JsonConvert.DeserializeObject<Item>(ob.JsonParentObject);
                try
                {
                    var receivingWeight = Convert.ToDecimal(obj.receivingWeight);

                    //_context.up_u_oracle2_PN
                    //   (obj.partNumber,
                    //    obj.material,
                    //    obj.partType,
                    //    obj.endUser,
                    //    obj.customerPN,
                    //    obj.description,
                    //    obj.military.ToString(),
                    //    obj.engComments,
                    //    obj.engineName,
                    //    obj.jurisdiction,
                    //    receivingWeight,
                    //    obj.engineName);
                    //_context.SaveChanges();

                    //update the log
                    ob.Active = false;
                    ob.Status = (int)Status.Completed;
                    ob.CompletedDate = DateTime.UtcNow;
                    ob.InProcess = false;
                    ob.Updated = DateTime.UtcNow;
                    ob.UpdatedBy = requestor;

                    _context.SaveChanges();

                }
                catch (Exception e)
                {

                }
            }
            else if (Table == "4")
            {
                var ob = _context.Int004Router.Where(x => x.Id == Id).FirstOrDefault();
                ob.Status = (int)Status.Active;
                ob.InProcess = false;
                ob.Processor = null;
                ob.Active = true;
                ob.Updated = DateTime.UtcNow;
                ob.UpdatedBy = requestor;
                _context.SaveChanges();
            }
            else if (Table == "5")
            {
                var ob = _context.Int005Job.Where(x => x.Id == Id).FirstOrDefault();
                ob.Status = (int)Status.Active;
                ob.InProcess = false;
                ob.Processor = null;
                ob.Active = true;
                ob.Updated = DateTime.UtcNow;
                ob.UpdatedBy = requestor;
                _context.SaveChanges();
            }
            else if (Table == "6")
            {
                var ob = _context.Int006Job.Where(x => x.Id == Id).FirstOrDefault();
                ob.Status = (int)Status.Active;
                ob.InProcess = false;
                ob.Processor = null;
                ob.Active = true;
                ob.Updated = DateTime.UtcNow;
                ob.UpdatedBy = requestor;
                _context.SaveChanges();
            }
            else if (Table == "8")
            {
                var ob = _context.Int008MoveTran.Where(x => x.Id == Id).FirstOrDefault();
                ob.Status = (int)Status.Active;
                ob.InProcess = false;
                ob.Processor = null;
                ob.Active = true;
                ob.Updated = DateTime.UtcNow;
                ob.UpdatedBy = requestor;
                _context.SaveChanges();
            }
            else
            {
                var ob = _context.Int010CompleteTran.Where(x => x.Id == Id).FirstOrDefault();
                ob.Status = (int)Status.Active;
                ob.InProcess = false;
                ob.Processor = null;
                ob.Active = true;
                ob.Updated = DateTime.UtcNow;
                ob.UpdatedBy = requestor;
                _context.SaveChanges();
            }
        }

        public List<RequestsDTO> FilterData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection, string table)
        {
            List<RequestsDTO> listdto = new List<RequestsDTO>();
            if (string.IsNullOrEmpty(search))
            {
                if (table == "2")
                {
                    var list = _context.Int002Item.ToList();
                    foreach (var l in list)
                    {
                        listdto.Add(new RequestsDTO
                        {
                            Id = l.Id,
                            OracleId = l.OracleId,
                            Pcc03Id = l.Pcc03Id,
                            Json = l.JsonParentObject,
                            JsonChild = l.JsonChildObject,
                            Response = l.ResponseObject,
                            Exception = l.ExceptionObject,
                            Status = ((Status)l.Status).ToString(),
                            Added = l.Added,
                            Updated = l.Updated
                        });
                    }
                }
                else if (table == "4")
                {
                    var list = _context.Int004Router.ToList();
                    foreach (var l in list)
                    {
                        listdto.Add(new RequestsDTO
                        {
                            Id = l.Id,
                            OracleId = l.OracleId,
                            Pcc03Id = l.Pcc03Id,
                            Json = l.JsonParentObject,
                            JsonChild = l.JsonChildObject,
                            Response = l.ResponseObject,
                            Exception = l.ExceptionObject,
                            Status = ((Status)l.Status).ToString(),
                            Added = l.Added,
                            Updated = l.Updated
                        });
                    }
                }
                else if (table == "5")
                {
                    var list = _context.Int005Job.ToList();
                    foreach (var l in list)
                    {
                        listdto.Add(new RequestsDTO
                        {
                            Id = l.Id,
                            OracleId = l.OracleId,
                            Pcc03Id = l.Pcc03Id,
                            Json = l.JsonParentObject,
                            JsonChild = l.JsonChildObject,
                            Response = l.ResponseObject,
                            Exception = l.ExceptionObject,
                            Status = ((Status)l.Status).ToString(),
                            Added = l.Added,
                            Updated = l.Updated
                        });
                    }
                }
                else if (table == "6")
                {
                    var list = _context.Int006Job.ToList();
                    foreach (var l in list)
                    {
                        listdto.Add(new RequestsDTO
                        {
                            Id = l.Id,
                            OracleId = l.OracleId,
                            Pcc03Id = l.Pcc03Id,
                            Json = l.JsonParentObject,
                            JsonChild = l.JsonChildObject,
                            Response = l.ResponseObject,
                            Exception = l.ExceptionObject,
                            Status = ((Status)l.Status).ToString(),
                            Added = l.Added,
                            Updated = l.Updated
                        });
                    }
                }
                else if (table == "8")
                {
                    var list = _context.Int008MoveTran.ToList();
                    foreach (var l in list)
                    {
                        listdto.Add(new RequestsDTO
                        {
                            Id = l.Id,
                            OracleId = l.OracleId,
                            Pcc03Id = l.Pcc03Id,
                            Json = l.JsonParentObject,
                            JsonChild = l.JsonChildObject,
                            Response = l.ResponseObject,
                            Exception = l.ExceptionObject,
                            Status = ((Status)l.Status).ToString(),
                            Added = l.Added,
                            Updated = l.Updated
                        });
                    }
                }
                else
                {
                    var list = _context.Int010CompleteTran.ToList();
                    foreach (var l in list)
                    {
                        listdto.Add(new RequestsDTO
                        {
                            Id = l.Id,
                            OracleId = l.OracleId,
                            Pcc03Id = l.Pcc03Id,
                            Json = l.JsonParentObject,
                            JsonChild = l.JsonChildObject,
                            Response = l.ResponseObject,
                            Exception = l.ExceptionObject,
                            Status = ((Status)l.Status).ToString(),
                            Added = l.Added,
                            Updated = l.Updated
                        });
                    }
                }
            }
            else
            {
                if (table == "2")
                {
                    foreach (Int002Item dataItem in _context.Int002Item)
                    {
                        if ((dataItem.JsonParentObject != null && dataItem.JsonParentObject.ToUpper().Contains(search.ToUpper())) ||
                            (dataItem.JsonChildObject != null && dataItem.JsonChildObject.ToString().Contains(search)) ||
                            (dataItem.ResponseObject != null && dataItem.ResponseObject.ToString().Contains(search)) ||
                            (dataItem.OracleId != null && dataItem.OracleId.ToString().Contains(search)) ||
                            (dataItem.Pcc03Id != null && dataItem.Pcc03Id.ToString().Contains(search)))
                        {
                            listdto.Add(new RequestsDTO
                            {
                                Id = dataItem.Id,
                                OracleId = dataItem.OracleId,
                                Pcc03Id = dataItem.Pcc03Id,
                                Json = dataItem.JsonParentObject,
                                JsonChild = dataItem.JsonChildObject,
                                Response = dataItem.ResponseObject,
                                Exception = dataItem.ExceptionObject,
                                Status = ((Status)dataItem.Status).ToString(),
                                Added = dataItem.Added,
                                Updated = dataItem.Updated
                            });
                        }
                    }
                }
                else if (table == "4")
                {
                    foreach (Int004Router dataItem in _context.Int004Router)
                    {
                        if ((dataItem.JsonParentObject != null && dataItem.JsonParentObject.ToUpper().Contains(search.ToUpper())) ||
                            (dataItem.JsonChildObject != null && dataItem.JsonChildObject.ToString().Contains(search)) ||
                            (dataItem.ResponseObject != null && dataItem.ResponseObject.ToString().Contains(search)) ||
                            (dataItem.OracleId != null && dataItem.OracleId.ToString().Contains(search)) ||
                            (dataItem.Pcc03Id != null && dataItem.Pcc03Id.ToString().Contains(search)))
                        {
                            listdto.Add(new RequestsDTO
                            {
                                Id = dataItem.Id,
                                OracleId = dataItem.OracleId,
                                Pcc03Id = dataItem.Pcc03Id,
                                Json = dataItem.JsonParentObject,
                                JsonChild = dataItem.JsonChildObject,
                                Response = dataItem.ResponseObject,
                                Exception = dataItem.ExceptionObject,
                                Status = ((Status)dataItem.Status).ToString(),
                                Added = dataItem.Added,
                                Updated = dataItem.Updated
                            });
                        }
                    }
                }
                else if (table == "5")
                {
                    foreach (Int005Job dataItem in _context.Int005Job)
                    {
                        if ((dataItem.JsonParentObject != null && dataItem.JsonParentObject.ToUpper().Contains(search.ToUpper())) ||
                            (dataItem.JsonChildObject != null && dataItem.JsonChildObject.ToString().Contains(search)) ||
                            (dataItem.ResponseObject != null && dataItem.ResponseObject.ToString().Contains(search)) ||
                            (dataItem.OracleId != null && dataItem.OracleId.ToString().Contains(search)) ||
                            (dataItem.Pcc03Id != null && dataItem.Pcc03Id.ToString().Contains(search)))
                        {
                            listdto.Add(new RequestsDTO
                            {
                                Id = dataItem.Id,
                                OracleId = dataItem.OracleId,
                                Pcc03Id = dataItem.Pcc03Id,
                                Json = dataItem.JsonParentObject,
                                JsonChild = dataItem.JsonChildObject,
                                Response = dataItem.ResponseObject,
                                Exception = dataItem.ExceptionObject,
                                Status = ((Status)dataItem.Status).ToString(),
                                Added = dataItem.Added,
                                Updated = dataItem.Updated
                            });
                        }
                    }
                }
                else if (table == "6")
                {
                    foreach (Int006Job dataItem in _context.Int006Job)
                    {
                        if ((dataItem.JsonParentObject != null && dataItem.JsonParentObject.ToUpper().Contains(search.ToUpper())) ||
                            (dataItem.JsonChildObject != null && dataItem.JsonChildObject.ToString().Contains(search)) ||
                            (dataItem.ResponseObject != null && dataItem.ResponseObject.ToString().Contains(search)) ||
                            (dataItem.OracleId != null && dataItem.OracleId.ToString().Contains(search)) ||
                            (dataItem.Pcc03Id != null && dataItem.Pcc03Id.ToString().Contains(search)))
                        {
                            listdto.Add(new RequestsDTO
                            {
                                Id = dataItem.Id,
                                OracleId = dataItem.OracleId,
                                Pcc03Id = dataItem.Pcc03Id,
                                Json = dataItem.JsonParentObject,
                                JsonChild = dataItem.JsonChildObject,
                                Response = dataItem.ResponseObject,
                                Exception = dataItem.ExceptionObject,
                                Status = ((Status)dataItem.Status).ToString(),
                                Added = dataItem.Added,
                                Updated = dataItem.Updated
                            });
                        }
                    }
                }
                else if (table == "8")
                {
                    foreach (Int008MoveTran dataItem in _context.Int008MoveTran)
                    {
                        if ((dataItem.JsonParentObject != null && dataItem.JsonParentObject.ToUpper().Contains(search.ToUpper())) ||
                            (dataItem.JsonChildObject != null && dataItem.JsonChildObject.ToString().Contains(search)) ||
                            (dataItem.ResponseObject != null && dataItem.ResponseObject.ToString().Contains(search)) ||
                            (dataItem.OracleId != null && dataItem.OracleId.ToString().Contains(search)) ||
                            (dataItem.Pcc03Id != null && dataItem.Pcc03Id.ToString().Contains(search)))
                        {
                            listdto.Add(new RequestsDTO
                            {
                                Id = dataItem.Id,
                                OracleId = dataItem.OracleId,
                                Pcc03Id = dataItem.Pcc03Id,
                                Json = dataItem.JsonParentObject,
                                JsonChild = dataItem.JsonChildObject,
                                Response = dataItem.ResponseObject,
                                Exception = dataItem.ExceptionObject,
                                Status = ((Status)dataItem.Status).ToString(),
                                Added = dataItem.Added,
                                Updated = dataItem.Updated
                            });
                        }
                    }
                }
                else
                {
                    foreach (Int010CompleteTran dataItem in _context.Int010CompleteTran)
                    {
                        if ((dataItem.JsonParentObject != null && dataItem.JsonParentObject.ToUpper().Contains(search.ToUpper())) ||
                            (dataItem.JsonChildObject != null && dataItem.JsonChildObject.ToString().Contains(search)) ||
                            (dataItem.ResponseObject != null && dataItem.ResponseObject.ToString().Contains(search)) ||
                            (dataItem.OracleId != null && dataItem.OracleId.ToString().Contains(search)) ||
                            (dataItem.Pcc03Id != null && dataItem.Pcc03Id.ToString().Contains(search)))
                        {
                            listdto.Add(new RequestsDTO
                            {
                                Id = dataItem.Id,
                                OracleId = dataItem.OracleId,
                                Pcc03Id = dataItem.Pcc03Id,
                                Json = dataItem.JsonParentObject,
                                JsonChild = dataItem.JsonChildObject,
                                Response = dataItem.ResponseObject,
                                Exception = dataItem.ExceptionObject,
                                Status = ((Status)dataItem.Status).ToString(),
                                Added = dataItem.Added,
                                Updated = dataItem.Updated
                            });
                        }
                    }
                }
            }

            // simulate sort
            if (sortColumn == 0)
            {// sort Age
                listdto.Sort((x, y) => SortString((x.OracleId == null ? "" : x.OracleId.ToString()), (y.OracleId == null ? "" : y.OracleId.ToString()), sortDirection));
                //listdto.Sort((x, y) => SortString(x.OracleId.ToString(), y.OracleId.ToString(), sortDirection));
            }
            else if (sortColumn == 1)
            {// sort Age
                listdto.Sort((x, y) => SortString((x.Pcc03Id == null ? "" : x.Pcc03Id.ToString()), (y.Pcc03Id == null ? "" : y.Pcc03Id.ToString()), sortDirection));
                //listdto.Sort((x, y) => SortString(x.Pcc03Id.ToString(), y.Pcc03Id.ToString(), sortDirection));
            }
            else if (sortColumn == 2)
            {// sort Age
                listdto.Sort((x, y) => SortString((x.Json == null ? "" : x.Json.ToString()), (y.Json == null ? "" : y.Json.ToString()), sortDirection));
                //listdto.Sort((x, y) => SortString(x.Json.ToString(), y.Json.ToString(), sortDirection));
            }
            else if (sortColumn == 3)
            {// sort Age
                listdto.Sort((x, y) => SortString((x.JsonChild == null ? "" : x.JsonChild.ToString()), (y.JsonChild == null ? "" : y.JsonChild.ToString()), sortDirection));
                //listdto.Sort((x, y) => SortString(x.JsonChild.ToString(), y.JsonChild.ToString(), sortDirection));
            }
            else if (sortColumn == 4)
            {// sort Age
                listdto.Sort((x, y) => SortString((x.Response == null ? "" : x.Response.ToString()), (y.Response == null ? "" : y.Response.ToString()), sortDirection));
            }
            else if (sortColumn == 5)
            {// sort Age
                listdto.Sort((x, y) => SortString((x.Exception == null ? "" : x.Exception.ToString()), (y.Exception == null ? "" : y.Exception.ToString()), sortDirection));
                //listdto.Sort((x, y) => SortString(x.Exception.ToString(), y.Exception.ToString(), sortDirection));
            }
            else if (sortColumn == 6)
            {// sort Age
                listdto.Sort((x, y) => SortString((x.Status == null ? "" : x.Status.ToString()), (y.Status == null ? "" : y.Status.ToString()), sortDirection));
                //listdto.Sort((x, y) => SortString(x.Status.ToString(), y.Status.ToString(), sortDirection));
            }
            else if (sortColumn == 7)
            {// sort Name
                listdto.Sort((x, y) => SortDateTime((x.Added == null ? "" : x.Added.ToString()), (y.Added == null ? "" : y.Added.ToString()), sortDirection));
                //listdto.Sort((x, y) => SortDateTime(x.Added.ToString(), y.Added.ToString(), sortDirection));
            }

            recordFiltered = listdto.Count;

            // get just one page of data
            listdto = listdto.GetRange(start, Math.Min(length, listdto.Count - start));

            return listdto;
        }

        public List<MasterTable> MasterJobsFilterData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection)
        {
            List<MasterTable> list = new List<MasterTable>();
            if (string.IsNullOrEmpty(search))
            {
                list = _context.MasterTable.ToList();
            }
            else
            {
                foreach (MasterTable dataItem in _context.MasterTable)
                {
                    if ((dataItem.Note != null && dataItem.Note.ToUpper().Contains(search.ToUpper())) ||
                        (dataItem.OracleId != null && dataItem.OracleId.ToString().Contains(search)) ||
                        (dataItem.Pcc03Id != null && dataItem.Pcc03Id.ToString().Contains(search)))
                    {
                        list.Add(dataItem);
                    }
                }
            }

            // simulate sort
            if (sortColumn == 0)
            {// sort Age
                list.Sort((x, y) => SortString(x.OracleId.ToString(), y.OracleId.ToString(), sortDirection));
            }
            else if (sortColumn == 1)
            {// sort Age
                list.Sort((x, y) => SortString(x.Pcc03Id.ToString(), y.Pcc03Id.ToString(), sortDirection));
            }
            else if (sortColumn == 2)
            {// sort Age
                list.Sort((x, y) => SortString(x.Note.ToString(), y.Note.ToString(), sortDirection));
            }
            else if (sortColumn == 3)
            {// sort Age
                list.Sort((x, y) => SortString(x.Added.ToString(), y.Added.ToString(), sortDirection));
            }
            else if (sortColumn == 4)
            {// sort Age
                list.Sort((x, y) => SortString(x.Updated.ToString(), y.Updated.ToString(), sortDirection));
            }

            recordFiltered = list.Count;

            // get just one page of data
            list = list.GetRange(start, Math.Min(length, list.Count - start));

            return list;
        }

        #endregion Public Methods



        #region Private Methods

        private int SortString(string s1, string s2, string sortDirection)
        {
            if (s1 == null) { s1 = ""; }
            if (s2 == null) { s2 = ""; }
            return sortDirection == "asc" ? s1.CompareTo(s2) : s2.CompareTo(s1);
        }

        private int SortInteger(string s1, string s2, string sortDirection)
        {
            int i1 = int.Parse(s1);
            int i2 = int.Parse(s2);
            return sortDirection == "asc" ? i1.CompareTo(i2) : i2.CompareTo(i1);
        }

        private int SortDateTime(string s1, string s2, string sortDirection)
        {
            DateTime d1 = DateTime.Parse(s1);
            DateTime d2 = DateTime.Parse(s2);
            return sortDirection == "asc" ? d1.CompareTo(d2) : d2.CompareTo(d1);
        }

        #endregion Private Methods
    }
}
