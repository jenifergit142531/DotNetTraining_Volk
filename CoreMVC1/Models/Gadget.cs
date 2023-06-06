using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CoreMVC1.Models
{
    public class Gadget
    {
        [Key]
        public int GadgetId { get; set; }

        [Required(ErrorMessage ="Gadget name is required")]
        [StringLength(20,ErrorMessage ="Gadget name should be less than 20 characters")]
        public string GadgetName { get; set; }

        [Range(1000,3000,ErrorMessage ="Gadget price must be between 1000 and 2000")]
        public int Price { get; set; }

        [DisplayName("Availability")]
        public int Quantity { get; set; }

    }
}
