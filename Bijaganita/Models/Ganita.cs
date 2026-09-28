using System.ComponentModel.DataAnnotations;

namespace Bijaganita.Models
{
    public class Ganita
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Formula is required")]
        public string Formula { get; set; } = "";

        public string Suggestion { get; set; } = "";
    }
}
