using PrintPro.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintPro
{
    public partial class PrinterFirmForm : MetroFramework.Forms.MetroForm
    {
        public PrinterFirmForm()
        {
            InitializeComponent();
        }


        public void Clear()
        {
            PrinterFirmIDLab.Text = "0";
            PrinterFirmNameTB.Text = string.Empty;
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            WorkInPrinterFirm printerFirm = new WorkInPrinterFirm(dgvPrinterFirmList);
            printerFirm.createPrinterFirm(PrinterFirmIDLab.Text, PrinterFirmNameTB.Text);
            printerFirm.LoadFirm();
            Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WorkInPrinterFirm printerFirm = new WorkInPrinterFirm(dgvPrinterFirmList);
            printerFirm.LoadFirm();
            Clear();
        }

        private void dgvPrinterFirmList_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (dgvPrinterFirmList.SelectedRows.Count > 0)
            {
                selectedRow = dgvPrinterFirmList.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
            PrinterFirmIDLab.Text = selectedRow.Cells["PrinterFirmID"].Value.ToString();
            PrinterFirmNameTB.Text = selectedRow.Cells["PrinterFirmName"].Value.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            WorkInPrinterFirm workInPrinterFirm = new WorkInPrinterFirm(dgvPrinterFirmList);
            workInPrinterFirm.deleteFirm(PrinterFirmIDLab.Text);
            workInPrinterFirm.LoadFirm();
            Clear();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
