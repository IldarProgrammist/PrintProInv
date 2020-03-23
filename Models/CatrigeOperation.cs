namespace PrintPro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CatrigeOperation")]
    public partial class CatrigeOperation
    {
        [Key]
        [Column("CatrigeOperation")]
        public int CatrigeOperation1 { get; set; }

        public int? CatrigeID { get; set; }

        public int? CatrigeStatusID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OperationDate { get; set; }

        public virtual CatrigeColor CatrigeColor { get; set; }

        public virtual CatrigeStatus CatrigeStatus { get; set; }
    }
}
