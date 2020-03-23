/*
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
    public  class WorkInPrinter
    {
        public int PrinterID { get; set; }
        private  MetroGrid Dgv;


        public WorkInPrinter(MetroGrid dgv)
        {
            Dgv = dgv;
        }


        public void LoadPrinter()
        {
            using (ContextModel db = new ContextModel())
            {
                var SelectPrinerAll = from p in db.Printer
                                    select new
                                    {
                                        p.PrinterID,
                                        p.SerialNumber,
                                        p.PrinterLocation.Titul,
                                        p.PrinterStatus.PrinterStatusName                                        
                                    };

                Dgv.DataSource = SelectPrinerAll.ToList();
            }
        }

        public void createPrinter()
        {


        }
    }
}
*/