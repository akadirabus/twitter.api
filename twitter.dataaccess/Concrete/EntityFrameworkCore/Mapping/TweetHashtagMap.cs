﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Mapping
{
    public class TweetHashtagMap : IEntityTypeConfiguration<TweetHashtag>
    {
        public void Configure(EntityTypeBuilder<TweetHashtag> builder)
        {
            builder.HasKey(I => I.Id).HasName("PK_TweetHashtag_Id");
            builder.Property(I => I.Id).UseIdentityColumn(1, 1);
        }
    }
}