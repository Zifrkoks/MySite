using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int      ProductId   { get; set; }

        public string   Name        { get; set; }

        public int      Price       { get; set; }

        public int      CountOrders { get; set; }

        public float    Rating      { get; set; }

    }
}
