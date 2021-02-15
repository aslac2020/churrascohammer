using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace hammerchurrasco.Models
{
    [Table("Guest")]
    public class GuestModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
    }
}
