using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wildcat.App.Models;
using Wildcat.Entities.MCNJ.SecureHeatCards;
using Wildcat.Logic.MCNJ.HeatsSecured;
using Wildcat.Utilities;

namespace Wildcat.App.ViewModels.MCNJ.HeatCards
{
    #region - ViewModels

    public class DiesViewModel
    {
        private SecureHeatCardsContext _context;
        private IViewRenderService _viewRenderService;

        public List<Dies> Dies { get; set; }
        public List<SelectListItem> Customers { get; set; }
        public List<SelectListItem> Materials { get; set; }
        public Dies AddDie { get; set; }
        public Dies EditDie { get; set; }
        public DiesViewModel(SecureHeatCardsContext context, IViewRenderService viewRenderService)
        {
            Dies = new List<Dies>();
            Customers = new List<SelectListItem>();
            Materials = new List<SelectListItem>();
            AddDie = new Dies();
            EditDie = new Dies();

            _context = context;
            _viewRenderService = viewRenderService;

            foreach (var c in _context.Customer)
            {
                Customers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(c.Name, c.CustId.ToString()));
            }

            foreach (var c in _context.RawMaterial)
            {
                Materials.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(c.MaterialField, c.MaterialField));
            }
        }
    }

    public class AddDiesViewModel
    {
        public Dies Die { get; set; }
        public string Customer { get; set; }
        public TblHeatCard AddHeat { get; set; }
        public TblHeatCard EditHeat { get; set; }
        public List<TblHeatCard> HeatCards { get; set; }

        public AddDiesViewModel(SecureHeatCardsContext _context)
        {
            Die = new Dies();
            AddHeat = new TblHeatCard(); AddHeat.DieNumber = Die.Die;
            EditHeat = new TblHeatCard();
            HeatCards = new List<TblHeatCard>();
        }
    }
    public class EditDiesViewModel
    {
        public Dies Die { get; set; }
        public string Customer { get; set; }
        public TblHeatCard AddHeat { get; set; }
        public TblHeatCard EditHeat { get; set; }
        public List<TblHeatCard> HeatCards { get; set; }
        public List<SelectListItem> Materials { get; set; }

        public EditDiesViewModel(SecureHeatCardsContext _context, string ID)
        {
            Die = _context.Dies.Where(x => x.Die == ID).FirstOrDefault();
            AddHeat = new TblHeatCard(); AddHeat.DieNumber = Die.Die;
            EditHeat = new TblHeatCard();
            HeatCards = _context.TblHeatCard.Where(x => x.DieNumber == Die.Die).ToList();

            Customer = Die.CustId == null ? "" : _context.Customer.Where(x => x.CustId == Die.CustId).FirstOrDefault().Name;
        }
    }

    public class EditHeatCardViewModel
    {
        public TblHeatCard EditHeatCard { get; set; }
        public EditHeatCardViewModel(SecureHeatCardsContext _context, string ID)
        {
            var id = Convert.ToInt32(ID);
            EditHeatCard = _context.TblHeatCard.Where(x => x.Hcn == id).FirstOrDefault();
        }
    }

    #endregion - ViewModels


    #region - Models

    public class AddDiesResponse : Response
    {
        public Dies Die { get; set; }
        public AddDiesResponse(SecureHeatCardsContext context, IViewRenderService viewRenderService, string Die, string CustomerPart, int? CustId, string PartType, string Material, byte[] Picture, string requestor)
        {
            try
            {
                HeatsSecured_DiesClass diesClass = new HeatsSecured_DiesClass(context, viewRenderService);

                var result = diesClass.AddDies(Die, CustomerPart, CustId, PartType, Material, Picture, requestor);

                success = true;
                message = "Die: " + result.Die + " added.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditDiesResponse : Response
    {
        public EditDiesResponse(SecureHeatCardsContext context, IViewRenderService viewRenderService, string Die, string CustomerPart, int? CustId, string PartType, string Material, byte[] Picture, string requestor)
        {
            try
            {
                HeatsSecured_DiesClass diesClass = new HeatsSecured_DiesClass(context, viewRenderService);

                var result = diesClass.EditDies(Die, CustomerPart, CustId, PartType, Material, Picture, requestor);

                success = true;
                message = "Die: " + result.Die + " edited.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    //public class SelectEditDiesResponse : Response
    //{
    //    private IViewRenderService _viewRenderService;
    //    public Task<string> Form { get; set; }
    //    public SelectEditDiesResponse(string ID, SecureHeatCardsContext _context, IViewRenderService viewRenderService)
    //    {
    //        _viewRenderService = viewRenderService;
    //        try
    //        {
    //            EditDiesViewModel vm = new EditDiesViewModel(_context, ID);
    //            if (vm.EditDie == null)
    //            {
    //                success = false;
    //                message = "Could not find requested Heat Card, please contact administrator.";
    //            }
    //            else
    //            {
    //                Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/Batch/EditBatchPartial", vm);
    //                success = true;
    //                message = "";
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            success = false;
    //            message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
    //            exception = e;
    //        }
    //    }
    //}

    public class AddHeatCardResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public AddHeatCardResponse(SecureHeatCardsContext context, IViewRenderService viewRenderService, int Hcn, string DieNumber, DateTime? Date, string NucPrefix, string HeatCode, string HeatNumber, string ShopOrderNumber, short? QuantityOrderedCut, string Range, string Notes, string requestor)
        {
            _viewRenderService = viewRenderService;
            try
            {
                HeatsSecured_DiesClass diesClass = new HeatsSecured_DiesClass(context, viewRenderService);

                var result = diesClass.AddTblHeatCard(Hcn, DieNumber, Date, NucPrefix, HeatCode, HeatNumber, ShopOrderNumber, QuantityOrderedCut, Range, Notes, requestor);

                var cards = context.TblHeatCard.Where(x => x.DieNumber == DieNumber).ToList();
                Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatCards/DieCard/HeatCardsPartial", cards);
                success = true;
                message = "HEAT CARD added.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditHeatCardResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public EditHeatCardResponse(SecureHeatCardsContext context, IViewRenderService viewRenderService, int Hcn, string DieNumber, DateTime? Date, string NucPrefix, string HeatCode, string HeatNumber, string ShopOrderNumber, short? QuantityOrderedCut, string Range, string Notes, string requestor)
        {
            _viewRenderService = viewRenderService;
            try
            {
                HeatsSecured_DiesClass diesClass = new HeatsSecured_DiesClass(context, viewRenderService);

                var result = diesClass.EditTblHeatCard(Hcn, DieNumber, Date, NucPrefix, HeatCode, HeatNumber, ShopOrderNumber, QuantityOrderedCut, Range, Notes, requestor);

                var cards = context.TblHeatCard.Where(x => x.DieNumber == DieNumber).ToList();
                Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatCards/DieCard/HeatCardsPartial", cards);
                success = true;
                message = "HEAT CARD edited.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class SelectEditHeatCardsResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public TblHeatCard EditHeat { get; set; }
        public SelectEditHeatCardsResponse(string ID, SecureHeatCardsContext _context, IViewRenderService viewRenderService)
        {
            _viewRenderService = viewRenderService;
            try
            {
                EditHeatCardViewModel vm = new EditHeatCardViewModel(_context, ID);
                if (vm.EditHeatCard == null)
                {
                    success = false;
                    message = "Could not find requested Heat Card, please contact administrator.";
                }
                else
                {
                    Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatCards/DieCard/EditHeatCardPartial", vm.EditHeatCard);
                    success = true;
                    message = "";
                    EditHeat = vm.EditHeatCard;
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

    public class DiesDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<Dies> data { get; set; }

        public DiesDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<Dies>();
        }

    }

    public class DiesDataTableData
    {
        public DiesDataSet set;
        public DiesDataTableData(SecureHeatCardsContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new DiesDataSet();

            HeatsSecured_DiesClass diesClass = new HeatsSecured_DiesClass(context, viewRenderService);

            set.draw = draw;
            set.data = diesClass.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    #endregion - Models
}
