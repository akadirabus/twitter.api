using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Mapping
{
    public class TweetUserMap : IEntityTypeConfiguration<TweetUser>
    {
        public void Configure(EntityTypeBuilder<TweetUser> builder)
        {
            builder.HasKey(I => I.Id).HasName("PK_TweetUser_Id");
            builder.Property(I => I.Id).UseIdentityColumn(1, 1);
            builder.HasOne(I => I.DefActionType).WithMany(I => I.TweetUsers).HasForeignKey(I => I.DefActionTypeId);

        }
    }
}