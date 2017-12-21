using System;
using SQLite;
using System.Collections.Generic;
using ICT13580002FinalA.Model;

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
		public List<ProductNewPage> GetProducts()
		{
            return db.Insert(Product);

		}
		public int UpdateProduct(ProductNewPage product)
		{
			return db.Update(product);
		}

		public int DeleteProduct(ProductNewPage product)
		{
			return db.Delete(product);
		}
}
