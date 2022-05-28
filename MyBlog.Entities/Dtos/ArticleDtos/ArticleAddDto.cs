using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.ArticleDtos
{
    public class ArticleAddDto : IDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.mm.yyyy}")]
        public DateTime Date { get; set; }
        public string SeoAuthor { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public bool IsActive { get; set; }
    }
}
