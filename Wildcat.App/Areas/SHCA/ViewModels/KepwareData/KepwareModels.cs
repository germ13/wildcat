using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.SHCA.EngineeringData;
using Wildcat.Logic.SHCA.Engineering.Kepware;
using Wildcat.Utilities;

namespace Wildcat.App.ViewModels.SHCA.KepwareData
{
    #region - ViewModels

    public class IndexViewModel
    {
        private EngineeringDataContext _context;
        private IViewRenderService _viewRenderService;
        private IHttpContextAccessor _httpContextAccessor;

        public List<SelectListItem> Machines { get; set; }
        public List<SelectListItem> Properties { get; set; }

        public List<SelectListItem> Tags { get; set; }
        public List<KepwareDataDTO> data { get; set; }

        public IndexViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, EngineeringDataContext context)
        {
            //_httpContextAccessor = httpContextAccessor;
            //_viewRenderService = viewRenderService;
            //_context = context;

            ////Machines = new List<SelectListItem>();
            //Tags = new List<SelectListItem>();
            //data = new List<KepwareDataDTO>();

            //foreach (var i in _context.KepwareTag)
            //{
            //    Tags.Add(new SelectListItem(i.KepwareTagId.ToString(), (string.IsNullOrEmpty(i.KepwareTagDisplay) ? i.KepwareProperty : i.KepwareTagDisplay)));
            //}

            //foreach (var i in _context.TblUnit)
            //{
            //    Units.Add(new SelectListItem(i.Sphammer, i.Sphammer));
            //}

            //foreach (var i in _context.TblEngineeringNames)
            //{
            //    Approvals.Add(new SelectListItem(i.Names, i.Names));
            //}

            //DCR = new List<TblDcr>();
            //AddDCR = new TblDcr { RequestedBy = _httpContextAccessor.HttpContext.User.Identity.Name, RequestedDate = DateTime.UtcNow.Date };
            //EditDCR = new TblDcr();
        }
    }

    public class MachineViewModel
    {
        private EngineeringDataContext _context;
        private IViewRenderService _viewRenderService;
        private IHttpContextAccessor _httpContextAccessor;

        public KepwareMachine AddMachine { get; set; }
        public KepwareMachine EditMachine { get; set; }
        public KepwareMachineValue AddMachineValue { get; set; }
        public KepwareMachineValue EditMachineValue { get; set; }
        public KepwareMachineProperty AddMachineProperty { get; set; }
        public KepwareMachineProperty EditMachineProperty { get; set; }

        public List<SelectListItem> MachineProperties { get; set; }
        public List<SelectListItem> DataTypes { get; set; }

        public MachineViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, EngineeringDataContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _context = context;

            MachineProperties = new List<SelectListItem>();
            foreach (var p in context.KepwareMachineProperty)
            {
                MachineProperties.Add(new SelectListItem(p.MachinePropertyId, p.MachinePropertyId));
            }

            DataTypes = new List<SelectListItem>();
            foreach (var t in (TypeCode[])Enum.GetValues(typeof(TypeCode)))
            {
                DataTypes.Add(new SelectListItem(t.ToString(), t.ToString()));
            }

            AddMachine = EditMachine = new KepwareMachine();
            AddMachineValue = EditMachineValue = new KepwareMachineValue();
            AddMachineProperty = EditMachineProperty = new KepwareMachineProperty();
        }
    }

    public class KepwareTagViewModel
    {
        private EngineeringDataContext _context;
        private IViewRenderService _viewRenderService;
        private IHttpContextAccessor _httpContextAccessor;

        public KepwareTag AddTag { get; set; }
        public KepwareTag EditTag { get; set; }
        public KepwareMetaValue AddTagValue { get; set; }
        public KepwareMetaValue EditTagValue { get; set; }
        public KepwareMetaProperty AddTagProperty { get; set; }
        public KepwareMetaProperty EditTagProperty { get; set; }

        public List<SelectListItem> TagProperties { get; set; }
        public List<SelectListItem> DataTypes { get; set; }

        public KepwareTagViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, EngineeringDataContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _context = context;

            TagProperties = new List<SelectListItem>();
            foreach (var p in context.KepwareMetaProperty)
            {
                TagProperties.Add(new SelectListItem(p.MetaPropertyId, p.MetaPropertyId));
            }

            DataTypes = new List<SelectListItem>();
            foreach (var t in (TypeCode[])Enum.GetValues(typeof(TypeCode)))
            {
                DataTypes.Add(new SelectListItem(t.ToString(), t.ToString()));
            }

            AddTag = EditTag = new KepwareTag();
            AddTagValue = EditTagValue = new KepwareMetaValue();
            AddTagProperty = EditTagProperty = new KepwareMetaProperty();
        }
    }

    #endregion - ViewModels



    #region - Models

    public class KepwareDataDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NumericId { get; set; }
        public string Value { get; set; }
        public string TimeStamp { get; set; }
        public string Quality { get; set; }
    }

    public class ReportTypes
    {
        public int Value { get; set; }
        public string Text { get; set; }
        public ReportTypes(int _value, string _Text)
        {
            Value = _value;
            Text = _Text;
        }
    }

    //public class AddResponse : Response
    //{
    //    public TblDcr Dcr { get; set; }
    //    public AddResponse(EngineeringDataContext context, IViewRenderService viewRenderService, int Dcrnumber, string ToolNumber, string Unit, string EngApproval, string EngApprovalSignature, DateTime? EngApprovalDate, string DateRequired, string HoldProductionYesOrNo, string ToolsChangedYesOrNo, string DieShopSignature, DateTime? DieShopSignatureDate, string Reason, string Description, string RequestedBy, DateTime? RequestedDate)
    //    {
    //        try
    //        {
    //            MCNJ_DCR logic = new MCNJ_DCR(context, viewRenderService);

    //            var result = logic.AddDcr(Dcrnumber, ToolNumber, Unit, EngApproval, EngApprovalSignature, EngApprovalDate, DateRequired, HoldProductionYesOrNo, ToolsChangedYesOrNo, DieShopSignature, DieShopSignatureDate, Reason, Description, RequestedBy, RequestedDate);

    //            success = true;
    //            message = "DCR: " + result.Dcrnumber + " added.";
    //        }
    //        catch (Exception e)
    //        {
    //            success = false;
    //            message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
    //            exception = e;
    //        }
    //    }
    //}

    //public class EditResponse : Response
    //{
    //    public EditResponse(EngineeringDataContext context, IViewRenderService viewRenderService, int Dcrnumber, string ToolNumber, string Unit, string EngApproval, string EngApprovalSignature, DateTime? EngApprovalDate, string DateRequired, string HoldProductionYesOrNo, string ToolsChangedYesOrNo, string DieShopSignature, DateTime? DieShopSignatureDate, string Reason, string Description, string RequestedBy, DateTime? RequestedDate)
    //    {
    //        try
    //        {
    //            MCNJ_DCR logic = new MCNJ_DCR(context, viewRenderService);

    //            var result = logic.EditDcr(Dcrnumber, ToolNumber, Unit, EngApproval, EngApprovalSignature, EngApprovalDate, DateRequired, HoldProductionYesOrNo, ToolsChangedYesOrNo, DieShopSignature, DieShopSignatureDate, Reason, Description, RequestedBy, RequestedDate);

    //            success = true;
    //            message = "DCR: " + result.Dcrnumber + " edited.";
    //        }
    //        catch (Exception e)
    //        {
    //            success = false;
    //            message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
    //            exception = e;
    //        }
    //    }
    //}

    public class KepwareMachineDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<KepwareMachine> data { get; set; }

        public KepwareMachineDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<KepwareMachine>();
        }
    }

    public class KepwareTagDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<KepwareTag> data { get; set; }

        public KepwareTagDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<KepwareTag>();
        }
    }

    #endregion - Models



    #region - Api

    //public class SelectEditRequestResponse : Response
    //{
    //    public Task<string> Form { get; set; }
    //}

    public class KepwareMachineDataTableData
    {
        public KepwareMachineDataSet set;
        public KepwareMachineDataTableData(EngineeringDataContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new KepwareMachineDataSet();

            KepwareMachineLogic dcr = new KepwareMachineLogic(context, viewRenderService);

            set.draw = draw;
            set.data = dcr.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    public class KepwareTagDataTableData
    {
        public KepwareTagDataSet set;
        public KepwareTagDataTableData(EngineeringDataContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new KepwareTagDataSet();

            KepwareTagLogic dcr = new KepwareTagLogic(context, viewRenderService);

            set.draw = draw;
            set.data = dcr.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    #endregion - Api
}
