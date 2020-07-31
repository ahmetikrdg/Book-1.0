using System.Collections.Generic;
using bookpapp.webui.Models;

namespace bookpapp.webui.ViewModels
{
    public class ProductViewModel
    {
        public Category Category { get; set; }
        public List<Product> Product { get; set; }
    }
}