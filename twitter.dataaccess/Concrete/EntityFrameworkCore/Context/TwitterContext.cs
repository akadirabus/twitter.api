using Microsoft.EntityFrameworkCore;
using twitter.dataaccess.Concrete.EntityFrameworkCore.Mapping;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Context
{
    public class TwitterContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TWITTER;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new HashtagMap());
            modelBuilder.ApplyConfiguration(new MessageMap());
            modelBuilder.ApplyConfiguration(new NotificationMap());
            modelBuilder.ApplyConfiguration(new TweetMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new UserTweetMap());
            modelBuilder.ApplyConfiguration(new UserRelationMap());
        }

        public DbSet<Hashtag> Hashtag { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<TweetHashtag> TweetHashtag { get; set; }
        public DbSet<Tweet> Tweet { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRelation> UserRelation { get; set; }
        public DbSet<UserTweet> UserTweet { get; set; }
    }
}