namespace PrintPro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CatrigeStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatrigeStatus()
        {
            CatrigeOperation = new HashSet<CatrigeOperation>();
        }

        public int CatrigeStatusID { get; set; }

        [Required]
        [StringLength(20)]
        public string CatrigeStatusName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CatrigeOperation> CatrigeOperation { get; set; }
    }
}
