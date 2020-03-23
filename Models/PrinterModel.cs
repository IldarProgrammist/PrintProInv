namespace PrintPro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrinterModel")]
    public partial class PrinterModel
    {
        public int PrinterModelID { get; set; }

        [Required]
        [StringLength(20)]
        public string PrinterModelName { get; set; }

        public int PrinterFirmID { get; set; }

        public virtual PrinterFirm PrinterFirm { get; set; }
    }
}
