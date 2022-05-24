using MyBlog.Entities.Dtos.CategoryDtos;
using MyBlog.Shared.Utilities.Results.Abstract;
using System.Threading.Tasks;

namespace MyBlog.Business.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<CategoryDto>> GetAsync(int categoryId);
        Task<IDataResult<CategoryListDto>> GetAllAsync();
        Task<IDataResult<CategoryListDto>> GetAllByNotDeletedAsync();
        Task<IDataResult<CategoryListDto>> GetAllByNotDeletedAndActiveAsync();
        Task<IResult> AddAsync(CategoryAddDto categoryAddDto, string createdByName);
        Task<IResult> UpdateAsync(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
        Task<IResult> DeleteAsync(int categoryId, string modifiedByName);
        Task<IResult> HardDeleteAsync(int categoryId);
    }
}
