using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{//these are what are going to get passed into the database, most are required and ISBN has regex for validation
    public class Product
    {
        [Key]
        public int BookID { get; set; }
        [Required]
        public string Title { get; set; }
        

        public string AuthorFirst { get; set; }
        
        public string AuthorMiddle { get; set; }
        [Required]
        public string AuthorLast { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required, RegularExpression(@"^[0-9]{3}([- /]?[0-9]{10}?$)", ErrorMessage = "ISBN is required")]

        public string ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int PageLength { set; get; }


    }
}
