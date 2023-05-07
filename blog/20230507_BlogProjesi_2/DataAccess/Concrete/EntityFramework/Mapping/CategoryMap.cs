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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            //builder.ToTable("Categories");


            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "C#",
                    Description = "C# programlama dili ile ilgili en güncel bilgiler"
                }, 
                new Category
                {
                    Id = 2,
                    Name = "C++",
                    Description = "C++ programlama dili ile ilgili en güncel bilgiler"
                },
                new Category
                {
                    Id = 3,
                    Name = "JavaScript",
                    Description = "JavaScript programlama dili ile ilgili en güncel bilgiler"
                },
                new Category
                {
                    Id = 4,
                    Name = "TypeScript",
                    Description = "TypeScript programlama dili ile ilgili en güncel bilgiler"
                },
                new Category
                {
                    Id = 5,
                    Name = "Java",
                    Description = "Java programlama dili ile ilgili en güncel bilgiler"
                },
                new Category
                {
                    Id = 6,
                    Name = "Python",
                    Description = "Pyhton programlama dili ile ilgili en güncel bilgiler"
                },
                new Category
                {
                    Id = 7,
                    Name = "Kotlin",
                    Description = "Kotlin programlama dili ile ilgili en güncel bilgiler"
                },
                new Category
                {
                    Id = 8,
                    Name = "Swift",
                    Description = "Swift programlama dili ile ilgili en güncel bilgiler"
                },
                new Category
                {
                    Id = 9,
                    Name = "Php",
                    Description = "Php programlama dili ile ilgili en güncel bilgiler"
                },
                new Category
                {
                    Id = 10,
                    Name = "Ruby",
                    Description = "Ruby programlama dili ile ilgili en güncel bilgiler"
                }
            );
        }
    }
}
