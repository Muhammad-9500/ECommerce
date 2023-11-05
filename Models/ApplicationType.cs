using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class ApplicationType
    {
        public int Id { get; set; }

        [DisplayName("Application Type Name")]
        [Required]
        public string Name { get; set; }
    }
}
