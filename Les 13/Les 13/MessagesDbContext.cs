using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Les_13
{
    public partial class MessagesDbContext : DbContext
    {
        public MessagesDbContext()
            : base("name=Messages")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.added)
                .HasPrecision(0);

            modelBuilder.Entity<Author>()
                .HasMany(e => e.posts)
                .WithRequired(e => e.author)
                .HasForeignKey(e => e.author_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.content)
                .IsUnicode(false);
        }
    }
}
