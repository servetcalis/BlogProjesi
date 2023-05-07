using AutoMapper;
using Bussiness.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs.Categories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private BlogDbContext _context;
        private IMapper _mapper;

        public CategoryManager(BlogDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> AddSync(CategoryAddDto dto)
        {
            try
            {
                var model = _mapper.Map<Category>(dto);
                _context.Categories.Add(model);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<int> CountAsync()
        {
            return await _context.Categories.CountAsync();
        }

        public async Task<bool> DeleteAsync(int categoryId)
        {
            try
            {
                var model = _context.Categories.Find(categoryId);
                model.IsDeleted = true;
                model.DeletedDate = DateTime.Now;
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<CategoryListDto> GetByAllAsync()
        {
            var list = await _context.Categories.ToListAsync();
            var model = _mapper.Map<CategoryListDto>(list);
            return model;
        }

        public async Task<CategoryDto> GetByIdAsync(int categoryId)
        {
            var model = await _context.Categories.FindAsync(categoryId);
            var dtoModel = _mapper.Map<CategoryDto>(model);
            return dtoModel;
        }

        public async Task<bool> HardDeleteAsync(int categoryId)
        {
            try
            {
                var model = await _context.Categories.FindAsync(categoryId);
                _context.Categories.Remove(model);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(CategoryUpdateDto dto)
        {
            try
            {
                var model = await _context.Categories.FindAsync(dto.Id);
                model.Name = dto.Name;
                model.Description = dto.Description;
                model.Status = dto.Status;
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
