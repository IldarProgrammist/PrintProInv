using MetroFramework.Controls;
using PrintPro.Models;
using System;
using System.Linq;

namespace PrintPro.WorkFolder
{
    public class WorkInPrinterOperation
    {
        public void Load(MetroComboBox statusCB)
        {
            using (ContextModel db = new ContextModel())
            {

                statusCB.DataSource = db.PrinterStatus.ToList();
                statusCB.DisplayMember = "PrinterName";
                statusCB.ValueMember = "PrinterStatusID";
                statusCB.SelectedIndex = -1;
            }
        }

        public void Load(MetroGrid dgv)
        {
            using (ContextModel db = new ContextModel())
            {
                var printer = from mp in db.Printer
                              select new
                              {
                                  mp.PrinterID,
                                  mp.SerialNamber,
             
                                  mp.LocationRoom.Room,
                                  mp.LocationRoom.Titul.TitulName

                              };
                dgv.DataSource = printer.ToList();

            }


        }

        public void LoadSearch(MetroGrid dgv)
        {

            using (ContextModel db = new ContextModel())
            {
                var printer = from mp in db.PrinterOperation
                              select new
                              {  
                                 // mp.PrinterOperationID,
                                  mp.PrinterID,
                                  mp.PrinterStatus.PrinterName,
                                  mp.OperationData,
                                  
                              };
                dgv.DataSource = printer.ToList();

            }

        }




        private int PrinterOperationID { get; set; }

        public void createPrinterOperation(MetroLabel IDLab, string printerID, MetroComboBox printerStatus)
        {

            PrinterOperationID = Convert.ToInt32(IDLab.Text);
           
            using (ContextModel db = new ContextModel())
            {

                if (PrinterOperationID == 0)
                {

                    PrinterOperation printer = new PrinterOperation
                    {  
                        PrinterID = Int32.Parse(printerID),
                        PrinterStatudID = Convert.ToInt32(printerStatus.SelectedValue),
                        OperationData = DateTime.Now
                    };
                    db.PrinterOperation.Add(printer);
                }

                
                else
                {
                    var mpToUpdate = db.PrinterOperation.SingleOrDefault(pm => pm.PrinterOperationID == PrinterOperationID);
                    if (mpToUpdate != null)
                    {   
                        mpToUpdate.PrinterStatudID = Convert.ToInt32(printerStatus.SelectedValue);
                        mpToUpdate.OperationData = Convert.ToDateTime(DateTime.Now);
                    }
                }
                

                db.SaveChanges();

            }

        }


            public void searchPrinterIsSerialNamber(MetroTextBox sn, MetroGrid dgv)
            {
            using (ContextModel db = new ContextModel())
            {
                var search = db.Printer.Where(p => p.SerialNamber == sn.Text);

                dgv.DataSource = search.ToList();
            }



        }


    }

}

