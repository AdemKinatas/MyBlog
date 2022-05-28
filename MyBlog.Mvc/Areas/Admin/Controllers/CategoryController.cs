using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.Entities.Dtos.CategoryDtos;
using MyBlog.Mvc.Areas.Admin.Models;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _categoryService.GetAllAsync();
            return View(result.Data);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_CategoryAddPartial");
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _categoryService.AddAsync(categoryAddDto, "Adem Kınataş");
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new CategoryAddAjaxViewModel
                    {
                        CategoryDto = result.Data,
                        CategoryAddPartial = await this.RenderViewToStringAsync("_CategoryAddPartial",categoryAddDto)
                    });

                    return Json(categoryAddAjaxModel);
                }              
            }

            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new CategoryAddAjaxViewModel
            {
                CategoryAddPartial = await this.RenderViewToStringAsync("_CategoryAddPartial", categoryAddDto)
            });

            return Json(categoryAddAjaxErrorModel);
        }

        [HttpGet]
        public async Task<JsonResult> GetAllCategories()
        {
            var result = await _categoryService.GetAllAsync();

            var categories = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });

            return Json(categories);
        }

        [HttpPost]
        public async Task<JsonResult> Delete(int categoryId)
        {
            var result = await _categoryService.DeleteAsync(categoryId, "Adem Kınataş");

            var ajaxResult = JsonSerializer.Serialize(result);
            return Json(ajaxResult);
        }
    }
}
