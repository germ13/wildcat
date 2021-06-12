using Aspose.Cells;
using System.Collections.Generic;

namespace Wildcat.Logic.Administration.Users
{
    public class ImportUsers
    {
        #region Public Methods

        public void ImportUsersResult(string address)
        {
            //Open your template file.
            Workbook wb = new Workbook(address);
            //Get the first worksheet.
            Worksheet worksheet = wb.Worksheets[0];
            //Get the cells collection.
            Cells cells = worksheet.Cells;

            //Define the list.
            List<string> myList = new List<string>();
            //Get the AA column index. (Since "Status" is always @ AA column.
            int colA = CellsHelper.ColumnNameToIndex("A");
            int colB = CellsHelper.ColumnNameToIndex("B");
            int colC = CellsHelper.ColumnNameToIndex("C");

            //Get the last row index in AA column.
            int last_row = worksheet.Cells.GetLastDataRow(colA);

            //Loop through the "Status" column while start collecting values from row 9
            //to save each value to List
            for (int i = 0; i <= last_row; i++)
            {
                myList.Add(cells[i, colA].Value.ToString());
            }
        }

        #endregion Public Methods
    }
}