namespace PrintPro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catrige")]
    public partial class Catrige
    {
        public int CatrigeID { get; set; }

        [StringLength(20)]
        public string SerialNamber { get; set; }

        public int? CatrigeModelID { get; set; }

        public virtual CatrigeModel CatrigeModel { get; set; }
    }
}
