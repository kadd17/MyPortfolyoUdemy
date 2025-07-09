using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using MyPortfolyoUdemy.DAL.Entities;

namespace MyPortfolyoUdemy.DAL.Context
{
    public class MyPortfolioContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=IKGM9C66;initial Catalog=MyPortfolioDb;integrated Security=true;");
            //optionsBuilder.UseSqlServer("Server = IKGM9C66; Database = MyDb; User Id = sa; Password = 123456_kdr; TrustServerCertificate = True; ");

             

        }

        
        // Burada DI'dan gelen seçenekleri base sınıfa iletiyoruz
        public MyPortfolioContext(DbContextOptions<MyPortfolioContext> options)
            : base(options)
        {
        }
        
    

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
