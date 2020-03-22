namespace Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Models;


    public class LazarusDentalClinicDbContext : IdentityDbContext
    {
        public LazarusDentalClinicDbContext(DbContextOptions<LazarusDentalClinicDbContext> options) : base(options)
        {
        }

        public LazarusDentalClinicDbContext()
        {

        }

  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
