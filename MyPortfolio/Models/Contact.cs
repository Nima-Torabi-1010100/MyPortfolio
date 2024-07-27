using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "This field is required.")]
        [MinLength(3, ErrorMessage = "It must have at least three characters.")]
        [MaxLength(20, ErrorMessage = "It must have a maximum of twenty characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [EmailAddress(ErrorMessage = "Incorrect Format!")]
        public string Email { get; set; }
        [Range(1, 4, ErrorMessage = "This field is required.")]
        public int Service { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Message { get; set; }
        public SelectList Services { get; set; }
    }
}
