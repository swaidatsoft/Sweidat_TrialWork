using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TrialRepository.Core.Models;


namespace Repository.EF
{
    public class ApplicationDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
              options.UseSqlServer("server=DESKTOP-Q7GF4CE\\SQLEXPRESS;database=Repository_DB ; Integrated Security=True ; MultipleActiveResultSets=True; TrustServerCertificate=True;");

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options)
        {
            
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //Unique Username

            modelBuilder.Entity<Users>()
           .HasIndex(u => u.UserName)
           .IsUnique();

            //seeds data in the company branch field

            modelBuilder.Entity<Company>()
                            .HasData(new Company { CompanyId = 1, CompanyName = "BMW", CompanyBranch = "Automotive" });

            modelBuilder.Entity<Company>()
                .HasData(new Company { CompanyId = 2, CompanyName = "Demeba", CompanyBranch = "Software Services" }); ;

            modelBuilder.Entity<Company>()
                .HasData(new Company { CompanyId = 3, CompanyName = "DB", CompanyBranch = "Automobile" });


            //seeds data in the User branch field

            modelBuilder.Entity<Users>()
                            .HasData(new Users { UserId = 1, LastName = "Demo1", FirstName="Demo",UserName = "DemoFake1" ,Password = "123654" , Confirm_Password= "123654", Email="a@fake.com", Is_AgreeToTerms =true , Is_AgreeToPrivacy=false , CompanyId =1});

            modelBuilder.Entity<Users>()
                .HasData(new Users { UserId = 2, LastName = "Demo2", FirstName = "Demo2", UserName = "DemoFake2", Password = "123654", Confirm_Password = "123654", Email = "b@fake.com", Is_AgreeToTerms = true, Is_AgreeToPrivacy = false, CompanyId = 2 });

            modelBuilder.Entity<Users>()
                .HasData(new Users { UserId = 3, LastName = "Demo2 ", FirstName = "Demo3", UserName = "DemoFake3", Password = "123654", Confirm_Password = "123654", Email = "b@fake.com", Is_AgreeToTerms = true, Is_AgreeToPrivacy = false, CompanyId = 3 });







        }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Users> Users { get; set; }




    }
}
