using Microsoft.EntityFrameworkCore;
using MyBlog.DataAccess.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Shared.DataAccess.Concrete.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.Concrete.EfCore
{
    public class EfArticleDal : EfEntityRepositoryBase<Article>, IArticleDal
    {
        public EfArticleDal(DbContext context) : base(context)
        {

        }
    }
}
