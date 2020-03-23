namespace PrintPro.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextModel : DbContext
    {
        public ContextModel()
            : base("name=ContextModel")
        {
        }

        public virtual DbSet<Catrige> Catrige { get; set; }
        public virtual DbSet<CatrigeColor> CatrigeColor { get; set; }
        public virtual DbSet<CatrigeModel> CatrigeModel { get; set; }
        public virtual DbSet<CatrigeOperation> CatrigeOperation { get; set; }
        public virtual DbSet<CatrigeStatus> CatrigeStatus { get; set; }
        public virtual DbSet<LocationRoom> LocationRoom { get; set; }
        public virtual DbSet<Printer> Printer { get; set; }
        public virtual DbSet<PrinterFirm> PrinterFirm { get; set; }
        public virtual DbSet<PrinterModel> PrinterModel { get; set; }
        public virtual DbSet<PrinterOperation> PrinterOperation { get; set; }
        public virtual DbSet<PrinterStatus> PrinterStatus { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Titul> Titul { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatrigeColor>()
                .HasMany(e => e.CatrigeModel)
                .WithOptional(e => e.CatrigeColor)
                .HasForeignKey(e => e.ColorID);

            modelBuilder.Entity<CatrigeColor>()
                .HasMany(e => e.CatrigeOperation)
                .WithOptional(e => e.CatrigeColor)
                .HasForeignKey(e => e.CatrigeStatusID);

            modelBuilder.Entity<LocationRoom>()
                .HasMany(e => e.Printer)
                .WithOptional(e => e.LocationRoom)
                .HasForeignKey(e => e.LocarionRoomID);

            modelBuilder.Entity<PrinterFirm>()
                .HasMany(e => e.PrinterModel)
                .WithRequired(e => e.PrinterFirm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PrinterStatus>()
                .HasMany(e => e.PrinterOperation)
                .WithOptional(e => e.PrinterStatus)
                .HasForeignKey(e => e.PrinterStatudID);
        }
    }
}
