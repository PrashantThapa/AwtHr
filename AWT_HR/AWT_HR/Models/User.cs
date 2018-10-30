using System.ComponentModel.DataAnnotations;

namespace AppHealth.Models
{
    public class User : EntityBase
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Username { get; set; }


        public Role Role { get; set; }

        [Required]
        [MaxLength(255)]
        public string Password { get; set; }
        public int RoleId { get; set; }
        
    }
}
