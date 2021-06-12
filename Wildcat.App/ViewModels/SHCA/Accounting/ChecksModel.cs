using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.SHCA.ShultzPro;
using Wildcat.Logic.SHCA.Accounting;
using Wildcat.Utilities;

namespace Wildcat.App.ViewModels.SHCA.Accounting
{
    #region - ViewModels

    public class ChecksIndexViewModel
    {
        public List<SelectListItem> CheckRunSelect { get; set; }

        public ChecksIndexViewModel(IHttpContextAccessor _httpContextAccessor, IViewRenderService viewRenderService, ShultzProContext shultzProContext, string selectedCheckRun)
        {
            CheckRunSelect = new List<SelectListItem>();
            //CheckRunSelect.Add(new SelectListItem("SELECT_DATE", "SELECT_DATE"));

            //var checkdates = shultzProContext.CheckRunDates.FromSql("EXECUTE spCheckRunDates").ToList().OrderByDescending(x => x.TransactionDate);

            //foreach (var checkdate in checkdates)
            //{
            //    var shortdate = Convert.ToDateTime(checkdate.TransactionDate).ToShortDateString();
            //    var dt = CheckRunSelect.Where(x => x.Value == shortdate).FirstOrDefault();
            //    if (dt == null)
            //    {
            //        CheckRunSelect.Add(new SelectListItem(shortdate, shortdate));
            //    }
            //}

            CheckRunSelect.FirstOrDefault().Selected = true;
        }
    }

    #endregion - ViewModels



    #region - Models

    public class CheckRunsDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<TPcc004> data { get; set; }

        public CheckRunsDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<TPcc004>();
        }

    }

    #endregion - Models



    #region - Api

    public class CheckRunsDataTableData
    {
        public CheckRunsDataSet set;
        public CheckRunsDataTableData(IHttpContextAccessor _httpContextAccessor, IViewRenderService viewRenderService, ShultzProContext context, int draw, int start, int length, string search, int sortColumn, string sortDirection, DateTime from, DateTime to, string checktype)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new CheckRunsDataSet();

            CheckRun dcr = new CheckRun(_httpContextAccessor, viewRenderService, context);

            set.draw = draw;
            set.data = dcr.GetCheckRunData(ref recordsFiltered, start, length, search, sortColumn, sortDirection, from, to, checktype);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }


    #endregion - Api
}
