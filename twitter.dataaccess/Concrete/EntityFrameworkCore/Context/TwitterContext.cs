using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using twitter.dataaccess.Concrete.EntityFrameworkCore.Mapping;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Context
{
    public class TwitterContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=AKADIRABUS;Initial Catalog=TWITTER;User ID=sa; Password=1122;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ActionTypeMap());
            modelBuilder.ApplyConfiguration(new ActionTypeMap());
            modelBuilder.ApplyConfiguration(new ActionTypeMap());
            modelBuilder.ApplyConfiguration(new MessageTypeMap());
            modelBuilder.ApplyConfiguration(new NotificationMap());
            modelBuilder.ApplyConfiguration(new TweetHashtagMap());
            modelBuilder.ApplyConfiguration(new TweetMap());
            modelBuilder.ApplyConfiguration(new TweetTypeMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new UserTweetActionMap());
        }

        public DbSet<ActionType> ActionType { get; set; }
        public DbSet<Hashtag> Hashtag { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<MessageType> MessageType { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<Tweet> Tweet { get; set; }
        public DbSet<TweetHashtag> TweetHashtag { get; set; }
        public DbSet<TweetType> TweetType { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserTweetAction> UserTweetAction { get; set; }
    }
}