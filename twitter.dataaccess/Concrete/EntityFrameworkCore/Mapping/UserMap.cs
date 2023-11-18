using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn(1, 1);
            builder.Property(I => I.RecordTime).HasDefaultValue(DateTime.Now);
            builder.Property(I => I.UserName).HasMaxLength(140).IsRequired();
            builder.Property(I => I.NameSurname).HasMaxLength(140).IsRequired();
            builder.Property(I => I.PersonelInformation).HasMaxLength(255);
        }
    }
}