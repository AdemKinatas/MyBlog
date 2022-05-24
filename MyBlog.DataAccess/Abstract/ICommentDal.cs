using MyBlog.Entities.Concrete;
using MyBlog.Shared.DataAccess.Abstract;

namespace MyBlog.DataAccess.Abstract
{
    public interface ICommentDal : IEntityRepository<Comment>
    {
    }
}
