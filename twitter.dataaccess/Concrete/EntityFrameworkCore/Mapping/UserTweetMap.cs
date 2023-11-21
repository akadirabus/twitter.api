using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Mapping
{
    public class UserTweetMap : IEntityTypeConfiguration<UserTweet>
    {
        public void Configure(EntityTypeBuilder<UserTweet> builder)
        {
            builder.HasKey(I => I.Id).HasName("PK_UserTweet_Id");
            builder.Property(I => I.Id).UseIdentityColumn(1, 1);
        }
    }
}