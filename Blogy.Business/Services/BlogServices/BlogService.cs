﻿using AutoMapper;
using Blogy.Business.DTOs.BlogDtos;
using Blogy.DataAccess.Repositories.BlogRepositories;
using Blogy.Entity.Entities;

namespace Blogy.Business.Services.BlogServices
{
    public class BlogService(IBlogRepository _blogRepository, IMapper _mapper) : IBlogService
    {
        public async Task CreateAsync(CreateBlogDto dto)
        {
            var entity = _mapper.Map<Blog>(dto);
            await _blogRepository.CreateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _blogRepository.DeleteAsync(id);
        }

        public async Task<List<ResultBlogDto>> GetAllAsync()
        {
            var values = await _blogRepository.GetAllAsync();
            return _mapper.Map<List<ResultBlogDto>>(values);
        }

        public async Task<List<ResultBlogDto>> GetBlogsByCategoryIdAsync(int categoryId)
        {
            var values = await _blogRepository.GetAllAsync(x => x.CategoryId == categoryId);
            return _mapper.Map<List<ResultBlogDto>>(values);
        }

        public async Task<List<ResultBlogDto>> GetBlogsWithCategoriesAsync()
        {
            var values = await _blogRepository.GetBlogsWithCategoriesAsync();
            return _mapper.Map<List<ResultBlogDto>>(values);
        }

        public async Task<UpdateBlogDto> GetByIdAsync(int id)
        {
            var value = await _blogRepository.GetByIdAsync(id);
            return _mapper.Map<UpdateBlogDto>(value);
        }

        public async Task UpdateAsync(UpdateBlogDto dto)
        {
            var entity = _mapper.Map<Blog>(dto);
            await _blogRepository.UpdateAsync(entity);
        }
    }
}
