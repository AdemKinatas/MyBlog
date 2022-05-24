﻿using AutoMapper;
using MyBlog.Business.Abstract;
using MyBlog.DataAccess.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.CategoryDtos;
using MyBlog.Shared.Utilities.Results.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult> AddAsync(CategoryAddDto categoryAddDto, string createdByName)
        {
            var category = _mapper.Map<Category>(categoryAddDto);
            category.CreatedByName = createdByName;
            category.ModifiedByName = createdByName;

            await _unitOfWork.Categories.AddAsync(category);
            await _unitOfWork.SaveAsync();

            return new Result(ResultStatus.Success, $"{categoryAddDto.Name} adlı kategori başarıyla eklenmiştir.");
        }

        public async Task<IResult> DeleteAsync(int categoryId, string modifiedByName)
        {
            var category = await _unitOfWork.Categories.GetAsync(x => x.Id == categoryId);

            if (category != null)
            {
                category.IsDeleted = true;
                category.ModifiedByName = modifiedByName;
                category.ModifiedDate = DateTime.Now;
                await _unitOfWork.Categories.UpdateAsync(category);
                await _unitOfWork.SaveAsync();

                return new Result(ResultStatus.Success, $"{category.Name} adlı kategori başarıyla silinmiştir.");
            }
            return new Result(ResultStatus.Error, $"Böyle bir kategori bulunamadı.");
        }

        public async Task<IDataResult<CategoryDto>> GetAsync(int categoryId)
        {
            var category = await _unitOfWork.Categories.GetAsync(x => x.Id == categoryId, x => x.Articles);

            if (category != null)
            {
                return new DataResult<CategoryDto>(ResultStatus.Success, new CategoryDto
                {
                    Category = category,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CategoryDto>(ResultStatus.Error, "Hiç bir kategori bulunamadı!", null);
        }

        public async Task<IDataResult<CategoryListDto>> GetAllAsync()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(null, x => x.Articles);

            if (categories.Count > -1)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiç bir kategori bulunamadı!", new CategoryListDto { 
                Categories = null,
                ResultStatus = ResultStatus.Error,
                Message = "Hiç bir kategori bulunamadı!"
            });
        }

        public async Task<IDataResult<CategoryListDto>> GetAllByNotDeletedAsync()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(x => !x.IsDeleted, x => x.Articles);

            if (categories.Count > -1)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiç bir kategori bulunamadı!", null);
        }

        public async Task<IDataResult<CategoryListDto>> GetAllByNotDeletedAndActiveAsync()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(x => !x.IsDeleted && x.IsActive, x => x.Articles);

            if (categories.Count > -1)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiç bir kategori bulunamadı!", null);
        }

        public async Task<IResult> HardDeleteAsync(int categoryId)
        {
            var category = await _unitOfWork.Categories.GetAsync(x => x.Id == categoryId);

            if (category != null)
            {
                await _unitOfWork.Categories.DeleteAsync(category);
                await _unitOfWork.SaveAsync();

                return new Result(ResultStatus.Success, $"{category.Name} adlı kategori başarıyla veri tabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, $"Böyle bir kategori bulunamadı.");
        }

        public async Task<IResult> UpdateAsync(CategoryUpdateDto categoryUpdateDto, string modifiedByName)
        {
            var category = _mapper.Map<Category>(categoryUpdateDto);
            category.ModifiedByName = modifiedByName;

            await _unitOfWork.Categories.UpdateAsync(category);
            await _unitOfWork.SaveAsync();

            return new Result(ResultStatus.Success, $"{categoryUpdateDto.Name} adlı kategori başarıyla güncellenmiştir.");
        }
    }
}
