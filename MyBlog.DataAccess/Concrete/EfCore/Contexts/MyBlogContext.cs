using Microsoft.EntityFrameworkCore;
using MyBlog.DataAccess.Concrete.EfCore.Configurations;
using MyBlog.DataAccess.Concrete.EfCore.SeedData;
using MyBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.Concrete.EfCore.Contexts
{
    public class MyBlogContext : DbContext
    {
        public DbSet<Article>  Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Role { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.; Database=MyBlogDb; User Id=sa;Password=123;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new ArticleMap());
            //modelBuilder.ApplyConfiguration(new CategoryMap());
            //modelBuilder.ApplyConfiguration(new CommentMap());
            //modelBuilder.ApplyConfiguration(new RoleMap());
            //modelBuilder.ApplyConfiguration(new UserMap());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Seed();
        }
    }
}
