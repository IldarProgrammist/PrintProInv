using PrintPro.WorkFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintPro.Forms
{
    public partial class PrinterOperationForm :MetroFramework.Forms.MetroForm
    {
        public PrinterOperationForm()
        {
            InitializeComponent();
        }

        private void PrinterOperation_Load(object sender, EventArgs e)
        {
           
            WorkInPrinterOperation workInPrinterOperation = new WorkInPrinterOperation();
            workInPrinterOperation.Load(StatusCB);
            workInPrinterOperation.Load(dgvPrinterOperation);
            workInPrinterOperation.LoadSearch(dgvPrinterSearch);
            Clear();
        }

        
        private void Clear()
        {
            labID.Text = "0";
            PrinterIDTB.Text = string.Empty;
        }

        private void dgvPrinterOperation_SelectionChanged(object sender, EventArgs e)
        {
            
            
            DataGridViewRow selectedRow = null;

            if (dgvPrinterOperation.SelectedRows.Count > 0)
            {
                selectedRow = dgvPrinterOperation.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
              //labID.Text = selectedRow.Cells["PrinterOperationID"].Value.ToString();
              PrinterIDTB.Text = selectedRow.Cells["PrinterID"].Value.ToString();
           // StatusCB.SelectedIndex = StatusCB.FindStringExact(selectedRow.Cells["PrinterStatus"].Value.ToString());
        
                
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            

            WorkInPrinterOperation workInPrinterOperation = new WorkInPrinterOperation();
            workInPrinterOperation.createPrinterOperation(labID, PrinterIDTB.Text, StatusCB);
            workInPrinterOperation.LoadSearch(dgvPrinterSearch);

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Clear();
        }


        private void dgvPrinterSearch_SelectionChanged(object sender, EventArgs e)
        {
           

        }

        private void searchTB_Click(object sender, EventArgs e)
        {

           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {


        }
    }
}
