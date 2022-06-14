using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.UserDtos;
using MyBlog.Mvc.Areas.Admin.Models;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IWebHostEnvironment _env;
        private readonly IMapper _mapper;

        public UserController(UserManager<User> userManager, IWebHostEnvironment env, IMapper mapper)
        {
            _userManager = userManager;
            _env = env;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            var userListDto = new UserListDto
            {
                Users = users,
                ResultStatus = ResultStatus.Success
            };
            return View(userListDto);
        }

        [HttpGet]
        public IActionResult Add()
        {           
            return PartialView("_UserAddPartial");
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserAddDto userAddDto)
        {
            if (ModelState.IsValid)
            {
                userAddDto.Picture = await ImageUpload(userAddDto);
                var user = _mapper.Map<User>(userAddDto);
                var result = await _userManager.CreateAsync(user, userAddDto.Password);
                if (result.Succeeded)
                {
                    var userAddAjaxModel = JsonSerializer.Serialize(new UserAddAjaxViewModel
                    {
                        UserDto = new UserDto
                        {
                            ResultStatus = ResultStatus.Success,
                            Message = $"{user.UserName} adlı kullanıcı başarıyla eklenmiştir.",
                            User = user
                        },
                        UserAddPartial = await this.RenderViewToStringAsync("_UserAddPartial", userAddDto)
                    });

                    return Json(userAddAjaxModel);
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    var userAddAjaxErrorModel = JsonSerializer.Serialize(new UserAddAjaxViewModel
                    {
                        UserDto = new UserDto
                        {
                            ResultStatus = ResultStatus.Error,
                            Message = "Kullanıcı eklenirken bir hata oluştu."
                        },
                        UserAddPartial = await this.RenderViewToStringAsync("_UserAddPartial", userAddDto),
                        UserAddDto = userAddDto
                    });

                    return Json(userAddAjaxErrorModel);
                }
            }

            var userAddAjaxModelStateErrorModel = JsonSerializer.Serialize(new UserAddAjaxViewModel
            {
                UserDto = new UserDto
                {
                    ResultStatus = ResultStatus.Error,
                    Message = "Kullanıcı eklenirken bir hata oluştu."
                },
                UserAddPartial = await this.RenderViewToStringAsync("_UserAddPartial", userAddDto),
                UserAddDto = userAddDto
            });

            return Json(userAddAjaxModelStateErrorModel);
        }

        public async Task<string> ImageUpload(UserAddDto userAddDto)
        {
            string wwwroot = _env.WebRootPath;
            string imageExtension = Path.GetExtension(userAddDto.PictureFile.FileName);
            string imageName = $"{userAddDto.UserName}_{Guid.NewGuid()}" + imageExtension;
            //string imagePath = Path.Combine($"{wwwroot}/img",imageName);
            string imagePath = Path.Combine(wwwroot,"img",imageName);
            
            await using var stream = new FileStream(imagePath, FileMode.Create);
            await userAddDto.PictureFile.CopyToAsync(stream);
            return imageName;
        }
    }
}
