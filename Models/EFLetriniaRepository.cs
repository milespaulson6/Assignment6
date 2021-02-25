using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{//this is tying in the other repository
    public class EFLetriniaRepository : ILetriniaRepository
    {
        private LetriniaDbContext _context;
        //constructor
        public EFLetriniaRepository(LetriniaDbContext context)
        {
            _context = context;
        }
        //this is creating the iqueryable of products
        public IQueryable<Product> Products => _context.Products;
    }
}
