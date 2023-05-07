using DataAccess.Concrete.EntityFramework.Mapping;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class BlogDbContext : IdentityDbContext<AppUser, AppRole, int, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }


        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"data source=.;initial catalog=BlogProjectDb;persist security info=True;user id=sa;password=123");
        //}

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new CategoryMap());
            modelbuilder.ApplyConfiguration(new BlogMap());
            modelbuilder.ApplyConfiguration(new RoleMap());
            modelbuilder.ApplyConfiguration(new UserMap());
            modelbuilder.ApplyConfiguration(new RoleClaimMapping());
            modelbuilder.ApplyConfiguration(new UserClaimMapping());
            modelbuilder.ApplyConfiguration(new UserLoginMapping());
            modelbuilder.ApplyConfiguration(new UserRoleMap());
            modelbuilder.ApplyConfiguration(new UserTokenMapping());
        }
    }
}
