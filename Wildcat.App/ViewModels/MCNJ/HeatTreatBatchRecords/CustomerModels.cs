using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wildcat.App.Models;
using Wildcat.Entities.MCNJ.SecureHeatTreatBatchBook;
using Wildcat.Logic.MCNJ.HeatTreatBatchRecords;
using Wildcat.Utilities;

namespace Wildcat.App.ViewModels.MCNJ.HeatTreatBatchRecords
{
    #region - ViewModels

    public class CustomerViewModel
    {
        public List<TblCustomer> Customers { get; set; }
        public TblCustomer AddCustomer { get; set; }
        public TblCustomer EditCustomer { get; set; }
        public CustomerViewModel()
        {
            Customers = new List<TblCustomer>();
            AddCustomer = new TblCustomer();
            EditCustomer = new TblCustomer();
        }
    }

    public class AddCustomerViewModel
    {
        private SecureHeatTreatBatchBookContext _context;
        private IViewRenderService _viewRenderService;

        public TblCustomer Customer { get; set; }


        public AddCustomerViewModel(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService)
        {
            _context = context;
            _viewRenderService = viewRenderService;

            Customer = new TblCustomer();
        }
    }

    public class EditCustomerViewModel
    {
        private SecureHeatTreatBatchBookContext _context;
        private IViewRenderService _viewRenderService;

        public TblCustomer Customer { get; set; }

        public EditCustomerViewModel(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, int CustId)
        {
            _context = context;
            _viewRenderService = viewRenderService;
            Customer = new TblCustomer();
            Customer = _context.TblCustomer.Where(x => x.CustId == CustId).FirstOrDefault();
        }
    }


    #endregion - ViewModels

    #region - Models

    public class AddCustomerResponse : Response
    {
        public AddCustomerResponse(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, int CustID, string Name, string requestor)
        {
            try
            {
                HeatTreatBatchRecords_CustomerClass customerClass = new HeatTreatBatchRecords_CustomerClass(context, viewRenderService);

                var result = customerClass.Add(CustID, Name, requestor);

                success = true;
                message = "Customer: " + result.CustId + " added.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditCustomerResponse : Response
    {
        public EditCustomerResponse(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, int CustID, string Name, string requestor)
        {
            try
            {
                HeatTreatBatchRecords_CustomerClass customerClass = new HeatTreatBatchRecords_CustomerClass(context, viewRenderService);

                var result = customerClass.Edit(CustID, Name, requestor);

                success = true;
                message = "Customer: " + result.CustId + " edited.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class SelectEditCustomerResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public SelectEditCustomerResponse(int CustId, SecureHeatTreatBatchBookContext _context, IViewRenderService viewRenderService)
        {
            _viewRenderService = viewRenderService;
            try
            {
                EditCustomerViewModel vm = new EditCustomerViewModel(_context, _viewRenderService, CustId);
                if (vm.Customer == null)
                {
                    success = false;
                    message = "Could not find requested batch, please contact administrator.";
                }
                else
                {
                    Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/Customer/EditCustomerPartial", vm);
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

    public class CustomerDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<TblCustomer> data { get; set; }

        public CustomerDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<TblCustomer>();
        }

    }

    public class CustomerDataTableData
    {
        public CustomerDataSet set;
        public CustomerDataTableData(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new CustomerDataSet();

            HeatTreatBatchRecords_CustomerClass customerClass = new HeatTreatBatchRecords_CustomerClass(context, viewRenderService);

            set.draw = draw;
            set.data = customerClass.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    #endregion - Models
}
