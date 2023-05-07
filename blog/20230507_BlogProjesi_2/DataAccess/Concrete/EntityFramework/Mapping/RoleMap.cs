using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
    public class RoleMap : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.NormalizedName).HasName("RoleNameIndex").IsUnique();
            builder.ToTable("Roles");
            builder.Property(x => x.ConcurrencyStamp).IsConcurrencyToken();
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.NormalizedName).HasMaxLength(100);

            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();
            builder.HasMany<AppRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

            builder.HasData(
                new AppRole()
                {
                    Id = 1,
                    Name = "Category.Create",
                    NormalizedName = "CATEGORY.CREATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new AppRole()
                {
                    Id = 2,
                    Name = "Category.Read",
                    NormalizedName = "CATEGORY.READ",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new AppRole()
                {
                    Id = 3,
                    Name = "Category.Update",
                    NormalizedName = "CATEGORY.UPDATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new AppRole()
                {
                    Id = 4,
                    Name = "Category.Delete",
                    NormalizedName = "CATEGORY.DELETE",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new AppRole()
                {
                    Id = 5,
                    Name = "Blog.Create",
                    NormalizedName = "BLOG.CREATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new AppRole()
                {
                    Id = 6,
                    Name = "Blog.Read",
                    NormalizedName = "BLOG.READ",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new AppRole()
                {
                    Id = 7,
                    Name = "Blog.Update",
                    NormalizedName = "BLOG.UPDATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new AppRole()
                {
                    Id = 8,
                    Name = "Blog.Delete",
                    NormalizedName = "BLOG.DELETE",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new AppRole()
                {
                    Id = 9,
                    Name = "User.Create",
                    NormalizedName = "USER.CREATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new AppRole()
                {
                    Id = 10,
                    Name = "User.Read",
                    NormalizedName = "USER.READ",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new AppRole()
                {
                    Id = 11,
                    Name = "User.Update",
                    NormalizedName = "USER.UPDATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new AppRole()
                {
                    Id = 12,
                    Name = "User.Delete",
                    NormalizedName = "USER.DELETE",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new AppRole()
                {
                    Id = 13,
                    Name = "Role.Create",
                    NormalizedName = "ROLE.CREATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new AppRole()
                {
                    Id = 14,
                    Name = "Role.Read",
                    NormalizedName = "ROLE.READ",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new AppRole()
                {
                    Id = 15,
                    Name = "Role.Update",
                    NormalizedName = "ROLE.UPDATE",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new AppRole()
                {
                    Id = 16,
                    Name = "Role.Delete",
                    NormalizedName = "ROLE.DELETE",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new AppRole()
                {
                    Id = 17,
                    Name = "AdminArea.Home.Read",
                    NormalizedName = "ADMINAREA.HOME.READ",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                }
            );
        }
    }
}
