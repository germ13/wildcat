using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wildcat.App.Models;
using Wildcat.Entities.MCNJ.HeatsSecured;
using Wildcat.Logic.MCNJ.HeatTreatMaterials;
using Wildcat.Utilities;

namespace Wildcat.App.ViewModels.MCNJ.HeatTreatMaterials
{
    #region - ViewModels

    public class MillCertModel
    {
        public List<CertsMill> MillCerts { get; set; }
        public MillCertModel()
        {
            MillCerts = new List<CertsMill>();
        }
    }

    public class AddMillCertViewModel
    {
        public CertsMill CertsMill { get; set; }
        public List<HeatReceipts> HeatReceipts { get; set; }
        public HeatReceipts HeatReceipt { get; set; }
        public HeatReceipts EditHeatReceipts { get; set; }
        public string Vendor { get; set; }
        public string AddVendorHeat { get; set; }
        public int AddVendorId { get; set; }
        public string EditVendorHeat { get; set; }
        public int EditVendorId { get; set; }
        public AddMillCertViewModel(HeatsSecuredContext context)
        {
            CertsMill = new CertsMill(); CertsMill.MillId = 0;
            HeatReceipts = new List<HeatReceipts>();
            HeatReceipt = new HeatReceipts();
            EditHeatReceipts = new HeatReceipts();

            var ven = context.Vendors.Where(x => x.MillId == CertsMill.MillId).FirstOrDefault();
            Vendor = ven.Name;
        }
    }

    public class EditMillCertViewModel
    {
        public CertsMill CertsMill { get; set; }
        public List<HeatReceipts> HeatReceipts { get; set; }
        public HeatReceipts HeatReceipt { get; set; }
        public HeatReceipts EditHeatReceipts { get; set; }
        public string Vendor { get; set; }
        public string AddVendorHeat { get; set; }
        public int AddVendorId { get; set; }
        public string EditVendorHeat { get; set; }
        public int EditVendorId { get; set; }
        public EditMillCertViewModel(HeatsSecuredContext context, int id)
        {
            CertsMill = context.CertsMill.Where(x => x.Crn == id).FirstOrDefault();
            HeatReceipts = new List<HeatReceipts>();
            HeatReceipts = context.HeatReceipts.Where(x => x.Crn == id).ToList();
            HeatReceipt = new HeatReceipts(); HeatReceipt.Crn = id;
            EditHeatReceipts = new HeatReceipts();

            var ven = context.Vendors.Where(x => x.MillId == CertsMill.MillId).FirstOrDefault();
            Vendor = ven.Name;
        }
    }

    public class EditMillCertHeatViewModel
    {
        public HeatReceipts HeatReceipt { get; set; }

        public string EditVendorHeat { get; set; }
        public int EditVendorId { get; set; }

        public HeatReceipts EditHeatReceipts { get; set; }
        public EditMillCertHeatViewModel(HeatsSecuredContext context, IViewRenderService viewRenderService, int id)
        {
            EditHeatReceipts = context.HeatReceipts.Where(x => x.Hrn == id).FirstOrDefault();
            EditVendorId = Convert.ToInt32(EditHeatReceipts.VendorId);
            EditVendorHeat = context.Vendors.Where(x => x.MillId == EditVendorId).FirstOrDefault().Name;
        }
    }

    #endregion - ViewModels


    #region - Models

    public class SelectEditMillCertHeatResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public EditMillCertHeatViewModel vm { get; set; }
        public SelectEditMillCertHeatResponse(HeatsSecuredContext context, IViewRenderService viewRenderService, string ID)
        {
            _viewRenderService = viewRenderService;
            try
            {
                var id = Convert.ToInt32(ID);
                vm = new EditMillCertHeatViewModel(context, viewRenderService, id);

                //Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatMaterials/MillCert/EditHeatPartial", vm);
                vm.EditVendorId = vm.EditHeatReceipts.VendorId == null ? 0 : Convert.ToInt32(vm.EditHeatReceipts.VendorId);
                vm.EditVendorHeat = vm.EditVendorId == 0 ? "" : context.Vendors.Where(x => x.MillId == vm.EditVendorId).FirstOrDefault().Name;

                success = true;
            }
            catch (Exception e)
            {
                success = false;
                message = "Batch edit failed. " + e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class AddMillCertResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public string Crn { get; set; }
        public AddMillCertResponse(HeatsSecuredContext context, IViewRenderService viewRenderService, int _Crn, DateTime? DateIn, int? MillId, string MillCn, string Heat, string HtDesc, string Material, string Spec, string Pwcode, string BetaTransus, string requestor)
        {
            _viewRenderService = viewRenderService;
            try
            {
                var operation = HeatTreatMaterials_MillCertClass.Add(context, viewRenderService, _Crn, DateIn, MillId, MillCn, Heat, HtDesc, Material, Spec, Pwcode, BetaTransus, requestor);

                Crn = operation.Crn.ToString();
                success = true;
                message = "Mill cert added successfully.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditMillCertResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public EditMillCertResponse(HeatsSecuredContext context, IViewRenderService viewRenderService, int Crn, DateTime? DateIn, int? MillId, string MillCn, string Heat, string HtDesc, string Material, string Spec, string Pwcode, string BetaTransus, string requestor)
        {
            _viewRenderService = viewRenderService;
            try
            {
                var operation = HeatTreatMaterials_MillCertClass.Edit(context, viewRenderService, Crn, DateIn, MillId, MillCn, Heat, HtDesc, Material, Spec, Pwcode, BetaTransus, requestor);

                Crn = operation.Crn;
                success = true;
                message = "Mill cert edited successfully.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class AddMillCertOpResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public int? Crn { get; set; }
        public AddMillCertOpResponse(HeatsSecuredContext context, IViewRenderService viewRenderService, int? _Crn, int Hrn, DateTime? Date, string Size, string McWPo, short? VendorId, int? TotWt, short? Billets, string BilletId, bool Bsr, bool CutBillets, string Remarks, string requestor)
        {
            _viewRenderService = viewRenderService;
            try
            {
                HeatReceipts operation = HeatTreatMaterials_MillCertClass.AddOp(context, viewRenderService, _Crn, Hrn, Date, Size, McWPo, VendorId, TotWt, Billets, BilletId, Bsr, CutBillets, Remarks, requestor);

                Crn = operation.Crn;

                var vm = context.HeatReceipts.Where(x => x.Crn == Crn).ToList();
                Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatMaterials/MillCert/HeatOperationsPartial", vm);

                success = true;
                message = "Heat record added successfully.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditMillCertOpResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public int? Crn { get; set; }
        public EditMillCertOpResponse(HeatsSecuredContext context, IViewRenderService viewRenderService, int? _Crn, int Hrn, DateTime? Date, string Size, string McWPo, short? VendorId, int? TotWt, short? Billets, string BilletId, bool Bsr, bool CutBillets, string Remarks, string requestor)
        {
            _viewRenderService = viewRenderService;
            try
            {
                var operation = HeatTreatMaterials_MillCertClass.EditOp(context, viewRenderService, _Crn, Hrn, Date, Size, McWPo, VendorId, TotWt, Billets, BilletId, Bsr, CutBillets, Remarks, requestor);

                Crn = operation.Crn;

                var vm = context.HeatReceipts.Where(x => x.Crn == Crn).ToList();
                Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatMaterials/MillCert/HeatOperationsPartial", vm);

                success = true;
                message = "Heat record edited successfully.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class CertsMillDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<CertsMill> data { get; set; }

        public CertsMillDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<CertsMill>();
        }
    }

    public class CertsMillDataTableData
    {
        public CertsMillDataSet set;
        public CertsMillDataTableData(HeatsSecuredContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new CertsMillDataSet();

            HeatTreatMaterials_MillCertClass dieClass = new HeatTreatMaterials_MillCertClass(context, viewRenderService);

            set.draw = draw;
            set.data = dieClass.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    #endregion - Models
}
