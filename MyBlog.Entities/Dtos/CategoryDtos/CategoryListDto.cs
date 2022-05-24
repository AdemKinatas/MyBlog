using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System.Collections.Generic;

namespace MyBlog.Entities.Dtos.CategoryDtos
{
    public class CategoryListDto : DtoGetBase, IDto
    {
        public IList<Category> Categories { get; set; }
    }
}
