using PrintPro.Classes;
using PrintPro.WorkFolder;
using System;
using System.Windows.Forms;

namespace PrintPro.Forms
{
    public partial class TitulForm :MetroFramework.Forms.MetroForm
    {
        public TitulForm()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            LabID.Text = "0";
            TitulTB.Text = string.Empty;
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            WorkInTitul workInTitul = new WorkInTitul(dgvTitul);
            workInTitul.createTitul(LabID.Text, TitulTB.Text);
            Clear();
        }

        private void PrinterLocationForm_Load(object sender, EventArgs e)
        {
            WorkInTitul workInTitul = new WorkInTitul(dgvTitul);
            workInTitul.LoadTitul();
        }

        private void dgvTitul_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (dgvTitul.SelectedRows.Count > 0)
            {
                selectedRow = dgvTitul.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
            LabID.Text =    selectedRow.Cells["TitulID"].Value.ToString();
            TitulCB.Text = selectedRow.Cells["TitulName"].Value.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            WorkInTitul workInTitul = new WorkInTitul(dgvTitul);
            workInTitul.deleteTitul(LabID.Text);
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
