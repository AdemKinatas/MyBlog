using Microsoft.EntityFrameworkCore;
using MyBlog.DataAccess.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Shared.DataAccess.Concrete.EfCore;

namespace MyBlog.DataAccess.Concrete.EfCore
{
    public class EfCommentDal : EfEntityRepositoryBase<Comment>, ICommentDal
    {
        public EfCommentDal(DbContext context) : base(context)
        {

        }
    }
}
