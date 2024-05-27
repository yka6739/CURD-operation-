using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCrud
{
    [SQLite.Table("customer")]
    public  class Customer
    {
        [PrimaryKey]
        [AutoIncrement]
        [SQLite.Column("id")]
        public int Id { get; set; }
        
        [SQLite.Column("customer_name")]
        public string CustomerName { get; set; }

        [SQLite.Column("mobile")]
        public string Mobile { get; set; }

        [SQLite.Column("email")]
        public string Email { get; set; }
    }
}
