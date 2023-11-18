using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Mapping
{
    public class TypeMessageStatusMap : IEntityTypeConfiguration<TypeMessageStatus>
    {
        public void Configure(EntityTypeBuilder<TypeMessageStatus> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Name).HasMaxLength(100);
        }
    }
}