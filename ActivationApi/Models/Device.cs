using System.ComponentModel.DataAnnotations;

namespace ActivationApi.Models
{
    public class Device
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Not valid Name (5-50 len)")]
        public string Name { get; set; }
        [Required]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Not valid IP (8-16  len)")]
        public string IP { get; set; }
    }
}
