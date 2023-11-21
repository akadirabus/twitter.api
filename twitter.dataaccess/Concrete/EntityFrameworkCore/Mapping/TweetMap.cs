using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Mapping
{
    public class TweetMap : IEntityTypeConfiguration<Tweet>
    {
        public void Configure(EntityTypeBuilder<Tweet> builder)
        {
            builder.HasKey(I => I.Id).HasName("PK_Tweet_Id");
            builder.Property(I => I.Id).UseIdentityColumn(1, 1);
            builder.Property(I => I.RecordTime).HasColumnType("datetime").HasDefaultValueSql("GETDATE()");
            builder.Property(I => I.Content).HasMaxLength(1000).IsRequired();

            builder.HasMany(I => I.UserTweets).WithOne(I => I.Tweet).HasForeignKey(I => I.TweetId);
            builder.HasMany(I => I.TweetHashtags).WithOne(I => I.Tweet).HasForeignKey(I => I.TweetId);
        }
    }
}