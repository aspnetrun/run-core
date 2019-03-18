﻿using AspnetRun.Application.Dtos;
using AspnetRun.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspnetRun.Application.Interfaces
{
    public interface ICategoryAppService : IAspnetRunAppService<Category>
    {
        Task<CategoryDto> GetCategoryWithProductsAsync(int categoryId);
    }
}
