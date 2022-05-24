using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;

namespace MyBlog.Entities.Dtos.CategoryDtos
{
    public class CategoryDto : DtoGetBase, IDto
    {
        public Category Category { get; set; }
    }
}
