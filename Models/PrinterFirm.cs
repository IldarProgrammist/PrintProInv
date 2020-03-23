namespace PrintPro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrinterFirm")]
    public partial class PrinterFirm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrinterFirm()
        {
            PrinterModel = new HashSet<PrinterModel>();
        }

        public int PrinterFirmID { get; set; }

        [Required]
        [StringLength(20)]
        public string PrinterFirmName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrinterModel> PrinterModel { get; set; }
    }
}
