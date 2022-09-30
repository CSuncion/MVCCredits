using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace CreditsView.Reports
{
    public partial class frmGenerarDecomicro : Form
    {
        Application objApp;
        _Workbook objBook;
        public frmGenerarDecomicro()
        {
            InitializeComponent();
        }

        public void GenerarDecomicro()
        {
            Workbooks objBooks;
            Sheets objSheets;
            _Worksheet objSheet;
            Range range;

            try
            {
                // Instantiate Excel and start a new workbook.
                objApp = new Application();
                objBooks = objApp.Workbooks;
                objBook = objBooks.Add(Missing.Value);
                objSheets = objBook.Worksheets;
                objSheet = (_Worksheet)objSheets.get_Item(1);

                //Get the range where the starting cell has the address
                //m_sStartingCell and its dimensions are m_iNumRows x m_iNumCols.
                range = objSheet.get_Range("A1", Missing.Value);
                range = range.get_Resize(5, 5);

                //Create an array.
                string[,] saRet = new string[5, 5];

                //Fill the array.
                for (long iRow = 0; iRow < 5; iRow++)
                {
                    for (long iCol = 0; iCol < 5; iCol++)
                    {
                        //Put the row and column address in the cell.
                        saRet[iRow, iCol] = iRow.ToString() + "|" + iCol.ToString();
                    }
                }

                //Set the range value to the array.
                range.set_Value(Missing.Value, saRet);


                //Return control of Excel to the user.
                objApp.Visible = true;
                objApp.UserControl = true;
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }
        }
        private void btnGenDeco_Click(object sender, EventArgs e)
        {

        }

    }
}
