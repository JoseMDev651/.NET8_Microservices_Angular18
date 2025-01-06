using ProductApi.Aplication.Interfaces;
using eCommerce.SharedLibrary.Responses;
using eCommerce.SharedLibrary.Logs;
using ProductApi.Domain.Entities;
using System.Linq.Expressions;
using ProductApi.Infrastructure.Data;
using eCommerce.SharedLibrary.Interface;

namespace ProductApi.Infrastructure.Repositories
{
    internal class ProductRepository(ProductDbContext context) : IProduct
    {
        public Task<Response> CreateAsync(Product entity)
        {
            try 
            { 
            }catch (Exception ex) 
            {
                //Log the original Exception
                LogException.LogExceptions(ex);

                // Display scary-free message to the client
            }

        public Task<Response> DeleteAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<Product> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByAsync(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }

        Task<Response> IGenericInterface<Product>.CreateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        Task<Response> IGenericInterface<Product>.DeleteAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        Task<Product> IGenericInterface<Product>.FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Product>> IGenericInterface<Product>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Product> IGenericInterface<Product>.GetByAsync(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Task<Response> IGenericInterface<Product>.UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
