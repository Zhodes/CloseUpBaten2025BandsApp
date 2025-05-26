using CloseUpBåten2025BandsApp.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace CloseUpBåten2025BandsApp.Web.Views.Bands
{
    public class CreateVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must specify a name")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "You must specify a description")]
        public string Description { get; set; } = null!;
        public DateTime PerformanceTime { get; set; }
        public string[]? Albums { get; set; }
    }
}
