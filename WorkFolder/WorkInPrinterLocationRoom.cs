using MetroFramework.Controls;
using PrintPro.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PrintPro.WorkFolder
{
    public class WorkInPrinterLocationRoom
    {
        private int LocationID { get; set; }

        
        public void Load(DataGridView dgv, MetroComboBox TitulCB)
        {
            using (ContextModel db = new ContextModel())
            {
                TitulCB.DataSource = db.Titul.ToList();
                TitulCB.DisplayMember = "TitulName";
                TitulCB.ValueMember = "TitulID";


                var location = from mp in db.LocationRoom
                                   select new
                                   {
                                       mp.LocationID,
                                       mp.Room,
                                       Titul = mp.Titul.TitulName
                                   };
                dgv.DataSource = location.ToList();

            }
        }



        public void createPrinterModel(MetroLabel printerModelIDLab, MetroTextBox room, MetroComboBox titul)
        {

            LocationID = Convert.ToInt32(printerModelIDLab.Text);

            using (ContextModel db = new ContextModel())
            {
                if (LocationID == 0)
                {
                    LocationRoom location = new LocationRoom
                    {
                        Room = room.Text.Trim(),
                        TitulID = Convert.ToInt32(titul.SelectedValue)
                    };
                    db.LocationRoom.Add(location);
                }
                else
                {
                    var mpToUpdate = db.LocationRoom.SingleOrDefault(pm => pm.LocationID == LocationID);
                    if (mpToUpdate != null)
                    {
                        mpToUpdate.Room = room.Text;
                        mpToUpdate.TitulID = Convert.ToInt32(titul.SelectedValue);
                    }
                }
                db.SaveChanges();
            }   
        }


        public void deleteLocation(string metroLabel)
        {
            LocationID = Convert.ToInt32(metroLabel);

            using (ContextModel db = new ContextModel())
            {
                LocationRoom location = db.LocationRoom
                   .Where(p => p.LocationID == LocationID)
                   .FirstOrDefault();
                db.LocationRoom.Remove(location);
                db.SaveChanges();

            }
        }






    }
}
