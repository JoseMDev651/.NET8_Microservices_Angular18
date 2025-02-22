﻿using ProductApi.Aplication.Interfaces;
using eCommerce.SharedLibrary.Responses;
using eCommerce.SharedLibrary.Logs;
using ProductApi.Domain.Entities;
using System.Linq.Expressions;
using ProductApi.Infrastructure.Data;
using eCommerce.SharedLibrary.Interface;
using Microsoft.EntityFrameworkCore;

namespace ProductApi.Infrastructure.Repositories
{
    internal class ProductRepository(ProductDbContext context) : IProduct
    {
        public async Task<Response> CreateAsync(Product entity)
        {
            try
            {
                //Check if the product already exists
                var getProduct = await GetByAsync(_ => _.Name!.Equals(entity.Name));
                if (getProduct is not null && !string.IsNullOrEmpty(getProduct.Name))
                    return new Response(false, $"{entity.Name} already added.");

                var currentEntity = context.Products.Add(entity).Entity;
                await context.SaveChangesAsync();
                if (currentEntity is not null && currentEntity.Id > 0)
                    return new Response(true, $"{entity.Name} added to database successfully.");
                else
                    return new Response(false, $"Error occurred adding {entity.Name}");
            }
            catch (Exception ex)
            {
                //Log the original Exception
                LogException.LogExceptions(ex);

                // Display scary-free message to the client
                return new Response(false, "Error occurred adding new product.");
            }
        }

        public async Task<Response> DeleteAsync(Product entity)
        {
            try
            {
                var product = await FindByIdAsync(entity.Id);
                if (product is null)
                    return new Response(false, $"{entity.Name} not found.");

                context.Products.Remove(product);
                await context.SaveChangesAsync();
                return new Response(true, $"{entity.Name} deleted succesfully.");
            }
            catch (Exception ex)
            {
                //Log the original Exception
                LogException.LogExceptions(ex);

                // Display scary-free message to the client
                return new Response(false, "Error occurred deleting product.");
            }
        }

        public async Task<Product> FindByIdAsync(int id)
        {
            try
            {
                var product = await context.Products.FindAsync(id);
                return product is not null ? product : null!;
            }
            catch (Exception ex)
            {
                //Log the original Exception
                LogException.LogExceptions(ex);

                // Display scary-free message to the client
                throw new Exception("Error occurred retrieving product.");
            }
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            try
            {
                var products = await context.Products.AsNoTracking().ToListAsync();
                return products is not null ? products : null!;
            }
            catch (Exception ex)
            {
                //Log the original Exception
                LogException.LogExceptions(ex);

                // Display scary-free message to the client
                throw new Exception("Error occurred retrieving products.");
            }
        }

        public async Task<Product> GetByAsync(Expression<Func<Product, bool>> predicate)
        {
            try
            {
                var product = await context.Products.Where(predicate).FirstOrDefaultAsync();
                return product is not null ? product : null!;
            }
            catch (Exception ex)
            {
                //Log the original Exception
                LogException.LogExceptions(ex);

                // Display scary-free message to the client
                throw new InvalidOperationException("Error occurred retrieving products.");
            }
        }

        public async Task<Response> UpdateAsync(Product entity)
        {
            try
            {
                var product = await FindByIdAsync(entity.Id);
                if (product is null)
                    return new Response(false, $"{entity.Name} not found.");

                context.Entry(product).State = EntityState.Detached;
                context.Products.Update(entity);
                await context.SaveChangesAsync();
                return new Response(true,$"{entity.Name} updated successfully");
            }
            catch (Exception ex)
            {
                //Log the original Exception
                LogException.LogExceptions(ex);

                // Display scary-free message to the client
                return new Response(false, "Error occurred retrieving products.");
            }
        }
    }
}
