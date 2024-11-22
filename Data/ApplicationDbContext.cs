using Doctor.Models;
using Microsoft.EntityFrameworkCore;

namespace Doctor.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<OurDoctor> Doctors { get; set; }
        public DbSet<DoctorAppointment> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Doctordata;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}
