using System;
using System.Linq;
using System.Collections.Generic;
using ICT13580002FinalA.Model;
using SQLite;
namespace ICT13580002FinalA.Helpers
{
    public class DbHelpers
    {
        SQLiteConnection db;

        public DbHelpers(string dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<ProductNewPage>();
        }

        public Guid AddProduct(ProductNewPage product)
        {
            db.Insert(product);
            return product.Id;

        }
        public List<Product> GetProducts()
        {
            return db.Table<Product>().ToList();

        }
        public int UpdateProduct(Product product)
        {
            return db.Update(product);
        }

        public int DeleteProduct(Product product)
        {
            return db.Delete(product);
        }
    }
}
