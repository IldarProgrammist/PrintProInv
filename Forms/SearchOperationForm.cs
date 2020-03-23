using PrintPro.WorkFolder;
using System;
using System.Windows.Forms;

namespace PrintPro.Forms
{
    public partial class SearchOperationForm : MetroFramework.Forms.MetroForm
    {
        public SearchOperationForm()
        {
            InitializeComponent();
        }

        private void PrinterOperationForm_Load(object sender, EventArgs e)
        {
            WorkInCatreges workInCatrige = new WorkInCatreges();
            workInCatrige.Load(dgvCatrige);
 
        }

        private void dgvCatrige_SelectionChanged(object sender, EventArgs e)
        {
            
                 
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
