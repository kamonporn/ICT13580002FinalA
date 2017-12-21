using System;
using SQLite;
namespace ICT13580002FinalA.Model
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        [MaxLength(200)]
        public string name { get; set; }

        [NotNull]
        [MaxLength(200)]
        public string lastName { get; set; }

        public int odl { get; set; }

        public string gen { get; set; }

        public int num { get; set; }

        public string mail{ get; set; }

        public string add { get; set; }

        public string status { get; set; }

        public int numb { get; set; }

        public decimal momoney { get; set; }

        public string pa { get; set; }
    }
}
