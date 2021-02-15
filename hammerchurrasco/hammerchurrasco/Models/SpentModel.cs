using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace hammerchurrasco.Models
{
    [Table("Spent")]
    public  class SpentModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public string Type { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
