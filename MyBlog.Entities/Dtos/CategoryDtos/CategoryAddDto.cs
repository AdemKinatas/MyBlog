using MyBlog.Shared.Entities.Abstract;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.CategoryDtos
{
    public class CategoryAddDto : IDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; }
    }
}
