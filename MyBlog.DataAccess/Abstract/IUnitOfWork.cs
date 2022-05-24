using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IArticleDal Articles { get; } //example using : _unitOfWork.Articles.AddAsync();
        ICategoryDal Categories { get; }
        ICommentDal Comments { get; }
        IRoleDal Roles { get; }
        IUserDal Users { get; }
        Task<int> SaveAsync();
    }
}
