using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class SpecialTag
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Special Tag Name")]
        public string SpecialTagName { get; set; }
    }
}
