using PrintPro.WorkFolder;
using System;
using System.Windows.Forms;

namespace PrintPro.Forms
{
    public partial class LocationForm : MetroFramework.Forms.MetroForm
    {
        public LocationForm()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            LabID.Text = "0";
            RooTB.Text = string.Empty;
            TitulCB.SelectedIndex = -1;
        }


        private void LocationForm_Load(object sender, EventArgs e)
        {
        
            WorkInPrinterLocationRoom workInPrinterLocationRoom = new WorkInPrinterLocationRoom();
            workInPrinterLocationRoom.Load(dgvLocation, TitulCB);
            Clear();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            WorkInPrinterLocationRoom workInPrinterLocation = new WorkInPrinterLocationRoom();
            workInPrinterLocation.createPrinterModel(LabID, RooTB, TitulCB);
            workInPrinterLocation.Load(dgvLocation, TitulCB);
            Clear();
        }

        private void dgvLocation_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (dgvLocation.SelectedRows.Count > 0)
            {
                selectedRow = dgvLocation.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
            LabID.Text = selectedRow.Cells["LocationID"].Value.ToString();
            RooTB.Text = selectedRow.Cells["Room"].Value.ToString();
            TitulCB.SelectedIndex = TitulCB.FindStringExact(selectedRow.Cells["Titul"].Value.ToString());
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            WorkInPrinterLocationRoom workInPrinterLocationRoom = new WorkInPrinterLocationRoom();
            workInPrinterLocationRoom.deleteLocation(LabID.Text);
            workInPrinterLocationRoom.Load(dgvLocation, TitulCB);
        }
    }
}
