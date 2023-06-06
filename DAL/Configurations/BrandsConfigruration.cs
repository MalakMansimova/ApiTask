using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;
using WEB_API.Entities;

namespace WEB_API.DAL.Configurations
{
    public class BrandsConfigruration:IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(c => c.Name)    //Oxunagliq cehetden bu pabka ve classlari yaradib yaziriq.
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType(SqlDbType.NVarChar.ToString());

        }
    }
}
