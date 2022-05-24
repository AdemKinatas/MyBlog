using MyBlog.Entities.Concrete;
using MyBlog.Shared.DataAccess.Abstract;

namespace MyBlog.DataAccess.Abstract
{
    public interface IRoleDal : IEntityRepository<Role>
    {
    }
}
