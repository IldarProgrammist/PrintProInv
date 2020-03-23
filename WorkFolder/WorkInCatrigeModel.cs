using MetroFramework.Controls;
using PrintPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintPro.Classes
{
    public class WorkInCatrigeModel
    {
        private int CatrigeModelID { get; set; }

        public void Load(DataGridView dgv, MetroComboBox catrigeColorCB, MetroComboBox printerModelCB)
        {
            using (ContextModel db = new ContextModel())
            {
                catrigeColorCB.DataSource = db.CatrigeColor.ToList();
                catrigeColorCB.ValueMember = "CatrigeColorID";
                catrigeColorCB.DisplayMember = "ColorName";

                printerModelCB.DataSource = db.PrinterModel.ToList();
                printerModelCB.ValueMember = "PrinterModelID";
                printerModelCB.DisplayMember = "PrinterModelName";


                var catrigeModel = from mp in db.CatrigeModel
                                   select new
                                   {
                                       mp.CatrigeModelID,
                                       mp.CatirgeModelName,
                                       CatrigeColor = mp.CatrigeColor.ColorName,
                                       
                                   };
                dgv.DataSource = catrigeModel.ToList();

            }
        }

        

        public void createPrinterModel(MetroLabel catrogeModelIDLab, MetroTextBox modelName, MetroComboBox catrigeColor)
        {
            using (ContextModel db = new ContextModel())
            {
                if (CatrigeModelID == 0)
                {
                    CatrigeModel catrigeModel = new CatrigeModel
                    {                      
                        CatirgeModelName = modelName.Text.Trim(),
                        ColorID = Convert.ToInt32(catrigeColor.SelectedValue)
                    };
                    db.CatrigeModel.Add(catrigeModel);
                }
                else
                {
                    var mpToUpdate = db.CatrigeModel.SingleOrDefault(pm => pm.CatrigeModelID == CatrigeModelID);
                    if (mpToUpdate != null)
                    {
                        mpToUpdate.CatirgeModelName = modelName.Text;
                        mpToUpdate.ColorID = Convert.ToInt32(catrigeColor.SelectedValue);
                    }
                }
                db.SaveChanges();
            }
        }

        public void deleteFirm(string metroLabel)
        {
            CatrigeModelID = Convert.ToInt32(metroLabel);

            using (ContextModel db = new ContextModel())
            {
                CatrigeModel catrigeModel = db.CatrigeModel
                   .Where(p => p.CatrigeModelID == CatrigeModelID)
                   .FirstOrDefault();
                db.CatrigeModel.Remove(catrigeModel);
                db.SaveChanges();
            }
        }

    }
}
