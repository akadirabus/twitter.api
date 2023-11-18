using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Mapping
{
    public class TypeTweetMap : IEntityTypeConfiguration<TypeTweet>
    {
        public void Configure(EntityTypeBuilder<TypeTweet> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Name).HasMaxLength(100);
        }
    }
}