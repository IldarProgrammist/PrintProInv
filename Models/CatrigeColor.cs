namespace PrintPro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CatrigeColor")]
    public partial class CatrigeColor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatrigeColor()
        {
            CatrigeModel = new HashSet<CatrigeModel>();
            CatrigeOperation = new HashSet<CatrigeOperation>();
        }

        public int CatrigeColorID { get; set; }

        [StringLength(20)]
        public string ColorName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CatrigeModel> CatrigeModel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CatrigeOperation> CatrigeOperation { get; set; }
    }
}
