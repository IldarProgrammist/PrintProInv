
using MetroFramework;
using MetroFramework.Controls;
using PrintPro.Models;
using System;
using System.Linq;

namespace PrintPro.Classes
{
    public class WorkInPrinterFirm
    {
        private MetroGrid Dgv { get; set; }
        private int PrinterFirmID { get; set; }


        public WorkInPrinterFirm(MetroGrid dgv)
        {
            Dgv = dgv;
        }

        public void LoadFirm()
        {
            using (ContextModel db = new ContextModel())
            {

                var SelectFirmAll = from np in db.PrinterFirm
                                    select new
                                    { np.PrinterFirmID,
                                        np.PrinterFirmName
                                    };

                Dgv.DataSource = SelectFirmAll.ToList();
            }
        }

        public void createPrinterFirm(string metroLabel, string firmName)
        {
            PrinterFirmID = Convert.ToInt32(metroLabel);

            using (ContextModel db = new ContextModel())
            {

                if (PrinterFirmID == 0)
                {
                    PrinterFirm printerFirm = new PrinterFirm
                    {
                        PrinterFirmName = firmName,
                    };
                    db.PrinterFirm.Add(printerFirm);
                   
                }
                else
                {
                    var mpToUpdate = db.PrinterFirm.SingleOrDefault(pm => pm.PrinterFirmID == PrinterFirmID);
                    if (mpToUpdate != null)
                    {
                        mpToUpdate.PrinterFirmName = firmName;
                    }
                }
                db.SaveChanges();

                LoadFirm();

            }
        }

        public void deleteFirm(string metroLabel)
        {
            PrinterFirmID = Convert.ToInt32(metroLabel);

            using(ContextModel db = new ContextModel())
            {
                PrinterFirm printerFirm = db.PrinterFirm
                   .Where(p => p.PrinterFirmID == PrinterFirmID)
                   .FirstOrDefault();
                db.PrinterFirm.Remove(printerFirm);
                db.SaveChanges();
            }
        }
    }    
}

