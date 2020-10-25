using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Models
{
    public class Client
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int          ClientId        { get; set; }

        public string       Name            { get; set; }
        
        public string       Surname         { get; set; }
        
        public string       Address         { get; set; }
        
        public string       ContactNamber   { get; set; }
        
        public bool         Verified        { get; set; }
        
        public List<Order>  Orders          { get; set; }
    }
}
