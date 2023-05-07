using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
    internal class UserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.About).HasColumnType("nvarchar(max)");
            builder.Property(x => x.Picture).HasMaxLength(250);

            builder.Property(x => x.ConcurrencyStamp).IsConcurrencyToken();

            builder.HasMany<AppUserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();
            builder.HasMany<AppUserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();
            builder.HasMany<AppUserToken>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();


            var adminUser = new AppUser()
            {
                Id = 1,
                UserName = "adminuser",
                NormalizedUserName = "ADMINUSER",
                Email = "admin@user.com",
                NormalizedEmail = "ADMIN@USER.COM",
                PhoneNumber = "+95555555555",
                Picture = "/UserImages/defaultUser.png",
                Name = "Admin",
                LastName = "User",
                About = "Admin User of ProgrammersBlog",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            adminUser.PasswordHash = CreatePasswordHash(adminUser, "123456789aa");

            var editorUser = new AppUser()
            {
                Id = 2,
                UserName = "editoruser",
                NormalizedUserName = "EDITORUSER",
                Email = "editor@user.com",
                NormalizedEmail = "EDITOR@USER.COM",
                PhoneNumber = "+94444444444",
                Picture = "/UserImages/defaultUser.png",
                Name = "Editor",
                LastName = "User",
                About = "Editor User of ProgrammersBlog",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            editorUser.PasswordHash = CreatePasswordHash(editorUser, "123456789aa");

            builder.HasData(adminUser, editorUser);
        }

        private string CreatePasswordHash(AppUser adminUser, string password)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            return passwordHasher.HashPassword(adminUser, password);
        }
    }
}
