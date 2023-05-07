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
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // UserId ve RoleId mprimary key olarak uyarlandı.
            builder.HasKey(x => new { x.UserId, x.RoleId });
            builder.ToTable("UserRoles");
            builder.HasData(
                // AdminUser Roles
                new AppUserRole { UserId = 1, RoleId = 1 },
                new AppUserRole { UserId = 1, RoleId = 2 },
                new AppUserRole { UserId = 1, RoleId = 3 },
                new AppUserRole { UserId = 1, RoleId = 4 },
                new AppUserRole { UserId = 1, RoleId = 5 },
                new AppUserRole { UserId = 1, RoleId = 6 },
                new AppUserRole { UserId = 1, RoleId = 7 },
                new AppUserRole { UserId = 1, RoleId = 8 },
                new AppUserRole { UserId = 1, RoleId = 9 },
                new AppUserRole { UserId = 1, RoleId = 10 },
                new AppUserRole { UserId = 1, RoleId = 11 },
                new AppUserRole { UserId = 1, RoleId = 12 },
                new AppUserRole { UserId = 1, RoleId = 13 },
                new AppUserRole { UserId = 1, RoleId = 14 },
                new AppUserRole { UserId = 1, RoleId = 15 },
                new AppUserRole { UserId = 1, RoleId = 16 },
                new AppUserRole { UserId = 1, RoleId = 17 },
                // EditorUser Roles
                new AppUserRole { UserId = 2, RoleId = 1 },
                new AppUserRole { UserId = 2, RoleId = 2 },
                new AppUserRole { UserId = 2, RoleId = 3 },
                new AppUserRole { UserId = 2, RoleId = 4 },
                new AppUserRole { UserId = 2, RoleId = 5 },
                new AppUserRole { UserId = 2, RoleId = 6 },
                new AppUserRole { UserId = 2, RoleId = 7 },
                new AppUserRole { UserId = 2, RoleId = 8 },
                new AppUserRole { UserId = 2, RoleId = 17 }
            );

        }
    }
}
