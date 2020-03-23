namespace PrintPro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CatrigeModel")]
    public partial class CatrigeModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatrigeModel()
        {
            Catrige = new HashSet<Catrige>();
            Printer = new HashSet<Printer>();
        }

        public int CatrigeModelID { get; set; }

        [StringLength(30)]
        public string CatirgeModelName { get; set; }

        public int? ColorID { get; set; }

        public int? PrinterModelID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Catrige> Catrige { get; set; }

        public virtual CatrigeColor CatrigeColor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Printer> Printer { get; set; }
    }
}
