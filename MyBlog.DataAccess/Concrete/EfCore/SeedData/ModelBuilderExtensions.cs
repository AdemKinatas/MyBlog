using Microsoft.EntityFrameworkCore;
using MyBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.Concrete.EfCore.SeedData
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            #region SeedDatasOfRolesTable

            #endregion

            #region SeedDatasOfUsersTable

            #endregion

            #region SeedDatasOfCategoriesTable
            builder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Yazılım Dünyası",
                    Description = "Yazılım ile ilgili çeşitli konularda makaleler yer alacak.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Yazılım Blog Kategorisi."
                },
                new Category
                {
                    Id = 2,
                    Name = "Satranç",
                    Description = "Satranç ile ilgili çeşitli konularda makaleler yer alacak.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Satranç Blog Kategorisi."
                },
                new Category
                {
                    Id = 3,
                    Name = "Edebiyat",
                    Description = "Edebiyat ile ilgili çeşitli konularda makaleler yer alacak.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Edebiyat Blog Kategorisi."
                }
            );
            #endregion

            #region SeedDatasOfArticlesTable
           
            #endregion

            #region SeedDatasOfCommentsTable
           
            #endregion
        }
    }
}
