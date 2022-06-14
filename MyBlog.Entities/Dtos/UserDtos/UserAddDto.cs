using Microsoft.AspNetCore.Http;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.UserDtos
{
    public class UserAddDto : IDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public IFormFile PictureFile { get; set; }
        public string Picture { get; set; }
    }
}
