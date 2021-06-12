using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//TODO which model do i use using Wildcat.App.Models;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Logic.Models;
using Wildcat.Logic.PCC.Wildcat;
using Wildcat.Utilities;
using static Wildcat.Logic.PCC.Wildcat.MachineAdministration;

namespace Wildcat.App.ViewModels.Engineering
{
    #region - ViewModels

    public class MachineIndexViewModel
    {
        public List<MachineIndexDTO> Machines { get; set; }
        public MachineIndexViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext)
        {
            Machines = new List<MachineIndexDTO>();
        }
    }

    public class AddMachineViewModel
    {
        public Machine Machine { get; set; }
        public string SortOrder { get; set; }
        public List<SelectListItem> MachineType { get; set; }
        public List<SelectListItem> propertytypes { get; set; }
        public string MachineDef { get; set; }

        public List<MachinePropertyDTO> properties { get; set; }
        public MachinePropertyDTO newprop { get; set; }
        public MachinePropertyDTO editprop { get; set; }

        public List<MachineNote> notes { get; set; }
        public MachineNote addnote { get; set; }
        public MachineNote editnote { get; set; }

        public AddMachineViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext)
        {
            Machine = new Machine();
            MachineType = new List<SelectListItem>();

            bool selected = true;
            foreach (var t in wildcatContext.MachineType.Where(x => x.LocationCode == httpContextAccessor.HttpContext.Request.Cookies["SelectedLocation"]).OrderBy(x => x.MachineType1))
            {
                MachineType.Add(new SelectListItem { Text = t.MachineType1, Value = t.Id, Selected = selected });
                if (selected)
                {
                    MachineDef = t.Definition;
                }
                selected = false;
            }

            newprop = new MachinePropertyDTO();
            editprop = new MachinePropertyDTO();
            //var vm = wildcatContext.MachineProperty.Where(x => x.MachineId == MachineId).ToList();
            properties = new List<MachinePropertyDTO>();
            //foreach (var v in vm)
            //{
            //    vmlist.Add(new MachinePropertyDTO
            //    {
            //        MachineId = v.MachineId,
            //        PropertyMetadataId = v.PropertyId,
            //        Value = v.Value,
            //        Active = v.Active,
            //        Display = wildcatContext.MachinePropertyMetadata.Where(x => x.Id == v.PropertyId).FirstOrDefault().DisplayName
            //    });
            //}

            propertytypes = new List<SelectListItem>();
            foreach (var t in wildcatContext.MachinePropertyMetadata.Where(x => x.LocationCode == httpContextAccessor.HttpContext.Request.Cookies["SelectedLocation"]))
            {
                propertytypes.Add(new SelectListItem { Text = t.DisplayName, Value = t.Id, Selected = false });
            }

            addnote = new MachineNote();
            editnote = new MachineNote();
            //var vm = wildcatContext.MachineNote.Where(x => x.MachineId == MachineId).ToList();
            notes = new List<MachineNote>();

            //foreach (var v in vm)
            //{
            //    vmlist.Add(new MachinePropertyDTO
            //    {
            //        MachineId = v.MachineId,
            //        PropertyMetadataId = v.PropertyId,
            //        Value = v.Value,
            //        Active = v.Active,
            //        Display = wildcatContext.MachinePropertyMetadata.Where(x => x.Id == v.PropertyId).FirstOrDefault().DisplayName
            //    });
            //}
        }
    }

    public class EditMachineViewModel
    {
        public Machine Machine { get; set; }
        public string SortOrder { get; set; }
        public List<SelectListItem> MachineType { get; set; }
        public List<SelectListItem> propertytypes { get; set; }
        public string MachineDef { get; set; }

        public List<MachinePropertyDTO> properties { get; set; }
        public MachinePropertyDTO newprop { get; set; }
        public MachinePropertyDTO editprop { get; set; }

        public List<MachineNote> notes { get; set; }
        public MachineNote addnote { get; set; }
        public MachineNote editnote { get; set; }
        public EditMachineViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, Guid Id)
        {
            Machine = wildcatContext.Machine.Where(x => x.Id == Id.ToString()).FirstOrDefault();
            MachineType = new List<SelectListItem>();
            foreach (var t in wildcatContext.MachineType.Where(x => x.LocationCode == httpContextAccessor.HttpContext.Request.Cookies["SelectedLocation"]))
            {
                MachineType.Add(new SelectListItem { Text = t.MachineType1, Value = t.Id, Selected = Machine.Type == t.Id ? true : false });
                if (Machine.Type == t.Id)
                {
                    MachineDef = t.Definition;
                }
            }


            newprop = new MachinePropertyDTO();
            editprop = new MachinePropertyDTO();
            var props = wildcatContext.MachineProperty.Where(x => x.MachineId == Machine.Id).ToList();
            properties = new List<MachinePropertyDTO>();
            foreach (var v in props)
            {
                properties.Add(new MachinePropertyDTO
                {
                    Id = v.Id,
                    MachineId = v.MachineId,
                    PropertyMetadataId = v.Id,
                    Value = v.Value,
                    Active = v.Active,
                    Display = wildcatContext.MachinePropertyMetadata.Where(x => x.Id == v.PropertyId).FirstOrDefault().DisplayName
                });
            }

            propertytypes = new List<SelectListItem>();
            foreach (var t in wildcatContext.MachinePropertyMetadata.Where(x => x.LocationCode == httpContextAccessor.HttpContext.Request.Cookies["SelectedLocation"]))
            {
                propertytypes.Add(new SelectListItem { Text = t.DisplayName, Value = t.Id, Selected = false });
            }

            addnote = new MachineNote();
            editnote = new MachineNote();
            notes = wildcatContext.MachineNote.Where(x => x.MachineId == Machine.Id).ToList();
        }
    }

    public class MachineTypeViewModel
    {
        public List<MachineType> MachineTypes { get; set; }
        public MachineType addtype { get; set; }
        public MachineType edittype { get; set; }

        public MachineTypeViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext)
        {
            MachineTypes = new List<MachineType>();
            addtype = new MachineType();
            edittype = new MachineType();

            MachineTypes = wildcatContext.MachineType.Where(x => x.LocationCode == httpContextAccessor.HttpContext.Request.Cookies["SelectedLocation"]).ToList();
        }
    }


    public class MachinePropertyViewModel
    {
        public List<MachinePropertyMetadata> MachineProperties { get; set; }
        public MachinePropertyMetadata addprop { get; set; }
        public MachinePropertyMetadata editprop { get; set; }
        public List<SelectListItem> datatypes { get; set; }

        public MachinePropertyViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext)
        {
            MachineProperties = new List<MachinePropertyMetadata>();
            addprop = new MachinePropertyMetadata();
            editprop = new MachinePropertyMetadata();

            datatypes = Enum.GetValues(typeof(System.Data.DbType)).Cast<System.Data.DbType>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = v.ToString()
            }).ToList();

            MachineProperties = wildcatContext.MachinePropertyMetadata.Where(x => x.LocationCode == httpContextAccessor.HttpContext.Request.Cookies["SelectedLocation"]).ToList();
        }
    }

    public class EditMachinePropertyPartialViewModel
    {
        public MachinePropertyMetadata editprop { get; set; }
        public List<SelectListItem> datatypes { get; set; }

        public EditMachinePropertyPartialViewModel()
        {
            editprop = new MachinePropertyMetadata();

            datatypes = Enum.GetValues(typeof(System.Data.DbType)).Cast<System.Data.DbType>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = v.ToString()
            }).ToList();
        }
    }

    public class EditMachinePropertyValuePartialViewModel
    {
        public MachinePropertyDTO editprop { get; set; }
        public List<SelectListItem> propertytypes { get; set; }

    }

    //public class AddMachineTypeViewModel
    //{
    //    public MachineType MachineType { get; set; }
    //    public string SortOrder { get; set; }

    //    public AddMachineTypeViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext)
    //    {
    //        MachineType = new MachineType();
    //    }
    //}

    //public class EditMachineTypeViewModel
    //{
    //    public MachineType MachineType { get; set; }
    //    public string SortOrder { get; set; }
    //    public EditMachineTypeViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, Guid Id)
    //    {
    //        MachineType = wildcatContext.MachineType.Where(x => x.Id == Id.ToString()).FirstOrDefault();
    //    }
    //}

    //public class AddMachinePropertyViewModel
    //{
    //    public MachinePropertyMetadata MachineProperty { get; set; }
    //    public string SortOrder { get; set; }

    //    public AddMachinePropertyViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext)
    //    {
    //        MachineProperty = new MachinePropertyMetadata();
    //    }
    //}

    //public class EditMachinePropertyViewModel
    //{
    //    public MachinePropertyMetadata MachineProperty { get; set; }
    //    public MetadataValue PropertyValue { get; set; }
    //    public List<MetadataValue> Values { get; set; }
    //    public string SortOrder { get; set; }
    //    public EditMachinePropertyViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, Guid Id)
    //    {
    //        MachineProperty = wildcatContext.MachinePropertyMetadata.Where(x => x.Id == Id.ToString()).FirstOrDefault();
    //        PropertyValue = new MetadataValue();
    //        Values = new List<MetadataValue>();
    //        if(MachineProperty.Datatype == "List")
    //        {
    //            var mpmv = wildcatContext.MachinePropertyMetadataValue.Where(x => x.MachinePropertyId == MachineProperty.Id.ToString()).ToList();
    //            foreach(var m in mpmv)
    //            {
    //                Values.Add(wildcatContext.MetadataValue.Where(x => x.Id == m.MetadataValueId).FirstOrDefault());
    //            }
    //        }
    //        else
    //        {
    //            var mpmv = wildcatContext.MachinePropertyMetadataValue.Where(x => x.MachinePropertyId == MachineProperty.Id.ToString()).FirstOrDefault();
    //            PropertyValue = wildcatContext.MetadataValue.Where(x => x.Id == mpmv.MetadataValueId).FirstOrDefault();
    //        }
    //    }
    //}

    #endregion - ViewModels



    #region - Models

    public class MachinePropertyDTO
    {
        public string Id { get; set; }
        public string MachineId { get; set; }
        public string PropertyMetadataId { get; set; }
        public string Display { get; set; }
        public string Value { get; set; }
        public bool Active { get; set; }
    }

    //public class MachineTypeDTO
    //{
    //    public string MachineId { get; set; }
    //    public string Machine { get; set; }
    //    public string TypeId { get; set; }
    //    public string Type { get; set; }
    //    public string Definition { get; set; }
    //    public bool Active { get; set; }
    //}

    #endregion - Models



    #region - Api

    public class MachinePropertyPartial : Response
    {
        public MachinePropertyMetadata editprop { get; set; }
        public List<SelectListItem> datatypes { get; set; }

        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }

        public MachinePropertyPartial(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string Id)
        {
            _viewRenderService = viewRenderService;
            try
            {
                editprop = wildcatContext.MachinePropertyMetadata.Where(x => x.Id == Id).FirstOrDefault();
                if (editprop == null)
                {
                    success = false;
                    message = "Could not find requested property, please contact administrator.";
                }
                else
                {
                    EditMachinePropertyPartialViewModel m = new EditMachinePropertyPartialViewModel();

                    m.editprop = m.editprop;

                    Form = _viewRenderService.RenderToStringAsync("Engineering/Machine/MachinePropertyPartial", m);
                    success = true;
                    message = "";
                }
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }

    }

    public class EditMachineTypePartial : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public EditMachineTypePartial(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string Id)
        {
            _viewRenderService = viewRenderService;
            try
            {
                MachineType vm = wildcatContext.MachineType.Where(x => x.Id == Id).FirstOrDefault();
                if (vm == null)
                {
                    success = false;
                    message = "Could not find requested machine type, please contact administrator.";
                }
                else
                {
                    Form = _viewRenderService.RenderToStringAsync("Engineering/Machine/MachineTypePartial", vm);
                    success = true;
                    message = "";
                }
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditMachinePropertyValuePartial : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public EditMachinePropertyValuePartial(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string Id)
        {
            _viewRenderService = viewRenderService;
            try
            {
                MachineProperty vm = wildcatContext.MachineProperty.Where(x => x.Id == Id).FirstOrDefault();
                if (vm == null)
                {
                    success = false;
                    message = "Could not find requested machine property, please contact administrator.";
                }
                else
                {
                    var partial = new MachinePropertyDTO
                    {
                        Id = vm.Id,
                        MachineId = vm.MachineId,
                        PropertyMetadataId = vm.PropertyId,
                        Display = wildcatContext.MachinePropertyMetadata.Where(x => x.Id == vm.PropertyId).FirstOrDefault().DisplayName,
                        Value = vm.Value,
                        Active = vm.Active
                    };

                    EditMachinePropertyValuePartialViewModel vmodel = new EditMachinePropertyValuePartialViewModel();
                    vmodel.editprop = partial;
                    vmodel.propertytypes = new List<SelectListItem>();
                    foreach (var t in wildcatContext.MachinePropertyMetadata.Where(x => x.LocationCode == httpContextAccessor.HttpContext.Request.Cookies["SelectedLocation"]).OrderBy(x => x.DisplayName))
                    {
                        vmodel.propertytypes.Add(new SelectListItem { Text = t.DisplayName, Value = t.Id, Selected = (t.Id == vm.PropertyId ? true : false) });
                    }
                    vmodel.propertytypes.Where(x => x.Value == vm.PropertyId).FirstOrDefault().Selected = true;
                    Form = _viewRenderService.RenderToStringAsync("Engineering/Machine/EditMachinePropertyPartial", vmodel);
                    success = true;
                    message = "";
                }
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditMachineNotePartial : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public EditMachineNotePartial(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string Id)
        {
            _viewRenderService = viewRenderService;
            try
            {
                MachineNote vm = wildcatContext.MachineNote.Where(x => x.Id == Id).FirstOrDefault();
                if (vm == null)
                {
                    success = false;
                    message = "Could not find requested machine note, please contact administrator.";
                }
                else
                {
                    Form = _viewRenderService.RenderToStringAsync("Engineering/Machine/EditMachineNotePartial", vm);
                    success = true;
                    message = "";
                }
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }

    }

    public class AddMachineResult : Response
    {
        private IViewRenderService _viewRenderService;
        public string MachineId { get; set; }
        public Task<string> Form { get; set; }
        public AddMachineResult(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string MachineName, string Status, bool Active, string Type)
        {
            _viewRenderService = viewRenderService;
            try
            {
                var machine = new Machine
                {
                    Id = Guid.NewGuid().ToString(),
                    MachineName = MachineName,
                    LocationCode = httpContextAccessor.HttpContext.Request.Cookies["SelectedLocation"],
                    Status = Status,
                    Type = Type,
                    Active = Active,
                    Added = DateTime.UtcNow,
                    AddedBy = httpContextAccessor.HttpContext.User.Identity.Name
                };

                wildcatContext.Machine.Add(machine);

                wildcatContext.SaveChanges();

                MachineId = machine.Id;
                success = true;
                message = "Machine metadata property added.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditMachineResult : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public EditMachineResult(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string Id, string MachineName, string Status, bool Active, string Type)
        {
            _viewRenderService = viewRenderService;
            try
            {
                Machine vm = wildcatContext.Machine.Where(x => x.Id == Id).FirstOrDefault();
                if (vm == null)
                {
                    success = false;
                    message = "Could not find requested machine, please contact administrator.";
                }
                else
                {
                    vm.MachineName = MachineName;
                    vm.Status = Status;
                    vm.Type = Type;
                    vm.Active = Active;
                    vm.Updated = DateTime.UtcNow;
                    vm.UpdatedBy = httpContextAccessor.HttpContext.User.Identity.Name;

                    wildcatContext.SaveChanges();

                    success = true;
                    message = vm.MachineName + " successfully edited.";
                }
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class AddTypeResult : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public AddTypeResult(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string Type, string Definition, bool Active)
        {
            _viewRenderService = viewRenderService;
            try
            {
                wildcatContext.MachineType.Add(new MachineType
                {
                    Id = Guid.NewGuid().ToString(),
                    MachineType1 = Type,
                    LocationCode = httpContextAccessor.HttpContext.Request.Cookies["SelectedLocation"],
                    Definition = Definition,
                    Active = Active,
                    Added = DateTime.UtcNow,
                    AddedBy = httpContextAccessor.HttpContext.User.Identity.Name
                });

                wildcatContext.SaveChanges();

                success = true;
                message = "Machine metadata property added.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditTypeResult : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public EditTypeResult(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string Id, string Type, string Definition, bool Active)
        {
            _viewRenderService = viewRenderService;
            try
            {
                MachineType vm = wildcatContext.MachineType.Where(x => x.Id == Id).FirstOrDefault();
                if (vm == null)
                {
                    success = false;
                    message = "Could not find requested machine type, please contact administrator.";
                }
                else
                {
                    vm.MachineType1 = Type;
                    vm.Definition = Definition;
                    vm.Active = Active;
                    vm.Updated = DateTime.UtcNow;
                    vm.UpdatedBy = httpContextAccessor.HttpContext.User.Identity.Name;

                    wildcatContext.SaveChanges();

                    success = true;
                    message = vm.MachineType1 + " successfully edited.";
                }
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class AddMetadataResult : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public AddMetadataResult(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string Property, string DisplayName, bool IsRequired, string Definition, string DataType, bool Active)
        {
            _viewRenderService = viewRenderService;
            try
            {
                wildcatContext.MachinePropertyMetadata.Add(new MachinePropertyMetadata
                {
                    Id = Guid.NewGuid().ToString(),
                    PropertyName = Property,
                    DisplayName = DisplayName,
                    LocationCode = httpContextAccessor.HttpContext.Request.Cookies["SelectedLocation"],
                    IsRequired = IsRequired,
                    Definition = Definition,
                    Datatype = DataType,
                    Active = Active,
                    Added = DateTime.UtcNow,
                    AddedBy = httpContextAccessor.HttpContext.User.Identity.Name
                });

                wildcatContext.SaveChanges();

                success = true;
                message = "Machine metadata property added.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditMetadataResult : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public EditMetadataResult(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string Id, string Property, string DisplayName, bool IsRequired, string Definition, string DataType, bool Active)
        {
            _viewRenderService = viewRenderService;
            try
            {
                MachinePropertyMetadata vm = wildcatContext.MachinePropertyMetadata.Where(x => x.Id == Id).FirstOrDefault();
                if (vm == null)
                {
                    success = false;
                    message = "Could not find requested machine property, please contact administrator.";
                }
                else
                {
                    vm.PropertyName = Property;
                    vm.DisplayName = DisplayName;
                    vm.IsRequired = IsRequired;
                    vm.Definition = Definition;
                    vm.Datatype = DataType;
                    vm.Active = Active;
                    vm.Updated = DateTime.UtcNow;
                    vm.UpdatedBy = httpContextAccessor.HttpContext.User.Identity.Name;

                    wildcatContext.SaveChanges();

                    success = true;
                    message = vm.PropertyName + " successfully edited.";
                }
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }


    public class AddPropertyResult : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public AddPropertyResult(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string MachineId, string PropertyId, string Value, bool Active)
        {
            _viewRenderService = viewRenderService;
            try
            {
                wildcatContext.MachineProperty.Add(new MachineProperty
                {
                    Id = Guid.NewGuid().ToString(),
                    MachineId = MachineId,
                    PropertyId = PropertyId,
                    Value = Value,
                    Active = Active,
                    Added = DateTime.UtcNow,
                    AddedBy = httpContextAccessor.HttpContext.User.Identity.Name
                });

                wildcatContext.SaveChanges();

                var vm = wildcatContext.MachineProperty.Where(x => x.MachineId == MachineId).ToList();
                List<MachinePropertyDTO> vmlist = new List<MachinePropertyDTO>();

                foreach (var v in vm)
                {
                    vmlist.Add(new MachinePropertyDTO
                    {
                        MachineId = v.MachineId,
                        PropertyMetadataId = v.PropertyId,
                        Value = v.Value,
                        Active = v.Active,
                        Display = wildcatContext.MachinePropertyMetadata.Where(x => x.Id == v.PropertyId).FirstOrDefault().DisplayName
                    });
                }

                Form = _viewRenderService.RenderToStringAsync("Engineering/Machine/MachinePropertiesTablePartial", vmlist);
                success = true;
                message = "Machine property added.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }


    public class EditPropertyResult : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public EditPropertyResult(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string Id, string Value, bool Active)
        {
            _viewRenderService = viewRenderService;
            try
            {
                MachineProperty vm = wildcatContext.MachineProperty.Where(x => x.Id == Id).FirstOrDefault();
                if (vm == null)
                {
                    success = false;
                    message = "Could not find requested machine property, please contact administrator.";
                }
                else
                {
                    vm.Value = Value;
                    vm.Active = Active;
                    vm.Updated = DateTime.UtcNow;
                    vm.UpdatedBy = httpContextAccessor.HttpContext.User.Identity.Name;

                    wildcatContext.SaveChanges();

                    var mp = wildcatContext.MachineProperty.Where(x => x.MachineId == vm.MachineId).ToList();
                    List<MachinePropertyDTO> vmlist = new List<MachinePropertyDTO>();

                    foreach (var v in mp)
                    {
                        vmlist.Add(new MachinePropertyDTO
                        {
                            MachineId = v.MachineId,
                            PropertyMetadataId = v.PropertyId,
                            Value = v.Value,
                            Active = v.Active,
                            Display = wildcatContext.MachinePropertyMetadata.Where(x => x.Id == v.PropertyId).FirstOrDefault().DisplayName
                        });
                    }

                    Form = _viewRenderService.RenderToStringAsync("Engineering/Machine/MachinePropertiesTablePartial", vmlist);

                    success = true;
                    message = wildcatContext.MachinePropertyMetadata.Where(x => x.Id == vm.PropertyId).FirstOrDefault().DisplayName + " value successfully edited to: " + vm.Value;
                }
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }


    public class AddNoteResult : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public AddNoteResult(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string MachineId, string NoteType, string Note, bool Active)
        {
            _viewRenderService = viewRenderService;
            try
            {
                wildcatContext.MachineNote.Add(new MachineNote
                {
                    Id = Guid.NewGuid().ToString(),
                    MachineId = MachineId,
                    Note = Note,
                    NoteType = NoteType,
                    Active = Active,
                    Added = DateTime.UtcNow,
                    AddedBy = httpContextAccessor.HttpContext.User.Identity.Name
                });

                wildcatContext.SaveChanges();

                var vmList = wildcatContext.MachineNote.Where(x => x.MachineId == MachineId).ToList();
                Form = _viewRenderService.RenderToStringAsync("Engineering/Machine/MachinePropertiesTablePartial", vmList);

                success = true;
                message = "Machine note added.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }


    public class EditNoteResult : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public EditNoteResult(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string Id, string NoteType, string Note, bool Active)
        {
            _viewRenderService = viewRenderService;
            try
            {
                MachineNote vm = wildcatContext.MachineNote.Where(x => x.Id == Id).FirstOrDefault();
                if (vm == null)
                {
                    success = false;
                    message = "Could not find requested machine note, please contact administrator.";
                }
                else
                {
                    vm.Note = Note;
                    vm.NoteType = NoteType;
                    vm.Active = Active;
                    vm.Updated = DateTime.UtcNow;
                    vm.UpdatedBy = httpContextAccessor.HttpContext.User.Identity.Name;

                    wildcatContext.SaveChanges();

                    var vmList = wildcatContext.MachineNote.Where(x => x.MachineId == vm.MachineId).ToList();
                    Form = _viewRenderService.RenderToStringAsync("Engineering/Machine/MachinePropertiesTablePartial", vmList);

                    success = true;
                    message = wildcatContext.Machine.Where(x => x.Id == vm.MachineId).FirstOrDefault().MachineName + " note successfully edited to.";
                }
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class MachineDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<MachineIndexDTO> data { get; set; }

        public MachineDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<MachineIndexDTO>();
        }

    }

    public class MachineDataTableData
    {
        public MachineDataSet set;
        public MachineDataTableData(WildcatContext context, IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new MachineDataSet();

            MachineAdministration machineClass = new MachineAdministration(context, viewRenderService);
            var location = httpContextAccessor.HttpContext.Request.Cookies["SelectedLocation"];
            set.draw = draw;
            set.data = machineClass.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection, location);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    public class MachineTypeDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<MachineType> data { get; set; }

        public MachineTypeDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<MachineType>();
        }

    }

    public class MachineTypeDataTableData
    {
        public MachineTypeDataSet set;
        public MachineTypeDataTableData(WildcatContext context, IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new MachineTypeDataSet();

            MachineAdministration machineClass = new MachineAdministration(context, viewRenderService);
            var location = httpContextAccessor.HttpContext.Request.Cookies["SelectedLocation"];
            set.draw = draw;
            set.data = machineClass.FilterTypeData(ref recordsFiltered, start, length, search, sortColumn, sortDirection, location);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    public class MachinePropertyDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<MachinePropertyMetadata> data { get; set; }

        public MachinePropertyDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<MachinePropertyMetadata>();
        }

    }

    public class MachinePropertyDataTableData
    {
        public MachinePropertyDataSet set;
        public MachinePropertyDataTableData(WildcatContext context, IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new MachinePropertyDataSet();

            MachineAdministration machineClass = new MachineAdministration(context, viewRenderService);
            var location = httpContextAccessor.HttpContext.Request.Cookies["SelectedLocation"];
            set.draw = draw;
            set.data = machineClass.FilterPropertyData(ref recordsFiltered, start, length, search, sortColumn, sortDirection, location);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }


    #endregion - Api
}
