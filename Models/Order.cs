using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Models
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string   OrderId     { get; set; }

        public string   Status      { get; set; }
        [ForeignKey("ProductId")]
        public Product  Product     { get; set; }
        [ForeignKey("ClientId")]
        public Client   Client      { get; set; }

        public string   ClientName  { get; set; }
        
        public string   Address     { get; set; }

    }
}
