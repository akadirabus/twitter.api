using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Mapping
{
    public class HashtagMap : IEntityTypeConfiguration<Hashtag>
    {
        public void Configure(EntityTypeBuilder<Hashtag> builder)
        {
            builder.HasKey(I => I.Id).HasName("PK_Hashtag_Id");
            builder.Property(I => I.Id).UseIdentityColumn(1, 1);
            builder.Property(I => I.RecordTime).HasColumnType("datetime").HasDefaultValueSql("GETDATE()");
            builder.Property(I => I.Name).HasMaxLength(100);

            builder.HasMany(I => I.TweetHashtags).WithOne(I => I.Hashtag).HasForeignKey(I => I.HasttagId);
        }
    }
}