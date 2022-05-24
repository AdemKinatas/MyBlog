using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using System.Collections.Generic;

namespace MyBlog.Entities.Dtos.ArticleDtos
{
    public class ArticleListDto : DtoGetBase, IDto
    {
        public IList<Article> Articles { get; set; }
    }
}
