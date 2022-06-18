using Catalog.Data.Entities;
using Catalog.Data.Seed;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Catalog.Data
{
    public class CatalogContext : ICatalogContext
    {
        public IMongoCollection<Product> Products { get; }
        public CatalogContext(IConfiguration configuration)
        {

            var client = new MongoClient(configuration["DatabaseSettings:ConnectionString"]);
            var database = client.GetDatabase(configuration["DatabaseSettings:DatabaseName"]);
            Products = database.GetCollection<Product>(configuration["DatabaseSettings:CollectionName"]);
            CatalogContextSeed.SeedData(Products);
        }

    }
}
