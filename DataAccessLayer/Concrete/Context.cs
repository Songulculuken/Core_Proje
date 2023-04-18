using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=192.168.100.40;database=CoreProjeDB;Persist Security Info=True;User ID=Logo;Password=JnRpndvJ;"); //bağlantı adresi
        }
        public DbSet<About> Abouts { get; set; } //Abouts sql tablo ismi. About c# da kullanacağımız isim
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocaialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
