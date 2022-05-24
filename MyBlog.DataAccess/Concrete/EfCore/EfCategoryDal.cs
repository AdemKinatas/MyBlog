using Microsoft.EntityFrameworkCore;
using MyBlog.DataAccess.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Shared.DataAccess.Concrete.EfCore;

namespace MyBlog.DataAccess.Concrete.EfCore
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category>, ICategoryDal
    {
        public EfCategoryDal(DbContext context) : base(context)
        {

        }
    }
}
