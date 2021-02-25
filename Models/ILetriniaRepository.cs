using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public interface ILetriniaRepository//this is the repository being made
    {
        IQueryable<Product> Products { get; }
    }
}
