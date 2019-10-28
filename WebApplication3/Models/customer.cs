using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{   
    // GET: taskname/Edit/5
    // public async Task<IActionResult> Edit(int? id)

    public class Customer
    {
        [Key]
        public int Customer_id { get; set; }
        public int Store_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public int Address_id { get; set; }
        public char Active { get; set; }
        public DateTime Create_date { get; set; }
        public DateTime Last_update { get; set; }
        
    }
}
