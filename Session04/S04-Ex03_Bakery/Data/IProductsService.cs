using System.Collections.Generic;
using S04_Ex03_Bakery.Models;

namespace S04_Ex03_Bakery.Data
{
    public interface IProductsService
    {
        public IList<Product> Products { get; }
    }
}