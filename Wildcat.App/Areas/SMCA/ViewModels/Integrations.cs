using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wildcat.App.Models;
using Wildcat.Entities.PCC.PCC03Integration;
using Wildcat.Logic.PCC.PCC03.Integrations;
using Wildcat.Utilities;
using static Wildcat.Logic.PCC.PCC03.Integrations.Requests;

namespace Wildcat.App.ViewModels.PCC03.Integrations
{

    #region - ViewModels

    //TODO renamespace
    public class RequestsViewModel
    {
        private PCC03_IntegrationContext _context;
        private IViewRenderService _viewRenderService;
        private IHttpContextAccessor _httpContextAccessor;

        public List<SelectListItem> IntPoints { get; set; }

        public RequestsViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, PCC03_IntegrationContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _context = context;

            IntPoints = new List<SelectListItem>();

            IntPoints.Add(new SelectListItem { Text = "Item - 002", Value = "2", Selected = true });
            IntPoints.Add(new SelectListItem { Text = "Router - 004", Value = "4", Selected = true });
            IntPoints.Add(new SelectListItem { Text = "Job - 005", Value = "5", Selected = true });
            IntPoints.Add(new SelectListItem { Text = "Job Update - 006", Value = "6", Selected = true });
            IntPoints.Add(new SelectListItem { Text = "Move Transactions - 008", Value = "8", Selected = true });
            IntPoints.Add(new SelectListItem { Text = "Completions - 010", Value = "10", Selected = true });
        }
    }

    public class JobsMasterViewModel
    {
        private PCC03_IntegrationContext _context;
        private IViewRenderService _viewRenderService;
        private IHttpContextAccessor _httpContextAccessor;

        public MasterTable job { get; set; }

        public JobsMasterViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, PCC03_IntegrationContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _context = context;

            job = new MasterTable();
        }
    }

    public class JobNoteViewModel
    {
        private PCC03_IntegrationContext _context;
        private IViewRenderService _viewRenderService;
        private IHttpContextAccessor _httpContextAccessor;

        public MasterTable master { get; set; }

        public JobNoteViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, PCC03_IntegrationContext context, Guid ID)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _context = context;

            master = _context.MasterTable.Where(x => x.Id == ID).FirstOrDefault();
        }
    }

    public class JsonObjectViewModel
    {
        private PCC03_IntegrationContext _context;
        private IViewRenderService _viewRenderService;
        private IHttpContextAccessor _httpContextAccessor;

        public string json { get; set; }

        public JsonObjectViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, PCC03_IntegrationContext context, string Table, Guid ID)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _context = context;

            Requests dcr = new Requests(context, viewRenderService);
            json = dcr.GetJsonObject(Table, ID);

            //json = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
        }
    }

    public class ResponseObjectViewModel
    {
        private PCC03_IntegrationContext _context;
        private IViewRenderService _viewRenderService;
        private IHttpContextAccessor _httpContextAccessor;

        public string json { get; set; }

        public ResponseObjectViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, PCC03_IntegrationContext context, string Table, Guid ID)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _context = context;

            Requests dcr = new Requests(context, viewRenderService);
            json = dcr.GetResponseObject(Table, ID);
        }
    }

    public class ExceptionObjectViewModel
    {
        private PCC03_IntegrationContext _context;
        private IViewRenderService _viewRenderService;
        private IHttpContextAccessor _httpContextAccessor;

        public string json { get; set; }

        public ExceptionObjectViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, PCC03_IntegrationContext context, string Table, Guid ID)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _context = context;

            Requests dcr = new Requests(context, viewRenderService);
            json = dcr.GetExceptionObject(Table, ID);
        }
    }


    #endregion - ViewModels



    #region - Models

    public class _RequestsDTO
    {
        public Guid Id { get; set; }
        public Guid? OracleId { get; set; }
        public Guid? Pcc03Id { get; set; }
        public string Json { get; set; }
        public string Status { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
    }

    public class RequestsDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<RequestsDTO> data { get; set; }

        public RequestsDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<RequestsDTO>();
        }

    }

    public class JobsMasterDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<MasterTable> data { get; set; }

        public JobsMasterDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<MasterTable>();
        }

    }

    #endregion - Models


    #region - Api

    public class EditJobMasterNoteResponse : Response
    {
        public MasterTable master { get; set; }
        public EditJobMasterNoteResponse(PCC03_IntegrationContext context, IViewRenderService viewRenderService, Guid ID, string note, string requestor)
        {
            try
            {
                master = new MasterTable();
                Requests diesClass = new Requests(context, viewRenderService);

                master = diesClass.EditJobMasterNote(ID, note, requestor);

                success = true;
                message = "Note edited for Job Master ID: " + master.Id + ".";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class ReleaseRequestResponse : Response
    {
        public ReleaseRequestResponse(PCC03_IntegrationContext context, IViewRenderService viewRenderService, Guid Id, string Table, string requestor)
        {
            try
            {
                Requests diesClass = new Requests(context, viewRenderService);

                diesClass.ReleaseJob(Id, Table, requestor);

                success = true;
                message = "Job ID: " + Id + " released for Int: " + Table;
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class SelectJsonRequestResponse : Response
    {
        public Task<string> Form { get; set; }
    }

    public class SelectExceptionRequestResponse : Response
    {
        public Task<string> Form { get; set; }
    }

    public class RequestsDataTableData
    {
        public RequestsDataSet set;
        public RequestsDataTableData(PCC03_IntegrationContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection, string table)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new RequestsDataSet();

            Requests dcr = new Requests(context, viewRenderService);

            set.draw = draw;
            set.data = dcr.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection, table);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    public class MasterJobsDataTableData
    {
        public JobsMasterDataSet set;
        public MasterJobsDataTableData(PCC03_IntegrationContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new JobsMasterDataSet();

            Requests dcr = new Requests(context, viewRenderService);

            set.draw = draw;
            set.data = dcr.MasterJobsFilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    #endregion - Api
}
