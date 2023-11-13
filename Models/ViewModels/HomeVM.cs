using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECommerce.Models.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Product> Products { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}
