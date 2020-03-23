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

namespace PrintPro.Forms
{
    public partial class CatrigeModelForm : MetroFramework.Forms.MetroForm
    {
        public CatrigeModelForm()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            LabID.Text = "";
            CatrigeModelNameTB.Text = string.Empty;
            ColorCB.SelectedIndex = -1;
            PrinterModelCB.SelectedIndex = -1;
        }

        private void CatrigeModelForm_Load(object sender, EventArgs e)
        {
            
            WorkInCatrigeModel workInCatrigeModel = new WorkInCatrigeModel();
            workInCatrigeModel.Load(dgvModelCatrige, ColorCB, PrinterModelCB);
            ColorCB.SelectedIndex = -1;
            PrinterModelCB.SelectedIndex = -1;
            Clear();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            WorkInCatrigeModel catrigeModel = new WorkInCatrigeModel();
            catrigeModel.createPrinterModel(LabID, CatrigeModelNameTB, ColorCB);
            catrigeModel.Load(dgvModelCatrige, ColorCB, PrinterModelCB);
            Clear();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            WorkInCatrigeModel catrigeModel = new WorkInCatrigeModel();
            catrigeModel.deleteFirm(LabID.Text);
            catrigeModel.Load(dgvModelCatrige, ColorCB, PrinterModelCB);
        }

        private void dgvModelCatrige_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (dgvModelCatrige.SelectedRows.Count > 0)
            {
                selectedRow = dgvModelCatrige.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
            LabID.Text = selectedRow.Cells["CatrigeModelID"].Value.ToString();
            CatrigeModelNameTB.Text = selectedRow.Cells["CatirgeModelName"].Value.ToString();
            ColorCB.SelectedIndex =ColorCB.FindStringExact(selectedRow.Cells["CatrigeColor"].Value.ToString());
        
        }


    }
}
