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
    public class UserLoginMapping : IEntityTypeConfiguration<AppUserLogin>
    {
        public void Configure(EntityTypeBuilder<AppUserLogin> builder)
        {
            builder.HasKey(x => new { x.LoginProvider, x.ProviderKey });
            builder.Property(x => x.LoginProvider).HasMaxLength(128);
            builder.Property(x => x.ProviderKey).HasMaxLength(128);
            builder.ToTable("UserLogins");
        }
    }
}
