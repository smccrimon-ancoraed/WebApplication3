using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication3.Models
{
    public class Address
    {
        [Key]
        public int Address_id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string District { get; set; }
        public int City_id { get; set; }
        public string Postal_code { get; set; }
        public string Phone { get; set; }
        public DateTime Last_update { get; set; }

    }
}
