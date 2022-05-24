using Microsoft.EntityFrameworkCore;
using MyBlog.DataAccess.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Shared.DataAccess.Concrete.EfCore;

namespace MyBlog.DataAccess.Concrete.EfCore
{
    public class EfRoleDal : EfEntityRepositoryBase<Role>, IRoleDal
    {
        public EfRoleDal(DbContext context) : base(context)
        {

        }
    }
}
