namespace PrintPro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Printer")]
    public partial class Printer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Printer()
        {
            PrinterOperation = new HashSet<PrinterOperation>();
        }

        public int PrinterID { get; set; }

        [StringLength(20)]
        public string SerialNamber { get; set; }

        public int? CatrigeModelID { get; set; }

        public int? LocarionRoomID { get; set; }

        public virtual CatrigeModel CatrigeModel { get; set; }

        public virtual LocationRoom LocationRoom { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrinterOperation> PrinterOperation { get; set; }
    }
}
