using MyBlog.Entities.Concrete;
using MyBlog.Shared.DataAccess.Abstract;

namespace MyBlog.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
    }
}
