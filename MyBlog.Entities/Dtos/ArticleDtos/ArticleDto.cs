using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;

namespace MyBlog.Entities.Dtos.ArticleDtos
{
    public class ArticleDto : DtoGetBase, IDto
    {
        public Article Article { get; set; }
    }
}
