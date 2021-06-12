using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.SHCA.EngineeringData;
using Wildcat.Utilities;

namespace Wildcat.Logic.SHCA.Engineering.Grinders
{
    public class SHCA_GrinderDailyContact
    {
        #region Private Fields

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IViewRenderService _viewRenderService;
        private readonly EngineeringDataContext _engineeringDataContext;

        private const int LOGON32_PROVIDER_DEFAULT = 0;

        //This parameter causes LogonUser to create a primary token.
        private const int LOGON32_LOGON_INTERACTIVE = 2;

        #endregion Private Fields


        #region Public Properties

        //public class ContactTimeDTO
        //{
        //    public long Id { get; set; }
        //    public string Name { get; set; }
        //    public int? Numericid { get; set; }
        //    public decimal Value { get; set; }
        //    public DateTime? Timestamp { get; set; }
        //    public int? Quality { get; set; }
        //}

        #endregion Public Properties


        #region Constructors

        public SHCA_GrinderDailyContact(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, EngineeringDataContext engineeringDataContext)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _engineeringDataContext = engineeringDataContext;
        }

        #endregion Constructors


        #region Public Methods

        public List<DataDTO> GetDailyGrinderProductionTimeByMachine(string machine, string property, DateTime fromdate, DateTime todate)
        {
            List<DataDTO> result = new List<DataDTO>();
            decimal hour = new decimal(); decimal min = new decimal();

            List<DatetimeDTO> timeList = new List<DatetimeDTO>();
            int i = 0;

            if (machine.Contains("FGA"))
            {
                var contactTime = _engineeringDataContext.Fga.Where(x => x.Property == property && x.Timestamp > fromdate && x.Timestamp < todate);
                foreach (var d in contactTime)
                {
                    result.Add(new DataDTO
                    {
                        Id = d.Id,
                        KepwareId = d.KepwareId,
                        Name = d.Name,
                        Numericid = d.Numericid,
                        Value = d.Value,
                        Timestamp = d.Timestamp,
                        Quality = d.Quality,
                        Property = d.Property,
                        Active = d.Active,
                        Added = d.Added,
                        AddedBy = d.AddedBy,
                        Updated = d.Updated,
                        UpdatedBy = d.UpdatedBy
                    });
                }
            }
            else if (machine.Contains("FGD1"))
            {
                var contactTime = _engineeringDataContext.Fgd1.Where(x => x.Property == property && x.Timestamp > fromdate && x.Timestamp < todate);
                foreach (var d in contactTime)
                {
                    result.Add(new DataDTO
                    {
                        Id = d.Id,
                        KepwareId = d.KepwareId,
                        Name = d.Name,
                        Numericid = d.Numericid,
                        Value = d.Value,
                        Timestamp = d.Timestamp,
                        Quality = d.Quality,
                        Property = d.Property,
                        Active = d.Active,
                        Added = d.Added,
                        AddedBy = d.AddedBy,
                        Updated = d.Updated,
                        UpdatedBy = d.UpdatedBy
                    });
                }
            }
            else if (machine.Contains("FGD2"))
            {
                var contactTime = _engineeringDataContext.Fgd2.Where(x => x.Property == property && x.Timestamp > fromdate && x.Timestamp < todate);
                foreach (var d in contactTime)
                {
                    result.Add(new DataDTO
                    {
                        Id = d.Id,
                        KepwareId = d.KepwareId,
                        Name = d.Name,
                        Numericid = d.Numericid,
                        Value = d.Value,
                        Timestamp = d.Timestamp,
                        Quality = d.Quality,
                        Property = d.Property,
                        Active = d.Active,
                        Added = d.Added,
                        AddedBy = d.AddedBy,
                        Updated = d.Updated,
                        UpdatedBy = d.UpdatedBy
                    });
                }
            }
            else if (machine.Contains("FGD3"))
            {
                var contactTime = _engineeringDataContext.Fgd3.Where(x => x.Property == property && x.Timestamp > fromdate && x.Timestamp < todate);
                foreach (var d in contactTime)
                {
                    result.Add(new DataDTO
                    {
                        Id = d.Id,
                        KepwareId = d.KepwareId,
                        Name = d.Name,
                        Numericid = d.Numericid,
                        Value = d.Value,
                        Timestamp = d.Timestamp,
                        Quality = d.Quality,
                        Property = d.Property,
                        Active = d.Active,
                        Added = d.Added,
                        AddedBy = d.AddedBy,
                        Updated = d.Updated,
                        UpdatedBy = d.UpdatedBy
                    });
                }
            }
            else if (machine.Contains("FGD4"))
            {
                var contactTime = _engineeringDataContext.Fgd4.Where(x => x.Property == property && x.Timestamp > fromdate && x.Timestamp < todate);
                foreach (var d in contactTime)
                {
                    result.Add(new DataDTO
                    {
                        Id = d.Id,
                        KepwareId = d.KepwareId,
                        Name = d.Name,
                        Numericid = d.Numericid,
                        Value = d.Value,
                        Timestamp = d.Timestamp,
                        Quality = d.Quality,
                        Property = d.Property,
                        Active = d.Active,
                        Added = d.Added,
                        AddedBy = d.AddedBy,
                        Updated = d.Updated,
                        UpdatedBy = d.UpdatedBy
                    });
                }
            }
            else if (machine.Contains("FGD5"))
            {
                var contactTime = _engineeringDataContext.Fgd5.Where(x => x.Property == property && x.Timestamp > fromdate && x.Timestamp < todate);
                foreach (var d in contactTime)
                {
                    result.Add(new DataDTO
                    {
                        Id = d.Id,
                        KepwareId = d.KepwareId,
                        Name = d.Name,
                        Numericid = d.Numericid,
                        Value = d.Value,
                        Timestamp = d.Timestamp,
                        Quality = d.Quality,
                        Property = d.Property,
                        Active = d.Active,
                        Added = d.Added,
                        AddedBy = d.AddedBy,
                        Updated = d.Updated,
                        UpdatedBy = d.UpdatedBy
                    });
                }
            }
            else if (machine.Contains("FGD6"))
            {
                var contactTime = _engineeringDataContext.Fgd6.Where(x => x.Property == property && x.Timestamp > fromdate && x.Timestamp < todate);
                foreach (var d in contactTime)
                {
                    result.Add(new DataDTO
                    {
                        Id = d.Id,
                        KepwareId = d.KepwareId,
                        Name = d.Name,
                        Numericid = d.Numericid,
                        Value = d.Value,
                        Timestamp = d.Timestamp,
                        Quality = d.Quality,
                        Property = d.Property,
                        Active = d.Active,
                        Added = d.Added,
                        AddedBy = d.AddedBy,
                        Updated = d.Updated,
                        UpdatedBy = d.UpdatedBy
                    });
                }
            }
            else if (machine.Contains("FGQ"))
            {
                var contactTime = _engineeringDataContext.Fgq.Where(x => x.Property == property && x.Timestamp > fromdate && x.Timestamp < todate);
                foreach (var d in contactTime)
                {
                    result.Add(new DataDTO
                    {
                        Id = d.Id,
                        KepwareId = d.KepwareId,
                        Name = d.Name,
                        Numericid = d.Numericid,
                        Value = d.Value,
                        Timestamp = d.Timestamp,
                        Quality = d.Quality,
                        Property = d.Property,
                        Active = d.Active,
                        Added = d.Added,
                        AddedBy = d.AddedBy,
                        Updated = d.Updated,
                        UpdatedBy = d.UpdatedBy
                    });
                }
            }
            else
            {
                var contactTime = _engineeringDataContext.Fgx.Where(x => x.Property == property && x.Timestamp > fromdate && x.Timestamp < todate);
                foreach (var d in contactTime)
                {
                    result.Add(new DataDTO
                    {
                        Id = d.Id,
                        KepwareId = d.KepwareId,
                        Name = d.Name,
                        Numericid = d.Numericid,
                        Value = d.Value,
                        Timestamp = d.Timestamp,
                        Quality = d.Quality,
                        Property = d.Property,
                        Active = d.Active,
                        Added = d.Added,
                        AddedBy = d.AddedBy,
                        Updated = d.Updated,
                        UpdatedBy = d.UpdatedBy
                    });
                }
            }

            return result;
        }

        public List<ContactTimeDTO> GetDailyContactTimeByMachine(string Machine, string property, DateTime fromdate, DateTime todate)
        {
            List<ContactTimeDTO> result = new List<ContactTimeDTO>();
            decimal hour = new decimal(); decimal min = new decimal();

            List<DatetimeDTO> timeList = new List<DatetimeDTO>();
            int i = 0;

            if (Machine == "FGA")
            {
                var contactTime = _engineeringDataContext.Fga.Where(x => x.Property == property && x.Timestamp > fromdate && x.Timestamp < todate);
                foreach (var d in contactTime)
                {
                    result.Add(new ContactTimeDTO
                    {
                        Id = d.Id,
                        KepwareId = d.KepwareId,
                        Name = d.Name,
                        Numericid = d.Numericid,
                        Value = d.Value,
                        Timestamp = d.Timestamp,
                        Quality = d.Quality,
                        Property = d.Property,
                        Active = d.Active,
                        Added = d.Added,
                        AddedBy = d.AddedBy,
                        Updated = d.Updated,
                        UpdatedBy = d.UpdatedBy
                    });
                }
            }
            else if (Machine == "FGD1")
            {
                var contactTime = _engineeringDataContext.Fgd1.Where(x => x.Property == property && x.Timestamp > fromdate && x.Timestamp < todate);
                foreach (var d in contactTime)
                {
                    result.Add(new ContactTimeDTO
                    {
                        Id = d.Id,
                        KepwareId = d.KepwareId,
                        Name = d.Name,
                        Numericid = d.Numericid,
                        Value = d.Value,
                        Timestamp = d.Timestamp,
                        Quality = d.Quality,
                        Property = d.Property,
                        Active = d.Active,
                        Added = d.Added,
                        AddedBy = d.AddedBy,
                        Updated = d.Updated,
                        UpdatedBy = d.UpdatedBy
                    });
                }
            }
            else if (Machine == "FGD2")
            {
                var contactTime = _engineeringDataContext.Fgd2.Where(x => x.Property == property && x.Timestamp > fromdate && x.Timestamp < todate);
                foreach (var d in contactTime)
                {
                    result.Add(new ContactTimeDTO
                    {
                        Id = d.Id,
                        KepwareId = d.KepwareId,
                        Name = d.Name,
                        Numericid = d.Numericid,
                        Value = d.Value,
                        Timestamp = d.Timestamp,
                        Quality = d.Quality,
                        Property = d.Property,
                        Active = d.Active,
                        Added = d.Added,
                        AddedBy = d.AddedBy,
                        Updated = d.Updated,
                        UpdatedBy = d.UpdatedBy
                    });
                }
            }
            else if (Machine == "FGD3")
            {
                var contactTime = _engineeringDataContext.Fgd3.Where(x => x.Property == property && x.Timestamp > fromdate && x.Timestamp < todate);
                foreach (var d in contactTime)
                {
                    result.Add(new ContactTimeDTO
                    {
                        Id = d.Id,
                        KepwareId = d.KepwareId,
                        Name = d.Name,
                        Numericid = d.Numericid,
                        Value = d.Value,
                        Timestamp = d.Timestamp,
                        Quality = d.Quality,
                        Property = d.Property,
                        Active = d.Active,
                        Added = d.Added,
                        AddedBy = d.AddedBy,
                        Updated = d.Updated,
                        UpdatedBy = d.UpdatedBy
                    });
                }
            }
            else if (Machine == "FGD4")
            {
                var contactTime = _engineeringDataContext.Fgd4.Where(x => x.Property == property && x.Timestamp > fromdate && x.Timestamp < todate);
                foreach (var d in contactTime)
                {
                    result.Add(new ContactTimeDTO
                    {
                        Id = d.Id,
                        KepwareId = d.KepwareId,
                        Name = d.Name,
                        Numericid = d.Numericid,
                        Value = d.Value,
                        Timestamp = d.Timestamp,
                        Quality = d.Quality,
                        Property = d.Property,
                        Active = d.Active,
                        Added = d.Added,
                        AddedBy = d.AddedBy,
                        Updated = d.Updated,
                        UpdatedBy = d.UpdatedBy
                    });
                }
            }
            else if (Machine == "FGD5")
            {
                var contactTime = _engineeringDataContext.Fgd5.Where(x => x.Property == property && x.Timestamp > fromdate && x.Timestamp < todate);
                foreach (var d in contactTime)
                {
                    result.Add(new ContactTimeDTO
                    {
                        Id = d.Id,
                        KepwareId = d.KepwareId,
                        Name = d.Name,
                        Numericid = d.Numericid,
                        Value = d.Value,
                        Timestamp = d.Timestamp,
                        Quality = d.Quality,
                        Property = d.Property,
                        Active = d.Active,
                        Added = d.Added,
                        AddedBy = d.AddedBy,
                        Updated = d.Updated,
                        UpdatedBy = d.UpdatedBy
                    });
                }
            }
            else if (Machine == "FGD6")
            {
                var contactTime = _engineeringDataContext.Fgd6.Where(x => x.Property == property && x.Timestamp > fromdate && x.Timestamp < todate);
                foreach (var d in contactTime)
                {
                    result.Add(new ContactTimeDTO
                    {
                        Id = d.Id,
                        KepwareId = d.KepwareId,
                        Name = d.Name,
                        Numericid = d.Numericid,
                        Value = d.Value,
                        Timestamp = d.Timestamp,
                        Quality = d.Quality,
                        Property = d.Property,
                        Active = d.Active,
                        Added = d.Added,
                        AddedBy = d.AddedBy,
                        Updated = d.Updated,
                        UpdatedBy = d.UpdatedBy
                    });
                }
            }
            else if (Machine == "FGQ")
            {
                var contactTime = _engineeringDataContext.Fgq.Where(x => x.Property == property && x.Timestamp > fromdate && x.Timestamp < todate);
                foreach (var d in contactTime)
                {
                    result.Add(new ContactTimeDTO
                    {
                        Id = d.Id,
                        KepwareId = d.KepwareId,
                        Name = d.Name,
                        Numericid = d.Numericid,
                        Value = d.Value,
                        Timestamp = d.Timestamp,
                        Quality = d.Quality,
                        Property = d.Property,
                        Active = d.Active,
                        Added = d.Added,
                        AddedBy = d.AddedBy,
                        Updated = d.Updated,
                        UpdatedBy = d.UpdatedBy
                    });
                }
            }
            else
            {
                var contactTime = _engineeringDataContext.Fgx.Where(x => x.Property == property && x.Timestamp > fromdate && x.Timestamp < todate);
                foreach (var d in contactTime)
                {
                    result.Add(new ContactTimeDTO
                    {
                        Id = d.Id,
                        KepwareId = d.KepwareId,
                        Name = d.Name,
                        Numericid = d.Numericid,
                        Value = d.Value,
                        Timestamp = d.Timestamp,
                        Quality = d.Quality,
                        Property = d.Property,
                        Active = d.Active,
                        Added = d.Added,
                        AddedBy = d.AddedBy,
                        Updated = d.Updated,
                        UpdatedBy = d.UpdatedBy
                    });
                }
            }

            return result;
        }

        public List<ContactTimeDTO> FilterContactTimeData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection, string machine)
        {
            String PROPERTY = machine + "_DAILYEND";
            List<ContactTimeDTO> listdto = new List<ContactTimeDTO>();
            if (string.IsNullOrEmpty(search))
            {
                if (machine.Contains("FGA"))
                {
                    foreach (var d in _engineeringDataContext.Fga.Where(x => x.Property == PROPERTY).OrderByDescending(x => x.Timestamp).Take(30).ToList())
                    {
                        listdto.Add(new ContactTimeDTO
                        {
                            Id = d.Id,
                            KepwareId = d.KepwareId,
                            Name = d.Name,
                            Numericid = d.Numericid,
                            Value = d.Value,
                            Timestamp = d.Timestamp,
                            Quality = d.Quality,
                            Property = d.Property,
                            Active = d.Active,
                            Added = d.Added,
                            AddedBy = d.AddedBy,
                            Updated = d.Updated,
                            UpdatedBy = d.UpdatedBy
                        });
                    }
                }
                else if (machine.Contains("FGD1"))
                {
                    foreach (var d in _engineeringDataContext.Fgd1.Where(x => x.Property == PROPERTY).OrderByDescending(x => x.Timestamp).Take(30).ToList())
                    {
                        listdto.Add(new ContactTimeDTO
                        {
                            Id = d.Id,
                            KepwareId = d.KepwareId,
                            Name = d.Name,
                            Numericid = d.Numericid,
                            Value = d.Value,
                            Timestamp = d.Timestamp,
                            Quality = d.Quality,
                            Property = d.Property,
                            Active = d.Active,
                            Added = d.Added,
                            AddedBy = d.AddedBy,
                            Updated = d.Updated,
                            UpdatedBy = d.UpdatedBy
                        });
                    }
                }
                else if (machine.Contains("FGD2"))
                {
                    foreach (var d in _engineeringDataContext.Fgd2.Where(x => x.Property == PROPERTY).OrderByDescending(x => x.Timestamp).Take(30).ToList())
                    {
                        listdto.Add(new ContactTimeDTO
                        {
                            Id = d.Id,
                            KepwareId = d.KepwareId,
                            Name = d.Name,
                            Numericid = d.Numericid,
                            Value = d.Value,
                            Timestamp = d.Timestamp,
                            Quality = d.Quality,
                            Property = d.Property,
                            Active = d.Active,
                            Added = d.Added,
                            AddedBy = d.AddedBy,
                            Updated = d.Updated,
                            UpdatedBy = d.UpdatedBy
                        });
                    }
                }
                else if (machine.Contains("FGD3"))
                {
                    foreach (var d in _engineeringDataContext.Fgd3.Where(x => x.Property == PROPERTY).OrderByDescending(x => x.Timestamp).Take(30).ToList())
                    {
                        listdto.Add(new ContactTimeDTO
                        {
                            Id = d.Id,
                            KepwareId = d.KepwareId,
                            Name = d.Name,
                            Numericid = d.Numericid,
                            Value = d.Value,
                            Timestamp = d.Timestamp,
                            Quality = d.Quality,
                            Property = d.Property,
                            Active = d.Active,
                            Added = d.Added,
                            AddedBy = d.AddedBy,
                            Updated = d.Updated,
                            UpdatedBy = d.UpdatedBy
                        });
                    }
                }
                else if (machine.Contains("FGD4"))
                {
                    foreach (var d in _engineeringDataContext.Fgd4.Where(x => x.Property == PROPERTY).OrderByDescending(x => x.Timestamp).Take(30).ToList())
                    {
                        listdto.Add(new ContactTimeDTO
                        {
                            Id = d.Id,
                            KepwareId = d.KepwareId,
                            Name = d.Name,
                            Numericid = d.Numericid,
                            Value = d.Value,
                            Timestamp = d.Timestamp,
                            Quality = d.Quality,
                            Property = d.Property,
                            Active = d.Active,
                            Added = d.Added,
                            AddedBy = d.AddedBy,
                            Updated = d.Updated,
                            UpdatedBy = d.UpdatedBy
                        });
                    }
                }
                else if (machine.Contains("FGD5"))
                {
                    foreach (var d in _engineeringDataContext.Fgd5.Where(x => x.Property == PROPERTY).OrderByDescending(x => x.Timestamp).Take(30).ToList())
                    {
                        listdto.Add(new ContactTimeDTO
                        {
                            Id = d.Id,
                            KepwareId = d.KepwareId,
                            Name = d.Name,
                            Numericid = d.Numericid,
                            Value = d.Value,
                            Timestamp = d.Timestamp,
                            Quality = d.Quality,
                            Property = d.Property,
                            Active = d.Active,
                            Added = d.Added,
                            AddedBy = d.AddedBy,
                            Updated = d.Updated,
                            UpdatedBy = d.UpdatedBy
                        });
                    }
                }
                else if (machine.Contains("FGD6"))
                {
                    foreach (var d in _engineeringDataContext.Fgd6.Where(x => x.Property == PROPERTY).OrderByDescending(x => x.Timestamp).Take(30).ToList())
                    {
                        listdto.Add(new ContactTimeDTO
                        {
                            Id = d.Id,
                            KepwareId = d.KepwareId,
                            Name = d.Name,
                            Numericid = d.Numericid,
                            Value = d.Value,
                            Timestamp = d.Timestamp,
                            Quality = d.Quality,
                            Property = d.Property,
                            Active = d.Active,
                            Added = d.Added,
                            AddedBy = d.AddedBy,
                            Updated = d.Updated,
                            UpdatedBy = d.UpdatedBy
                        });
                    }
                }
                else if (machine.Contains("FGQ"))
                {
                    foreach (var d in _engineeringDataContext.Fgq.Where(x => x.Property == PROPERTY).OrderByDescending(x => x.Timestamp).Take(30).ToList())
                    {
                        listdto.Add(new ContactTimeDTO
                        {
                            Id = d.Id,
                            KepwareId = d.KepwareId,
                            Name = d.Name,
                            Numericid = d.Numericid,
                            Value = d.Value,
                            Timestamp = d.Timestamp,
                            Quality = d.Quality,
                            Property = d.Property,
                            Active = d.Active,
                            Added = d.Added,
                            AddedBy = d.AddedBy,
                            Updated = d.Updated,
                            UpdatedBy = d.UpdatedBy
                        });
                    }
                }
                else if (machine.Contains("FGX"))
                {
                    foreach (var d in _engineeringDataContext.Fgx.Where(x => x.Property == PROPERTY).ToList().OrderByDescending(x => x.Timestamp).Take(30))
                    {
                        listdto.Add(new ContactTimeDTO
                        {
                            Id = d.Id,
                            KepwareId = d.KepwareId,
                            Name = d.Name,
                            Numericid = d.Numericid,
                            Value = d.Value,
                            Timestamp = d.Timestamp,
                            Quality = d.Quality,
                            Property = d.Property,
                            Active = d.Active,
                            Added = d.Added,
                            AddedBy = d.AddedBy,
                            Updated = d.Updated,
                            UpdatedBy = d.UpdatedBy
                        });
                    }
                }
            }
            else
            {
                if (machine == "FGA")
                {
                    foreach (var d in _engineeringDataContext.Fga.Where(x => x.Property == PROPERTY).OrderByDescending(x => x.Timestamp).Take(30).ToList())
                    {
                        if ((d.Name != null && d.Name.ToUpper().Contains(search.ToUpper())) ||
                            (d.Numericid != null && d.Numericid.ToString().Contains(search)) ||
                            (d.Value != null && d.Value.ToString().Contains(search)) ||
                            (d.Timestamp != null && d.Timestamp.ToString().Contains(search)) ||
                            (d.Property != null && d.Property.ToString().Contains(search)) ||
                            (d.Active != null && d.Active.ToString().Contains(search)))
                        {
                            listdto.Add(new ContactTimeDTO
                            {
                                Id = d.Id,
                                KepwareId = d.KepwareId,
                                Name = d.Name,
                                Numericid = d.Numericid,
                                Value = d.Value,
                                Timestamp = d.Timestamp,
                                Quality = d.Quality,
                                Property = d.Property,
                                Active = d.Active,
                                Added = d.Added,
                                AddedBy = d.AddedBy,
                                Updated = d.Updated,
                                UpdatedBy = d.UpdatedBy
                            });
                        }
                    }
                }
                else if (machine == "FGD1")
                {
                    foreach (var d in _engineeringDataContext.Fgd1.Where(x => x.Property == PROPERTY).OrderByDescending(x => x.Timestamp).Take(30).ToList())
                    {
                        if ((d.Name != null && d.Name.ToUpper().Contains(search.ToUpper())) ||
                            (d.Numericid != null && d.Numericid.ToString().Contains(search)) ||
                            (d.Value != null && d.Value.ToString().Contains(search)) ||
                            (d.Timestamp != null && d.Timestamp.ToString().Contains(search)) ||
                            (d.Property != null && d.Property.ToString().Contains(search)) ||
                            (d.Active != null && d.Active.ToString().Contains(search)))
                        {
                            listdto.Add(new ContactTimeDTO
                            {
                                Id = d.Id,
                                KepwareId = d.KepwareId,
                                Name = d.Name,
                                Numericid = d.Numericid,
                                Value = d.Value,
                                Timestamp = d.Timestamp,
                                Quality = d.Quality,
                                Property = d.Property,
                                Active = d.Active,
                                Added = d.Added,
                                AddedBy = d.AddedBy,
                                Updated = d.Updated,
                                UpdatedBy = d.UpdatedBy
                            });
                        }
                    }
                }
                else if (machine == "FGD2")
                {
                    foreach (var d in _engineeringDataContext.Fgd2.Where(x => x.Property == PROPERTY).OrderByDescending(x => x.Timestamp).Take(30).ToList())
                    {
                        if ((d.Name != null && d.Name.ToUpper().Contains(search.ToUpper())) ||
                            (d.Numericid != null && d.Numericid.ToString().Contains(search)) ||
                            (d.Value != null && d.Value.ToString().Contains(search)) ||
                            (d.Timestamp != null && d.Timestamp.ToString().Contains(search)) ||
                            (d.Property != null && d.Property.ToString().Contains(search)) ||
                            (d.Active != null && d.Active.ToString().Contains(search)))
                        {
                            listdto.Add(new ContactTimeDTO
                            {
                                Id = d.Id,
                                KepwareId = d.KepwareId,
                                Name = d.Name,
                                Numericid = d.Numericid,
                                Value = d.Value,
                                Timestamp = d.Timestamp,
                                Quality = d.Quality,
                                Property = d.Property,
                                Active = d.Active,
                                Added = d.Added,
                                AddedBy = d.AddedBy,
                                Updated = d.Updated,
                                UpdatedBy = d.UpdatedBy
                            });
                        }
                    }
                }
                else if (machine == "FGD3")
                {
                    foreach (var d in _engineeringDataContext.Fgd3.Where(x => x.Property == PROPERTY).OrderByDescending(x => x.Timestamp).Take(30).ToList())
                    {
                        if ((d.Name != null && d.Name.ToUpper().Contains(search.ToUpper())) ||
                            (d.Numericid != null && d.Numericid.ToString().Contains(search)) ||
                            (d.Value != null && d.Value.ToString().Contains(search)) ||
                            (d.Timestamp != null && d.Timestamp.ToString().Contains(search)) ||
                            (d.Property != null && d.Property.ToString().Contains(search)) ||
                            (d.Active != null && d.Active.ToString().Contains(search)))
                        {
                            listdto.Add(new ContactTimeDTO
                            {
                                Id = d.Id,
                                KepwareId = d.KepwareId,
                                Name = d.Name,
                                Numericid = d.Numericid,
                                Value = d.Value,
                                Timestamp = d.Timestamp,
                                Quality = d.Quality,
                                Property = d.Property,
                                Active = d.Active,
                                Added = d.Added,
                                AddedBy = d.AddedBy,
                                Updated = d.Updated,
                                UpdatedBy = d.UpdatedBy
                            });
                        }
                    }
                }
                else if (machine == "FGD4")
                {
                    foreach (var d in _engineeringDataContext.Fgd4.Where(x => x.Property == PROPERTY).OrderByDescending(x => x.Timestamp).Take(30).ToList())
                    {
                        if ((d.Name != null && d.Name.ToUpper().Contains(search.ToUpper())) ||
                            (d.Numericid != null && d.Numericid.ToString().Contains(search)) ||
                            (d.Value != null && d.Value.ToString().Contains(search)) ||
                            (d.Timestamp != null && d.Timestamp.ToString().Contains(search)) ||
                            (d.Property != null && d.Property.ToString().Contains(search)) ||
                            (d.Active != null && d.Active.ToString().Contains(search)))
                        {
                            listdto.Add(new ContactTimeDTO
                            {
                                Id = d.Id,
                                KepwareId = d.KepwareId,
                                Name = d.Name,
                                Numericid = d.Numericid,
                                Value = d.Value,
                                Timestamp = d.Timestamp,
                                Quality = d.Quality,
                                Property = d.Property,
                                Active = d.Active,
                                Added = d.Added,
                                AddedBy = d.AddedBy,
                                Updated = d.Updated,
                                UpdatedBy = d.UpdatedBy
                            });
                        }
                    }
                }
                else if (machine == "FGD5")
                {
                    foreach (var d in _engineeringDataContext.Fgd5.Where(x => x.Property == PROPERTY).OrderByDescending(x => x.Timestamp).Take(30).ToList())
                    {
                        if ((d.Name != null && d.Name.ToUpper().Contains(search.ToUpper())) ||
                            (d.Numericid != null && d.Numericid.ToString().Contains(search)) ||
                            (d.Value != null && d.Value.ToString().Contains(search)) ||
                            (d.Timestamp != null && d.Timestamp.ToString().Contains(search)) ||
                            (d.Property != null && d.Property.ToString().Contains(search)) ||
                            (d.Active != null && d.Active.ToString().Contains(search)))
                        {
                            listdto.Add(new ContactTimeDTO
                            {
                                Id = d.Id,
                                KepwareId = d.KepwareId,
                                Name = d.Name,
                                Numericid = d.Numericid,
                                Value = d.Value,
                                Timestamp = d.Timestamp,
                                Quality = d.Quality,
                                Property = d.Property,
                                Active = d.Active,
                                Added = d.Added,
                                AddedBy = d.AddedBy,
                                Updated = d.Updated,
                                UpdatedBy = d.UpdatedBy
                            });
                        }
                    }
                }
                else if (machine == "FGD6")
                {
                    foreach (var d in _engineeringDataContext.Fgd6.Where(x => x.Property == PROPERTY).OrderByDescending(x => x.Timestamp).Take(30).ToList())
                    {
                        if ((d.Name != null && d.Name.ToUpper().Contains(search.ToUpper())) ||
                            (d.Numericid != null && d.Numericid.ToString().Contains(search)) ||
                            (d.Value != null && d.Value.ToString().Contains(search)) ||
                            (d.Timestamp != null && d.Timestamp.ToString().Contains(search)) ||
                            (d.Property != null && d.Property.ToString().Contains(search)) ||
                            (d.Active != null && d.Active.ToString().Contains(search)))
                        {
                            listdto.Add(new ContactTimeDTO
                            {
                                Id = d.Id,
                                KepwareId = d.KepwareId,
                                Name = d.Name,
                                Numericid = d.Numericid,
                                Value = d.Value,
                                Timestamp = d.Timestamp,
                                Quality = d.Quality,
                                Property = d.Property,
                                Active = d.Active,
                                Added = d.Added,
                                AddedBy = d.AddedBy,
                                Updated = d.Updated,
                                UpdatedBy = d.UpdatedBy
                            });
                        }
                    }
                }
                else if (machine == "FGQ")
                {
                    foreach (var d in _engineeringDataContext.Fgq.Where(x => x.Property == PROPERTY).OrderByDescending(x => x.Timestamp).Take(30).ToList())
                    {
                        if ((d.Name != null && d.Name.ToUpper().Contains(search.ToUpper())) ||
                            (d.Numericid != null && d.Numericid.ToString().Contains(search)) ||
                            (d.Value != null && d.Value.ToString().Contains(search)) ||
                            (d.Timestamp != null && d.Timestamp.ToString().Contains(search)) ||
                            (d.Property != null && d.Property.ToString().Contains(search)) ||
                            (d.Active != null && d.Active.ToString().Contains(search)))
                        {
                            listdto.Add(new ContactTimeDTO
                            {
                                Id = d.Id,
                                KepwareId = d.KepwareId,
                                Name = d.Name,
                                Numericid = d.Numericid,
                                Value = d.Value,
                                Timestamp = d.Timestamp,
                                Quality = d.Quality,
                                Property = d.Property,
                                Active = d.Active,
                                Added = d.Added,
                                AddedBy = d.AddedBy,
                                Updated = d.Updated,
                                UpdatedBy = d.UpdatedBy
                            });
                        }
                    }
                }
                else if (machine == "FGX")
                {
                    foreach (var d in _engineeringDataContext.Fgx.OrderByDescending(x => x.Timestamp).Take(30).ToList())
                    {
                        if ((d.Name != null && d.Name.ToUpper().Contains(search.ToUpper())) ||
                            (d.Numericid != null && d.Numericid.ToString().Contains(search)) ||
                            (d.Value != null && d.Value.ToString().Contains(search)) ||
                            (d.Timestamp != null && d.Timestamp.ToString().Contains(search)) ||
                            (d.Property != null && d.Property.ToString().Contains(search)) ||
                            (d.Active != null && d.Active.ToString().Contains(search)))
                        {
                            listdto.Add(new ContactTimeDTO
                            {
                                Id = d.Id,
                                KepwareId = d.KepwareId,
                                Name = d.Name,
                                Numericid = d.Numericid,
                                Value = d.Value,
                                Timestamp = d.Timestamp,
                                Quality = d.Quality,
                                Property = d.Property,
                                Active = d.Active,
                                Added = d.Added,
                                AddedBy = d.AddedBy,
                                Updated = d.Updated,
                                UpdatedBy = d.UpdatedBy
                            });
                        }
                    }
                }
                else if (machine == "FGQ_Motor")
                {
                    foreach (var d in _engineeringDataContext.Fgq.Where(x => x.Property == PROPERTY).OrderByDescending(x => x.Timestamp).Take(30).ToList())
                    {
                        if ((d.Name != null && d.Name.ToUpper().Contains(search.ToUpper())) ||
                            (d.Numericid != null && d.Numericid.ToString().Contains(search)) ||
                            (d.Value != null && d.Value.ToString().Contains(search)) ||
                            (d.Timestamp != null && d.Timestamp.ToString().Contains(search)) ||
                            (d.Property != null && d.Property.ToString().Contains(search)) ||
                            (d.Active != null && d.Active.ToString().Contains(search)))
                        {
                            listdto.Add(new ContactTimeDTO
                            {
                                Id = d.Id,
                                KepwareId = d.KepwareId,
                                Name = d.Name,
                                Numericid = d.Numericid,
                                Value = d.Value,
                                Timestamp = d.Timestamp,
                                Quality = d.Quality,
                                Property = d.Property,
                                Active = d.Active,
                                Added = d.Added,
                                AddedBy = d.AddedBy,
                                Updated = d.Updated,
                                UpdatedBy = d.UpdatedBy
                            });
                        }
                    }
                }
                else if (machine == "FGX_Motor")
                {
                    foreach (var d in _engineeringDataContext.Fgx.OrderByDescending(x => x.Timestamp).Take(30).ToList())
                    {
                        if ((d.Name != null && d.Name.ToUpper().Contains(search.ToUpper())) ||
                            (d.Numericid != null && d.Numericid.ToString().Contains(search)) ||
                            (d.Value != null && d.Value.ToString().Contains(search)) ||
                            (d.Timestamp != null && d.Timestamp.ToString().Contains(search)) ||
                            (d.Property != null && d.Property.ToString().Contains(search)) ||
                            (d.Active != null && d.Active.ToString().Contains(search)))
                        {
                            listdto.Add(new ContactTimeDTO
                            {
                                Id = d.Id,
                                KepwareId = d.KepwareId,
                                Name = d.Name,
                                Numericid = d.Numericid,
                                Value = d.Value,
                                Timestamp = d.Timestamp,
                                Quality = d.Quality,
                                Property = d.Property,
                                Active = d.Active,
                                Added = d.Added,
                                AddedBy = d.AddedBy,
                                Updated = d.Updated,
                                UpdatedBy = d.UpdatedBy
                            });
                        }
                    }
                }
            }

            // simulate sort
            if (sortColumn == 0)
            {// sort Age
                listdto.Sort((x, y) => SortDateTime(x.Timestamp.ToString(), y.Timestamp.ToString(), sortDirection));
            }
            else if (sortColumn == 1)
            {// sort Age
                listdto.Sort((x, y) => SortString(x.Value.ToString(), y.Value.ToString(), sortDirection));
            }

            recordFiltered = listdto.Count;

            // get just one page of data
            listdto = listdto.GetRange(start, Math.Min(length, listdto.Count - start));

            return listdto;
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

        private static bool GetBoolValue(object val)
        {
            bool result = false;

            try
            {
                val = Convert.ToInt32(val);
                return Convert.ToBoolean(val);
            }
            catch
            {
                return false;
            }
        }

        private static string GetBoolColor(object val)
        {
            string result = "red";

            try
            {
                if (Convert.ToBoolean(Convert.ToInt32(val)))
                {
                    result = "green";
                }
            }
            catch
            {
                result = "red";
            }
            return result;
        }

        #endregion Private Methods
    }
}