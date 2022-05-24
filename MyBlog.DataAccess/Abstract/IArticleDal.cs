using MyBlog.Entities.Concrete;
using MyBlog.Shared.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.Abstract
{
    public interface IArticleDal : IEntityRepository<Article>
    {
    }
}
