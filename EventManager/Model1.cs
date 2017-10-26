namespace EventManager
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=MyModel")
        {
        }

        public virtual DbSet<newEventViewer> newEventViewer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<newEventViewer>()
                .Property(e => e.Eventname)
                .IsUnicode(false);

            modelBuilder.Entity<newEventViewer>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<newEventViewer>()
                .Property(e => e.Start)
                .IsUnicode(false);

            modelBuilder.Entity<newEventViewer>()
                .Property(e => e.End)
                .IsUnicode(false);
        }
    }
}
