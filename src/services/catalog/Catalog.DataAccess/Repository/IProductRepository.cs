using Catalog.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.DataAccess.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<IEnumerable<Product>> GetProductByName(string name);
        Task<IEnumerable<Product>> GetProductByCategory(string category);
        Task<Product> GetProductById(string id);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(string id);
        Task CreateProduct(Product product);

    }
}
