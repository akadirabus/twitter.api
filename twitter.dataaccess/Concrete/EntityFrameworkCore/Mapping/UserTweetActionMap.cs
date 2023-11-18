using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Mapping
{
    public class UserTweetActionMap : IEntityTypeConfiguration<UserTweetAction>
    {
        public void Configure(EntityTypeBuilder<UserTweetAction> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn(1, 1);
        }
    }
}