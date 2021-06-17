using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//TODO what model are we using using Wildcat.App.Models;
using Wildcat.Entities.SHCA.EngineeringData;
using Wildcat.Logic.Models;
using Wildcat.Logic.SHCA.Engineering.Grinders;
using Wildcat.Utilities;

namespace Wildcat.App.SHCA.ViewModels.Grinders
{
    #region - ViewModels

    public class SHCAGrindersIndexViewModel
    {
        public List<SelectListItem> GrindersSelect { get; set; }
        public List<ContactTimeDTO> DTO { get; set; }
        public SHCAGrindersIndexViewModel(IHttpContextAccessor _httpContextAccessor, IViewRenderService viewRenderService, EngineeringDataContext _engineeringContext, string selectedGrinder, DateTime fromdate, DateTime todate)
        {
            GrindersSelect = new List<SelectListItem>();
            GrindersSelect.Add(new SelectListItem { Text = "FGA", Value = "FGA", Selected = selectedGrinder == "FGA" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGQ", Value = "FGQ", Selected = selectedGrinder == "FGQ" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGQ_Motor", Value = "FGQMOTOR", Selected = selectedGrinder == "FGQMOTOR" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGX", Value = "FGX", Selected = selectedGrinder == "FGX" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGX_Motor", Value = "FGXMOTOR", Selected = selectedGrinder == "FGXMOTOR" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD1", Value = "FGD1", Selected = selectedGrinder == "FGD1" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD2", Value = "FGD2", Selected = selectedGrinder == "FGD2" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD3", Value = "FGD3", Selected = selectedGrinder == "FGD3" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD4", Value = "FGD4", Selected = selectedGrinder == "FGD4" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD5", Value = "FGD5", Selected = selectedGrinder == "FGD5" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD6", Value = "FGD6", Selected = selectedGrinder == "FGD6" ? true : false });

            DTO = new List<ContactTimeDTO>();
            //DTO = new GrindersData(_httpContextAccessor, _FGAContext, _FGQContext, _FGXContext, _FGDContext).GetDailyContactTimeByMachine(selectedGrinder);
        }
    }

    public class SHCAGrindersProductionViewModel
    {
        public List<SelectListItem> GrindersSelect { get; set; }

        public List<DataDTO> Shift1DTO { get; set; }
        public List<DataDTO> Shift2DTO { get; set; }
        public List<DataDTO> Shift3DTO { get; set; }
        public List<DataDTO> Shift4DTO { get; set; }

        public string Shift1Avg { get; set; }
        public string Shift1Total { get; set; }
        public string Shift2Avg { get; set; }
        public string Shift2Total { get; set; }
        public string Shift3Avg { get; set; }
        public string Shift3Total { get; set; }
        public string Shift4Avg { get; set; }
        public string Shift4Total { get; set; }

        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }
        public SHCAGrindersProductionViewModel(IHttpContextAccessor _httpContextAccessor, IViewRenderService viewRenderService, EngineeringDataContext _engineeringContext, string selectedGrinder, DateTime fromdate, DateTime todate)
        {
            GrindersSelect = new List<SelectListItem>();
            GrindersSelect.Add(new SelectListItem { Text = "FGA", Value = "FGA", Selected = selectedGrinder == "FGA" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGQ", Value = "FGQ", Selected = selectedGrinder == "FGQ" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGQ_Motor", Value = "FGQMOTOR", Selected = selectedGrinder == "FGQMOTOR" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGX", Value = "FGX", Selected = selectedGrinder == "FGX" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGX_Motor", Value = "FGXMOTOR", Selected = selectedGrinder == "FGXMOTOR" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD1", Value = "FGD1", Selected = selectedGrinder == "FGD1" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD2", Value = "FGD2", Selected = selectedGrinder == "FGD2" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD3", Value = "FGD3", Selected = selectedGrinder == "FGD3" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD4", Value = "FGD4", Selected = selectedGrinder == "FGD4" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD5", Value = "FGD5", Selected = selectedGrinder == "FGD5" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD6", Value = "FGD6", Selected = selectedGrinder == "FGD6" ? true : false });

            Shift1DTO = new List<DataDTO>();
            Shift2DTO = new List<DataDTO>();
            Shift3DTO = new List<DataDTO>();
            Shift4DTO = new List<DataDTO>();

            Fromdate = fromdate;
            Todate = todate;
            SHCA_GrinderDailyContact logic = new SHCA_GrinderDailyContact(_httpContextAccessor, viewRenderService, _engineeringContext);
            Shift1DTO = logic.GetDailyGrinderProductionTimeByMachine(selectedGrinder, (selectedGrinder + "_SHIFT1_DAILYTOTAL"), Fromdate, Todate);
            Shift2DTO = logic.GetDailyGrinderProductionTimeByMachine(selectedGrinder, (selectedGrinder + "_SHIFT2_DAILYTOTAL"), Fromdate, Todate);
            Shift3DTO = logic.GetDailyGrinderProductionTimeByMachine(selectedGrinder, (selectedGrinder + "_SHIFT3_DAILYTOTAL"), Fromdate, Todate);
            Shift4DTO = logic.GetDailyGrinderProductionTimeByMachine(selectedGrinder, (selectedGrinder + "_SHIFT4_DAILYTOTAL"), Fromdate, Todate);
        }
    }

    public class SHCAGrindersProductionChartsViewModel
    {
        public List<SelectListItem> GrindersSelect { get; set; }
        public List<ContactTimeDTO> DTO { get; set; }
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }

        public string[] ShiftData1Times { get; set; }
        public decimal[] ShiftData1Values { get; set; }
        public string[] ShiftData2Times { get; set; }
        public decimal[] ShiftData2Values { get; set; }
        public string[] ShiftData3Times { get; set; }
        public decimal[] ShiftData3Values { get; set; }
        public string[] ShiftData4Times { get; set; }
        public decimal[] ShiftData4Values { get; set; }

        private List<string> _ShiftData1Times { get; set; }
        private List<decimal> _ShiftData1Values { get; set; }
        private List<string> _ShiftData2Times { get; set; }
        private List<decimal> _ShiftData2Values { get; set; }
        private List<string> _ShiftData3Times { get; set; }
        private List<decimal> _ShiftData3Values { get; set; }
        private List<string> _ShiftData4Times { get; set; }
        private List<decimal> _ShiftData4Values { get; set; }

        public SHCAGrindersProductionChartsViewModel(IHttpContextAccessor _httpContextAccessor, IViewRenderService viewRenderService, EngineeringDataContext _engineeringContext, string selectedGrinder, DateTime fromdate, DateTime todate)
        {
            GrindersSelect = new List<SelectListItem>();
            GrindersSelect.Add(new SelectListItem { Text = "FGA", Value = "FGA", Selected = selectedGrinder == "FGA" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGQ", Value = "FGQ", Selected = selectedGrinder == "FGQ" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGQ_Motor", Value = "FGQMOTOR", Selected = selectedGrinder == "FGQMOTOR" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGX", Value = "FGX", Selected = selectedGrinder == "FGX" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGX_Motor", Value = "FGXMOTOR", Selected = selectedGrinder == "FGXMOTOR" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD1", Value = "FGD1", Selected = selectedGrinder == "FGD1" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD2", Value = "FGD2", Selected = selectedGrinder == "FGD2" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD3", Value = "FGD3", Selected = selectedGrinder == "FGD3" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD4", Value = "FGD4", Selected = selectedGrinder == "FGD4" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD5", Value = "FGD5", Selected = selectedGrinder == "FGD5" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD6", Value = "FGD6", Selected = selectedGrinder == "FGD6" ? true : false });

            Fromdate = fromdate;
            Todate = todate;

            List<DataDTO> Shift1DTO = new List<DataDTO>();
            List<DataDTO> Shift2DTO = new List<DataDTO>();
            List<DataDTO> Shift3DTO = new List<DataDTO>();
            List<DataDTO> Shift4DTO = new List<DataDTO>();

            _ShiftData1Times = new List<string>();
            _ShiftData1Values = new List<decimal>();
            _ShiftData2Times = new List<string>();
            _ShiftData2Values = new List<decimal>();
            _ShiftData3Times = new List<string>();
            _ShiftData3Values = new List<decimal>();
            _ShiftData4Times = new List<string>();
            _ShiftData4Values = new List<decimal>();

            SHCA_GrinderDailyContact logic = new SHCA_GrinderDailyContact(_httpContextAccessor, viewRenderService, _engineeringContext);
            Shift1DTO = logic.GetDailyGrinderProductionTimeByMachine(selectedGrinder, (selectedGrinder + "_SHIFT1_DAILYTOTAL"), Fromdate, Todate);
            Shift2DTO = logic.GetDailyGrinderProductionTimeByMachine(selectedGrinder, (selectedGrinder + "_SHIFT2_DAILYTOTAL"), Fromdate, Todate);
            Shift3DTO = logic.GetDailyGrinderProductionTimeByMachine(selectedGrinder, (selectedGrinder + "_SHIFT3_DAILYTOTAL"), Fromdate, Todate);
            Shift4DTO = logic.GetDailyGrinderProductionTimeByMachine(selectedGrinder, (selectedGrinder + "_SHIFT4_DAILYTOTAL"), Fromdate, Todate);

            //GrinderProdVM pvm = new GrinderProdVM(Shift1DTO, "table1", 1);
            foreach (var sd in Shift1DTO.OrderBy(x => x.Timestamp))
            {
                _ShiftData1Times.Add(sd.Timestamp.Value.ToShortDateString());
                _ShiftData1Values.Add(Convert.ToDecimal(sd.Value));
            }

            //pvm = new GrinderProdVM(Shift2DTO, "table2", 2);
            foreach (var sd in Shift2DTO.OrderBy(x => x.Timestamp))
            {
                _ShiftData2Times.Add(sd.Timestamp.Value.ToShortDateString());
                _ShiftData2Values.Add(Convert.ToDecimal(sd.Value));
            }

            //pvm = new GrinderProdVM(Shift3DTO, "table3", 3);
            foreach (var sd in Shift3DTO.OrderBy(x => x.Timestamp))
            {
                _ShiftData3Times.Add(sd.Timestamp.Value.ToShortDateString());
                _ShiftData3Values.Add(Convert.ToDecimal(sd.Value));
            }

            //pvm = new GrinderProdVM(Shift4DTO, "table4", 4);
            foreach (var sd in Shift4DTO.OrderBy(x => x.Timestamp))
            {
                _ShiftData4Times.Add(sd.Timestamp.Value.ToShortDateString());
                _ShiftData4Values.Add(Convert.ToDecimal(sd.Value));
            }

            ShiftData1Times = _ShiftData1Times.ToArray();
            ShiftData1Values = _ShiftData1Values.ToArray();

            ShiftData2Times = _ShiftData2Times.ToArray();
            ShiftData2Values = _ShiftData2Values.ToArray();

            ShiftData3Times = _ShiftData3Times.ToArray();
            ShiftData3Values = _ShiftData3Values.ToArray();

            ShiftData4Times = _ShiftData4Times.ToArray();
            ShiftData4Values = _ShiftData4Values.ToArray();
        }
    }

    public class SHCAGrindersContactTimeViewModel
    {
        public List<SelectListItem> GrindersSelect { get; set; }
        public List<ContactTimeDTO> DTO { get; set; }
        public SHCAGrindersContactTimeViewModel(IHttpContextAccessor _httpContextAccessor, IViewRenderService viewRenderService, EngineeringDataContext _engineeringContext, string selectedGrinder, DateTime fromdate, DateTime todate)
        {
            GrindersSelect = new List<SelectListItem>();
            GrindersSelect.Add(new SelectListItem { Text = "FGA", Value = "FGA", Selected = selectedGrinder == "FGA" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGQ", Value = "FGQ", Selected = selectedGrinder == "FGQ" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGQ_Motor", Value = "FGQMOTOR", Selected = selectedGrinder == "FGQMOTOR" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGX", Value = "FGX", Selected = selectedGrinder == "FGX" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGX_Motor", Value = "FGXMOTOR", Selected = selectedGrinder == "FGXMOTOR" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD1", Value = "FGD1", Selected = selectedGrinder == "FGD1" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD2", Value = "FGD2", Selected = selectedGrinder == "FGD2" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD3", Value = "FGD3", Selected = selectedGrinder == "FGD3" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD4", Value = "FGD4", Selected = selectedGrinder == "FGD4" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD5", Value = "FGD5", Selected = selectedGrinder == "FGD5" ? true : false });
            GrindersSelect.Add(new SelectListItem { Text = "FGD6", Value = "FGD6", Selected = selectedGrinder == "FGD6" ? true : false });

            DTO = new List<ContactTimeDTO>();
            //DTO = new GrindersData(_httpContextAccessor, _FGAContext, _FGQContext, _FGXContext, _FGDContext).GetDailyContactTimeByMachine(selectedGrinder);
        }
    }

    public class GrinderProdVM
    {
        public List<DataDTO> dto { get; set; }
        public string tableid { get; set; }
        public string avg { get; set; }
        public string total { get; set; }
        public string header { get; set; }
        public GrinderProdVM(List<DataDTO> _dto, string _tableid, int _table)
        {
            dto = _dto;
            tableid = _tableid;
            avg = (_dto.Count == 0) ? 0.ToString() : GetAverage(_dto);
            total = (_dto.Count == 0) ? 0.ToString() : GetTotal(_dto);
            header = "Shift " + _table.ToString() + " Production Data | Average = " + avg + " | Total = " + total;
        }

        private string GetTotal(List<DataDTO> dto)
        {
            decimal dataresult = 0;
            foreach (var d in dto)
            {
                dataresult = dataresult + Convert.ToDecimal(d.Value);
            }
            return Math.Round(dataresult, 2).ToString();
        }

        private string GetAverage(List<DataDTO> dto)
        {
            decimal dataresult = 0;
            foreach (var d in dto)
            {
                dataresult = dataresult + Convert.ToDecimal(d.Value);
            }
            var avg = dataresult / dto.Count;
            return Math.Round(avg, 2).ToString();
        }
    }

    #endregion - ViewModels

    #region - Models

    public class ContactTimeDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<ContactTimeDTO> data { get; set; }

        public ContactTimeDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<ContactTimeDTO>();
        }

    }

    #endregion - Models

    #region - Api

    public class GrinderProductionResponse : Response
    {
        GrinderProdVM pvm { get; set; }
        public Task<string> Table1 { get; set; }
        public Task<string> Table2 { get; set; }
        public Task<string> Table3 { get; set; }
        public Task<string> Table4 { get; set; }

        public GrinderProductionResponse(IHttpContextAccessor _httpContextAccessor, IViewRenderService viewRenderService, EngineeringDataContext _engineeringContext, string selectedGrinder, DateTime fromdate, DateTime todate)
        {
            IViewRenderService _viewRenderService = viewRenderService;
            try
            {
                SHCAGrindersProductionViewModel vm = new SHCAGrindersProductionViewModel(_httpContextAccessor, viewRenderService, _engineeringContext, selectedGrinder, fromdate, todate);

                //TODO necessary to do it this way?
                GrinderProdVM pvm = new GrinderProdVM(vm.Shift1DTO, "table1", 1); Table1 = _viewRenderService.RenderToStringAsync("ProdDataRefresh", pvm);

                pvm = new GrinderProdVM(vm.Shift2DTO, "table2", 2); Table2 = _viewRenderService.RenderToStringAsync("ProdDataRefresh", pvm);

                pvm = new GrinderProdVM(vm.Shift3DTO, "table3", 3); Table3 = _viewRenderService.RenderToStringAsync("ProdDataRefresh", pvm);

                pvm = new GrinderProdVM(vm.Shift4DTO, "table4", 4); Table4 = _viewRenderService.RenderToStringAsync("ProdDataRefresh", pvm);

                success = true;
                message = "data retrieved";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class GrinderProductionChartsResponse : Response
    {
        public SHCAGrindersProductionChartsViewModel vm { get; set; }
        public GrinderProductionChartsResponse(IHttpContextAccessor _httpContextAccessor, IViewRenderService viewRenderService, EngineeringDataContext _engineeringContext, string selectedGrinder, DateTime fromdate, DateTime todate)
        {
            try
            {
                vm = new SHCAGrindersProductionChartsViewModel(_httpContextAccessor, viewRenderService, _engineeringContext, selectedGrinder, fromdate, todate);
                success = true;
                message = "data retrieved";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class GrinderProductionDataTableData
    {
        public ContactTimeDataSet set;
        public GrinderProductionDataTableData(IHttpContextAccessor _httpContextAccessor, IViewRenderService viewRenderService, EngineeringDataContext context, int draw, int start, int length, string search, int sortColumn, string sortDirection, string table)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new ContactTimeDataSet();

            SHCA_GrinderDailyContact dcr = new SHCA_GrinderDailyContact(_httpContextAccessor, viewRenderService, context);

            set.draw = draw;
            set.data = dcr.FilterContactTimeData(ref recordsFiltered, start, length, search, sortColumn, sortDirection, table);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    public class GrinderContactTimeDataTableData
    {
        public ContactTimeDataSet set;
        public GrinderContactTimeDataTableData(IHttpContextAccessor _httpContextAccessor, IViewRenderService viewRenderService, EngineeringDataContext context, int draw, int start, int length, string search, int sortColumn, string sortDirection, string table)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new ContactTimeDataSet();

            SHCA_GrinderDailyContact dcr = new SHCA_GrinderDailyContact(_httpContextAccessor, viewRenderService, context);

            set.draw = draw;
            set.data = dcr.FilterContactTimeData(ref recordsFiltered, start, length, search, sortColumn, sortDirection, table);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    #endregion - Api
}
