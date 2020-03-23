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
    public partial class CatrigeForm : MetroFramework.Forms.MetroForm
    {
        public CatrigeForm()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            LabID.Text = "0";
            SerialNumberTB.Text = string.Empty;
            CatrigeModelCB.SelectedIndex = -1;
        }

        private void Catrige_Load(object sender, EventArgs e)
        {
            WorkInCatreges workInCatreges = new WorkInCatreges();
            workInCatreges.Load(dgvCatriges, CatrigeModelCB);
            Clear();
        }

        private void dgvCatriges_SelectionChanged(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = null;

            if (dgvCatriges.SelectedRows.Count > 0)
            {
                selectedRow = dgvCatriges.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
            LabID.Text = selectedRow.Cells["CatrigeID"].Value.ToString();
            SerialNumberTB.Text = selectedRow.Cells["SerialNamber"].Value.ToString();
            CatrigeModelCB.SelectedIndex = CatrigeModelCB.FindStringExact(selectedRow.Cells["CatrigeModel"].Value.ToString());


        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            WorkInCatreges workInCatreges = new WorkInCatreges();
            workInCatreges.createPrinterModel(LabID, SerialNumberTB,CatrigeModelCB);
            workInCatreges.Load(dgvCatriges, CatrigeModelCB);
            Clear();
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            WorkInCatreges workInCatreges = new WorkInCatreges();
            workInCatreges.deleteCatrige(LabID.Text);
            workInCatreges.Load(dgvCatriges, CatrigeModelCB);
            Clear();
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
