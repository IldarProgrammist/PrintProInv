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
    public  class WorkInPrinterModel
    {        

        private int PrinterModelID { get; set; } 

        //Все модели принтеров
        public void Load(DataGridView dgv,MetroComboBox printerFrimcb)
        {
            using (ContextModel db = new ContextModel())
            {
                printerFrimcb.DataSource = db.PrinterFirm.ToList();
                printerFrimcb.DisplayMember = "PrinterFirmName";
                printerFrimcb.ValueMember = "PrinterFirmID";


                var printerModel = from mp in db.PrinterModel
                                   select new
                                   {   mp.PrinterModelID,
                                       mp.PrinterModelName,
                                       PrinterFirm = mp.PrinterFirm.PrinterFirmName
                                   };
               dgv.DataSource = printerModel.ToList();

            }
        }



        public void createPrinterModel(MetroLabel printerModelIDLab, MetroTextBox modelName, MetroComboBox printerFirm)
        {

            PrinterModelID = Convert.ToInt32(printerModelIDLab.Text);

            using(ContextModel db = new ContextModel())
            {
                if (PrinterModelID == 0)
                {
                    PrinterModel printerModels = new PrinterModel
                    {
                        PrinterModelName = modelName.Text.Trim(),
                        PrinterFirmID = Convert.ToInt32(printerFirm.SelectedValue)
                    };
                    db.PrinterModel.Add(printerModels);
                }
                else
                {
                  var mpToUpdate=db.PrinterModel.SingleOrDefault(pm => pm.PrinterModelID == PrinterModelID);
                   if(mpToUpdate !=null)
                    {
                        mpToUpdate.PrinterModelName = modelName.Text;
                        mpToUpdate.PrinterFirmID = Convert.ToInt32(printerFirm.SelectedValue);
                    }
                }
                db.SaveChanges();
            }   
        }


        public void deleteFirm(string metroLabel)
        {
            PrinterModelID = Convert.ToInt32(metroLabel);

            using (ContextModel db = new ContextModel())
            {
                PrinterModel printerModel = db.PrinterModel
                   .Where(p => p.PrinterModelID == PrinterModelID)
                   .FirstOrDefault();
                db.PrinterModel.Remove(printerModel);
                db.SaveChanges();
               
            }
        }

    }
}
