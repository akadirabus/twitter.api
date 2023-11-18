using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Mapping
{
    public class HashtagMap : IEntityTypeConfiguration<Hashtag>
    {
        public void Configure(EntityTypeBuilder<Hashtag> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn(1, 1);
            builder.Property(I => I.RecordTime).HasDefaultValue(DateTime.Now);
            builder.Property(I => I.Name).HasMaxLength(100);
        }
    }
}