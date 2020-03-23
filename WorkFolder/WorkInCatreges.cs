using MetroFramework.Controls;
using PrintPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintPro.WorkFolder
{
    public class WorkInCatreges
    {

        private int CatrigeID { get; set; }

        public void Load(MetroComboBox statusCB)
        {
            using (ContextModel db = new ContextModel())
            {
               
                statusCB.DataSource = db.PrinterStatus.ToList();
                statusCB.ValueMember = "PrinterStatusID";
                statusCB.DisplayMember = "PrinterName";
                statusCB.SelectedIndex = -1;
            }
        }



        public void Load(DataGridView dgv)
        {
           using (ContextModel db = new ContextModel())
            {
                var printerModel = from mp in db.Printer
                               select new
                               {   
                                   mp.PrinterID,
                                   mp.SerialNamber,
                                   mp.CatrigeModel.CatirgeModelName,
                                   mp.LocationRoom.Titul.TitulName,
                                   mp.LocationRoom.Room,                       
                               };

            
                dgv.DataSource = printerModel.ToList();
                
            }

        }


        public void Load(DataGridView dgv, MetroComboBox catrigeModelCB)
        {
            using (ContextModel db = new ContextModel())
            {
                catrigeModelCB.DataSource = db.CatrigeModel.ToList();
                catrigeModelCB.ValueMember = "CatrigeModelID";
                catrigeModelCB.DisplayMember = "CatirgeModelName";


                var catriges = from mp in db.Catrige
                               select new
                               {
                                   mp.CatrigeID,
                                   mp.SerialNamber,
                                   CatrigeModel = mp.CatrigeModel.CatirgeModelName
                                   };
                dgv.DataSource = catriges.ToList();
            }
        }

        public void createPrinterModel(MetroLabel LabID, MetroTextBox serialNumber, MetroComboBox catigeModelCB)
        {

            CatrigeID = Convert.ToInt32(LabID.Text);
            

            using (ContextModel db = new ContextModel())
            {
                if (CatrigeID == 0)
                {
                    Catrige catrige = new Catrige
                    {
                        SerialNamber = serialNumber.Text.Trim(),
                        CatrigeModelID = Convert.ToInt32(catigeModelCB.SelectedValue)
                    };
                    db.Catrige.Add(catrige);
                }
                else
                {
                    var mpToUpdate = db.Catrige.SingleOrDefault(pm => pm.CatrigeID == CatrigeID);
                    if (mpToUpdate != null)
                    {
                        mpToUpdate.SerialNamber = serialNumber.Text;
                        mpToUpdate.CatrigeModelID = Convert.ToInt32(catigeModelCB.SelectedValue);
                    }
                }
                db.SaveChanges();
            }
        }





        public void deleteCatrige(string metroLabel)
        {
            CatrigeID = Convert.ToInt32(metroLabel);

            using (ContextModel db = new ContextModel())
            {
                Catrige catrige = db.Catrige
                   .Where(p => p.CatrigeID == CatrigeID)
                   .FirstOrDefault();
                db.Catrige.Remove(catrige);
                db.SaveChanges();

            }
        }





    }
}
