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
    public class UserTokenMapping : IEntityTypeConfiguration<AppUserToken>
    {
        public void Configure(EntityTypeBuilder<AppUserToken> builder)
        {
            builder.HasKey(x => new { x.UserId, x.LoginProvider, x.Name });

            builder.Property(x => x.LoginProvider).HasMaxLength(256);
            builder.Property(x => x.Name).HasMaxLength(256);

            builder.ToTable("UserTokens");
        }
    }
}
