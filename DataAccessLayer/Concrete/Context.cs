using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-LNMPQIK9;database=UniversitySocialPlatform; integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Messages>()
                .HasOne(x => x.SenderLearner)
                .WithMany(y => y.LearnerSender)
                .HasForeignKey(z => z.SenderID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Messages>()
               .HasOne(x => x.ReceiverLearner)
               .WithMany(y => y.LearnerReceiver)
               .HasForeignKey(z => z.ReceiverID)
               .OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(builder);
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Learner> Learners { get; set; }
        public DbSet<LearnerType> LearnerTypes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<PostRating> PostRatings { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Messages> AllMessages { get; set; }
        public DbSet<Adminim> Admins { get; set; }
    }
}
