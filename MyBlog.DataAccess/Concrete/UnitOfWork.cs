using MyBlog.DataAccess.Abstract;
using MyBlog.DataAccess.Concrete.EfCore;
using MyBlog.DataAccess.Concrete.EfCore.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyBlogContext _context;
        private EfArticleDal _efArticleDal;
        private EfCategoryDal _efCategoryDal;
        private EfCommentDal _efCommentDal;
        private EfRoleDal _efRoleDal;
        private EfUserDal _efUserDal;

        public UnitOfWork(MyBlogContext context)
        {
            _context = context;
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public IArticleDal Articles => _efArticleDal ?? new EfArticleDal(_context);

        public ICategoryDal Categories => _efCategoryDal ?? new EfCategoryDal(_context);

        public ICommentDal Comments => _efCommentDal ?? new EfCommentDal(_context);

        public IRoleDal Roles => _efRoleDal ?? new EfRoleDal(_context);

        public IUserDal Users => _efUserDal ?? new EfUserDal(_context);

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
