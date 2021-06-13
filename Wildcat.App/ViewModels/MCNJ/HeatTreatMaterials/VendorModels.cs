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

    public class VendorModel
    {
        public List<Vendors> Vendors { get; set; }
        public Vendors AddVendor { get; set; }
        public Vendors EditVendor { get; set; }

        public VendorModel()
        {
            Vendors = new List<Entities.MCNJ.HeatsSecured.Vendors>();
            AddVendor = new Vendors(); EditVendor = new Vendors();
        }
    }

    public class EditVendorModel
    {
        public Vendors EditVendor { get; set; }
        public EditVendorModel(HeatsSecuredContext _context, string ID)
        {
            var id = Convert.ToInt32(ID);
            EditVendor = _context.Vendors.Where(x => x.MillId == id).FirstOrDefault();
        }
    }

    #endregion - ViewModels


    #region - Models

    public class SelectEditVendorResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }

        public SelectEditVendorResponse(HeatsSecuredContext _context, IViewRenderService viewRenderService, string ID)
        {
            _viewRenderService = viewRenderService;
            try
            {
                EditVendorModel vm = new EditVendorModel(_context, ID);
                if (vm.EditVendor == null)
                {
                    success = false;
                    message = "Could not find requested vendor, please contact administrator.";
                }
                else
                {
                    Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatMaterials/Vendor/EditVendorPartial", vm);

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

    public class AddVendorResponse : Response
    {
        public AddVendorResponse(HeatsSecuredContext context, IViewRenderService viewRenderService, string Name, string Address, string City, string State, string ZipCode, string Country, string Contact, bool Print, string requestor)
        {
            try
            {
                var result = HeatTreatMaterials_Vendor.Add(context, viewRenderService, Name, Address, City, State, ZipCode, Country, Contact, Print, requestor);

                success = true;
                message = "vendor added successful.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditVendorResponse : Response
    {
        public EditVendorResponse(HeatsSecuredContext context, IViewRenderService viewRenderService, int MillId, string Name, string Address, string City, string State, string ZipCode, string Country, string Contact, bool Print, string requestor)
        {
            try
            {
                var result = HeatTreatMaterials_Vendor.Edit(context, viewRenderService, MillId, Name, Address, City, State, ZipCode, Country, Contact, Print, requestor);

                success = true;
                message = "vendor edited successful.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class VendorDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<Wildcat.Entities.MCNJ.HeatsSecured.Vendors> data { get; set; }

        public VendorDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<Vendors>();
        }

    }

    public class VendorDataTableData
    {
        public VendorDataSet set;
        public VendorDataTableData(HeatsSecuredContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new VendorDataSet();

            HeatTreatMaterials_Vendor dieClass = new HeatTreatMaterials_Vendor(context, viewRenderService);

            set.draw = draw;
            set.data = dieClass.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    #endregion - Models
}
