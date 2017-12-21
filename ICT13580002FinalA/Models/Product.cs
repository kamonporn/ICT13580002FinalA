using System;

namespace ICT13580002FinalA.Models
{
    public enum Product
    {
		SQLiteConnection db;
    }
    public DbHelpers(string dbPath) 
    {

		db = new SQLiteConnection(dbPath);
		db.CreateTable<Product>();
    }
}
