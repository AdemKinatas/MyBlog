using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MyBlog.Business.Abstract;
using MyBlog.Business.Concrete;
using MyBlog.Business.ValidationRules.FluentValidation.ArticleValidators;
using MyBlog.Business.ValidationRules.FluentValidation.CategoryValidators;
using MyBlog.DataAccess.Abstract;
using MyBlog.DataAccess.Concrete;
using MyBlog.DataAccess.Concrete.EfCore.Contexts;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ArticleDtos;
using MyBlog.Entities.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Extensions
{
    public static class ServisCollectionExtensions
    {
        public static IServiceCollection LoadMyservices(this IServiceCollection services)
        {
            services.AddDbContext<MyBlogContext>();
            services.AddIdentity<User, Role>(opt =>
            {
                opt.Password.RequireDigit = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequiredUniqueChars = 0;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredLength = 2;
                
                opt.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                opt.User.RequireUniqueEmail = true;
                
            }).AddEntityFrameworkStores<MyBlogContext>();
            
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IArticleService, ArticleManager>();

            services.AddTransient<IValidator<ArticleAddDto>, ArticleAddDtoValidator>();
            services.AddTransient<IValidator<ArticleUpdateDto>, ArticleUpdateDtoValidator>();
            services.AddTransient<IValidator<CategoryAddDto>, CategoryAddDtoValidator>();
            services.AddTransient<IValidator<CategoryUpdateDto>, CategoryUpdateDtoValidator>();

            return services;
        }
    }
}
