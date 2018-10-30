using System.ComponentModel.DataAnnotations;

namespace AppHealth.Models
{
    public class Role : EntityBase
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
