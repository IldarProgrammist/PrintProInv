using MetroFramework.Controls;
using PrintPro.Models;
using System;
using System.Linq;

namespace PrintPro.WorkFolder
{
    public class WorkInTitul
    {

        private MetroGrid Dgv { get; set; }
        private int PrinterTitulID { get; set; }


        public WorkInTitul(MetroGrid dgv)
        {
            Dgv = dgv;
        }

        public void LoadTitul()
        {
            using (ContextModel db = new ContextModel())
            {

                var SelectFirmAll = from np in db.Titul
                                    select new
                                    {
                                        np.TitulID,
                                        np.TitulName
                                    };

                Dgv.DataSource = SelectFirmAll.ToList();
            }
        }

        public void createTitul(string metroLabel, string titulName)
        {
            PrinterTitulID = Convert.ToInt32(metroLabel);

            using (ContextModel db = new ContextModel())
            {

                if (PrinterTitulID == 0)
                {
                    Titul titul = new Titul
                    {
                        TitulName = titulName,
                    };
                    db.Titul.Add(titul);

                }
                else
                {
                    var mpToUpdate = db.Titul.SingleOrDefault(pm => pm.TitulID == PrinterTitulID);
                    if (mpToUpdate != null)
                    {
                        mpToUpdate.TitulName = titulName;
                    }
                }
                db.SaveChanges();
                LoadTitul();
            }
        }



        public void deleteTitul(string metroLabel)
        {
            PrinterTitulID = Convert.ToInt32(metroLabel);

            using (ContextModel db = new ContextModel())
            {
                Titul titul = db.Titul
                   .Where(p => p.TitulID == PrinterTitulID)
                   .FirstOrDefault();
                db.Titul.Remove(titul);
                db.SaveChanges();
            }
            LoadTitul();
        }

    }
}
