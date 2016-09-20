namespace Assignment1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<addresses> addresses { get; set; }
        public virtual DbSet<assigned> assigned { get; set; }
        public virtual DbSet<degrees> degrees { get; set; }
        public virtual DbSet<employee_addresses> employee_addresses { get; set; }
        public virtual DbSet<employee_degrees> employee_degrees { get; set; }
        public virtual DbSet<employee_positions> employee_positions { get; set; }
        public virtual DbSet<employees> employees { get; set; }
        public virtual DbSet<headquarter_addresses> headquarter_addresses { get; set; }
        public virtual DbSet<headquarters> headquarters { get; set; }
        public virtual DbSet<positions> positions { get; set; }
        public virtual DbSet<projects> projects { get; set; }
        public virtual DbSet<working_on> working_on { get; set; }
        public virtual DbSet<works_for> works_for { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<addresses>()
                .HasMany(e => e.employee_addresses)
                .WithRequired(e => e.addresses)
                .HasForeignKey(e => new { e.addr_postal, e.addr_country })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<addresses>()
                .HasMany(e => e.headquarter_addresses)
                .WithOptional(e => e.addresses)
                .HasForeignKey(e => new { e.addr_postal, e.addr_country });

            modelBuilder.Entity<degrees>()
                .HasMany(e => e.employee_degrees)
                .WithOptional(e => e.degrees)
                .HasForeignKey(e => e.degree_id);

            modelBuilder.Entity<employees>()
                .HasMany(e => e.employee_addresses)
                .WithOptional(e => e.employees)
                .HasForeignKey(e => e.emp_bsn);

            modelBuilder.Entity<employees>()
                .HasMany(e => e.employee_degrees)
                .WithOptional(e => e.employees)
                .HasForeignKey(e => e.emp_bsn);

            modelBuilder.Entity<employees>()
                .HasMany(e => e.employee_positions)
                .WithOptional(e => e.employees)
                .HasForeignKey(e => e.emp_bsn);

            modelBuilder.Entity<employees>()
                .HasMany(e => e.working_on)
                .WithOptional(e => e.employees)
                .HasForeignKey(e => e.emp_bsn);

            modelBuilder.Entity<headquarters>()
                .Property(e => e.rent)
                .HasPrecision(10, 2);

            modelBuilder.Entity<headquarters>()
                .HasMany(e => e.headquarter_addresses)
                .WithOptional(e => e.headquarters)
                .HasForeignKey(e => e.hq_name);

            modelBuilder.Entity<headquarters>()
                .HasMany(e => e.works_for)
                .WithOptional(e => e.headquarters)
                .HasForeignKey(e => e.hq_name);

            modelBuilder.Entity<positions>()
                .Property(e => e.fee)
                .HasPrecision(10, 2);

            modelBuilder.Entity<positions>()
                .HasMany(e => e.assigned)
                .WithOptional(e => e.positions)
                .HasForeignKey(e => e.position_name);

            modelBuilder.Entity<projects>()
                .Property(e => e.budget)
                .HasPrecision(10, 2);

            modelBuilder.Entity<projects>()
                .HasMany(e => e.assigned)
                .WithOptional(e => e.projects)
                .HasForeignKey(e => e.project_id);

            modelBuilder.Entity<projects>()
                .HasMany(e => e.working_on)
                .WithOptional(e => e.projects)
                .HasForeignKey(e => e.project_id);
        }
    }
}
