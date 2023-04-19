using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
	internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasKey(x => x.Id); // Category tablosundaki Id primary key olsun dedik.
			builder.Property(x => x.Id).UseIdentityColumn(); // Category tablosundakiş Id identity olsun, o şekilde 1'er 1'er artsın dedik.
			builder.Property(x => x.Name).IsRequired().HasMaxLength(50); // IsRequired ile doldurulması zorunlu alan dedik HasMaxLength ile de max karakter sayısını verdik.

			builder.ToTable("Categories"); // bu şekilde tablo adını belirleyebiliyoruz ancak zaten dbcontext'deki db set ismi neyse tablo adı da o olur.
		}
	}
}
