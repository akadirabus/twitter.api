using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(I => I.Id).HasName("PK_User_Id");
            builder.Property(I => I.Id).UseIdentityColumn(1, 1);
            builder.Property(I => I.RecordTime).HasColumnType("datetime").HasDefaultValueSql("GETDATE()");
            builder.Property(I => I.UserName).HasMaxLength(140).IsRequired();
            builder.Property(I => I.NameSurname).HasMaxLength(140).IsRequired();
            builder.Property(I => I.PersonelInformation).HasMaxLength(255);
            builder.Property(I => I.Location).HasMaxLength(255);
            builder.Property(I => I.BirthDate).HasColumnType("datetime");

            builder.HasMany(I => I.Messages).WithOne(I => I.User).HasForeignKey(I => I.UserId);
            builder.HasMany(I => I.Tweets).WithOne(I => I.User).HasForeignKey(I => I.UserId);
            builder.HasMany(I => I.Notifications).WithOne(I => I.User).HasForeignKey(I => I.UserId);
            builder.HasMany(I => I.UserRelations).WithOne(I => I.User).HasForeignKey(I => I.UserId);
            builder.HasMany(I => I.TweetUsers).WithOne(I => I.User).HasForeignKey(I => I.UserId);
        }
    }
}