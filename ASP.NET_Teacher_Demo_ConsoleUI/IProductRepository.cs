using ASP.NET_Teacher_Demo_ConsoleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Teacher_Demo_ConsoleUI
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
