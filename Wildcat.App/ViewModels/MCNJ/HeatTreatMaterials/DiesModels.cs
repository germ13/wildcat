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

    public class DiesViewModel
    {
        public List<Dies> Dies { get; set; }
        public Dies NewDie { get; set; }
        public Dies EditDie { get; set; }

        public DiesViewModel()
        {
            Dies = new List<Dies>();
            NewDie = new Dies();
            EditDie = new Dies();
        }
    }

    #endregion - ViewModels


    #region - Models

    public class AddDieResponse : Response
    {
        public AddDieResponse(HeatsSecuredContext context, IViewRenderService viewRenderService, string Die, string PartNum, string AuxDoc, string Revision, string PartDescription, string ProcessNo, string StdhtrNotes, string StdcertNotes, string requestor)
        {
            try
            {
                HeatTreatMaterials_DieClass dieClass = new HeatTreatMaterials_DieClass(context, viewRenderService);

                var result = dieClass.Add(Die, PartNum, AuxDoc, Revision, PartDescription, ProcessNo, StdhtrNotes, StdcertNotes, requestor);

                success = true;
                message = "Die: " + result.Die + " added.";
            }
            catch(Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditDieResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> FormTable { get; set; }

        public EditDieResponse(HeatsSecuredContext context, IViewRenderService viewRenderService, string Die, string PartNum, string AuxDoc, string Revision, string PartDescription, string ProcessNo, string StdhtrNotes, string StdcertNotes, string requestor)
        {
            _viewRenderService = viewRenderService;
            try
            {
                HeatTreatMaterials_DieClass dieClass = new HeatTreatMaterials_DieClass(context, viewRenderService);

                var result = dieClass.Edit(Die, PartNum, AuxDoc, Revision, PartDescription, ProcessNo, StdhtrNotes, StdcertNotes, requestor);

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

    public class SelectEditDieResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public Dies EditDie { get; set; }
        public SelectEditDieResponse(string ID, IViewRenderService viewRenderService)
        {
            _viewRenderService = viewRenderService;
            try
            {
                using (var context = new HeatsSecuredContext())
                {
                    EditDie = context.Dies.Where(x => x.Die == ID).FirstOrDefault();
                }

                if(EditDie == null)
                {
                    success = false;
                    message = "Could not find requested die, please contact administrator.";
                }
                else
                {
                    Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatMaterials/Dies/EditDiePartial", EditDie);
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

    public class DataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<Wildcat.Entities.MCNJ.HeatsSecured.Dies> data { get; set; }

        public DataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<Dies>();
        }

    }

    public class DataTableData
    {
        public DataSet set;
        public DataTableData(HeatsSecuredContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new DataSet();

            HeatTreatMaterials_DieClass dieClass = new HeatTreatMaterials_DieClass(context, viewRenderService);

            set.draw = draw;
            set.data = dieClass.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    #endregion - Models
}
