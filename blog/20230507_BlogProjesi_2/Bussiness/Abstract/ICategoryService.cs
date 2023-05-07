using Entities.DTOs;
using Entities.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ICategoryService
    {
        Task<bool> AddSync(CategoryAddDto dto);
        Task<bool> UpdateAsync(CategoryUpdateDto dto);
        Task<bool> DeleteAsync(int categoryId);
        Task<bool> HardDeleteAsync(int categoryId);
        Task<CategoryDto> GetByIdAsync(int categoryId);
        Task<CategoryListDto> GetByAllAsync();
        Task<int> CountAsync();
    }
}
