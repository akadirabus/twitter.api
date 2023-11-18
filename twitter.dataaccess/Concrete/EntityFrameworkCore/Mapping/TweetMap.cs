using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Mapping
{
    public class TweetMap : IEntityTypeConfiguration<Tweet>
    {
        public void Configure(EntityTypeBuilder<Tweet> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn(1, 1);
            builder.Property(I => I.RecordTime).HasDefaultValue(DateTime.Now);
            builder.Property(I => I.Content).HasMaxLength(1000).IsRequired();

            builder.HasIndex(I => new { I.refUser, I.refTweet });
        }
    }
}