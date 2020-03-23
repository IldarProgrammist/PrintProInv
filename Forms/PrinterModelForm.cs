using PrintPro.Classes;
using PrintPro.Models;
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
    public partial class PrinterModelForm : MetroFramework.Forms.MetroForm
    {
        public PrinterModelForm()
        {
            InitializeComponent();
        }

       private void Clear()
        {
            PrinterModelIDLab.Text = "0";
            PrinterModelNameTB.Text = string.Empty;
            PrinterFirmNameCB.SelectedIndex = -1;
        }

        private void PrinterModel_Load(object sender, EventArgs e)
        {
            WorkInPrinterModel printerModel = new WorkInPrinterModel();
            printerModel.Load(dgvPrinterModelList, PrinterFirmNameCB);
            Clear();
            
        }


        private void dgvPrinterModelList_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (dgvPrinterModelList.SelectedRows.Count > 0)
            {
                selectedRow = dgvPrinterModelList.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
            PrinterModelIDLab.Text = selectedRow.Cells["PrinterModelID"].Value.ToString();
            PrinterModelNameTB.Text = selectedRow.Cells["PrinterModelName"].Value.ToString();
            PrinterFirmNameCB.SelectedIndex = PrinterFirmNameCB.FindStringExact(selectedRow.Cells["PrinterFirm"].Value.ToString());
            
        }



        private void saveBtn_Click(object sender, EventArgs e)
        {

            WorkInPrinterModel printerModel = new WorkInPrinterModel();
            printerModel.createPrinterModel(PrinterModelIDLab,PrinterModelNameTB,PrinterFirmNameCB);
            printerModel.Load(dgvPrinterModelList, PrinterFirmNameCB);
            Clear();   
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            WorkInPrinterModel printerModel = new WorkInPrinterModel();
            printerModel.deleteFirm(PrinterModelIDLab.Text);
            printerModel.Load(dgvPrinterModelList, PrinterFirmNameCB);

        }
    }
}
