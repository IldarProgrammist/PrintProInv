namespace PrintPro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrinterOperation")]
    public partial class PrinterOperation
    {
        public int PrinterOperationID { get; set; }

        public int? PrinterID { get; set; }

        public int? PrinterStatudID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OperationData { get; set; }

        public virtual Printer Printer { get; set; }

        public virtual PrinterStatus PrinterStatus { get; set; }
    }
}
