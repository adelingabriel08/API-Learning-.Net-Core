﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data
{
    public class ProductTypeRepository : IProductTypeRepository
    {
        private readonly StoreContext _context;

        public ProductTypeRepository(StoreContext context)
        {
            _context = context;
        }
        public async Task<IReadOnlyList<ProductType>> GetProductTypesAsync()
        {
            return await _context.ProductTypes.ToListAsync();
        }

        public async Task<ProductType> GetProductTypesByIdAsync(int id)
        {
            return await _context.ProductTypes.FindAsync(id);
        }
    }
}