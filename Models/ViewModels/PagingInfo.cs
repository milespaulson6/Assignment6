using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalNumBooks { get; set; }

        public int BooksPerPage { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages =>(int) Math.Ceiling(((decimal)TotalNumBooks / BooksPerPage));
    }
}
