using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Utilities;

namespace Wildcat.Logic.PCC.Wildcat
{
    public class MachineAdministration
    {
        #region Private Fields

        private WildcatContext _context;
        private IViewRenderService _viewRenderService;

        #endregion Private Fields



        #region Public Properties

        public class MachineIndexDTO
        {
            public string Id { get; set; }
            public string MachineName { get; set; }
            public string DisplayName { get; set; }
            public string MachineType { get; set; }
            public string Status { get; set; }
            public bool Active { get; set; }
        }

        #endregion Public Properties



        #region Constructors

        public MachineAdministration(WildcatContext context, IViewRenderService viewRenderService)
        {
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Public Methods 

        public List<MachineIndexDTO> FilterData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection, string location)
        {
            List<Machine> list = new List<Machine>();
            List<MachineIndexDTO> result = new List<MachineIndexDTO>();

            if (string.IsNullOrEmpty(search))
            {
                list = _context.Machine.Where(x => x.LocationCode == location).ToList();
            }
            else
            {
                // simulate search
                foreach (Machine dataItem in _context.Machine.Where(x => x.LocationCode == location))
                {
                    if ((dataItem.MachineName != null && dataItem.MachineName.ToString().Contains(search)) ||
                        (dataItem.Status != null && dataItem.Status.ToString().Contains(search)))
                    {
                        list.Add(dataItem);
                    }

                    var type = _context.MachineType.Where(x => x.Id == dataItem.Type).FirstOrDefault();

                    if (!list.Contains(dataItem) && (type.MachineType1.Contains(search) || type.Definition.Contains(search)))
                    {
                        list.Add(dataItem);
                    }
                }
            }

            foreach (var m in list)
            {
                result.Add(new MachineIndexDTO
                {
                    Id = m.Id,
                    MachineName = m.MachineName,
                    MachineType = _context.MachineType.Where(x => x.Id == m.Type).FirstOrDefault().MachineType1,
                    Status = m.Status,
                    Active = m.Active
                });
            }

            // simulate sort
            if (sortColumn == 0)
            {// sort Age
                result.Sort((x, y) => SortString(x.MachineName.ToString(), y.MachineName.ToString(), sortDirection));
            }
            else if (sortColumn == 1)
            {// sort Age
                result.Sort((x, y) => SortString(x.MachineType.ToString(), y.MachineType.ToString(), sortDirection));
            }

            recordFiltered = list.Count;

            // get just one page of data
            result = result.GetRange(start, Math.Min(length, list.Count - start));

            return result;
        }

        public List<MachineType> FilterTypeData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection, string location)
        {
            List<MachineType> list = new List<MachineType>();
            List<MachineType> result = new List<MachineType>();

            if (string.IsNullOrEmpty(search))
            {
                list = _context.MachineType.Where(x => x.LocationCode == location).ToList();
            }
            else
            {
                // simulate search
                foreach (MachineType dataItem in _context.MachineType.Where(x => x.LocationCode == location))
                {
                    if ((dataItem.MachineType1 != null && dataItem.MachineType1.Contains(search)) ||
                        (dataItem.Definition != null && dataItem.Definition.Contains(search)))
                    {
                        list.Add(dataItem);
                    }
                }
            }

            // simulate sort
            if (sortColumn == 0)
            {// sort Age
                list.Sort((x, y) => SortString(x.MachineType1.ToString(), y.MachineType1.ToString(), sortDirection));
            }
            else if (sortColumn == 2)
            {// sort Age
                list.Sort((x, y) => SortString(x.Definition.ToString(), y.Definition.ToString(), sortDirection));
            }

            recordFiltered = list.Count;

            // get just one page of data
            list = list.GetRange(start, Math.Min(length, list.Count - start));

            return list;
        }

        public List<MachinePropertyMetadata> FilterPropertyData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection, string location)
        {
            List<MachinePropertyMetadata> list = new List<MachinePropertyMetadata>();
            List<MachinePropertyMetadata> result = new List<MachinePropertyMetadata>();

            if (string.IsNullOrEmpty(search))
            {
                list = _context.MachinePropertyMetadata.Where(x => x.LocationCode == location).ToList();
            }
            else
            {
                // simulate search
                foreach (MachinePropertyMetadata dataItem in _context.MachinePropertyMetadata.Where(x => x.LocationCode == location))
                {
                    if ((dataItem.PropertyName != null && dataItem.PropertyName.Contains(search)) ||
                        (dataItem.DisplayName != null && dataItem.DisplayName.Contains(search)) ||
                        (dataItem.Datatype != null && dataItem.Datatype.Contains(search)) ||
                        (dataItem.Definition != null && dataItem.Definition.Contains(search)))
                    {
                        list.Add(dataItem);
                    }
                }
            }

            // simulate sort
            if (sortColumn == 0)
            {// sort Age
                list.Sort((x, y) => SortString(x.PropertyName.ToString(), y.PropertyName.ToString(), sortDirection));
            }
            else if (sortColumn == 2)
            {// sort Age
                list.Sort((x, y) => SortString(x.DisplayName.ToString(), y.DisplayName.ToString(), sortDirection));
            }
            if (sortColumn == 3)
            {// sort Age
                list.Sort((x, y) => SortString(x.Datatype.ToString(), y.Datatype.ToString(), sortDirection));
            }
            else if (sortColumn == 4)
            {// sort Age
                list.Sort((x, y) => SortString(x.Definition.ToString(), y.Definition.ToString(), sortDirection));
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
