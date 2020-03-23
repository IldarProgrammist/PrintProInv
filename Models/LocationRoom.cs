namespace PrintPro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LocationRoom")]
    public partial class LocationRoom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LocationRoom()
        {
            Printer = new HashSet<Printer>();
        }

        [Key]
        public int LocationID { get; set; }

        [Required]
        [StringLength(20)]
        public string Room { get; set; }

        public int? TitulID { get; set; }

        public virtual Titul Titul { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Printer> Printer { get; set; }
    }
}
