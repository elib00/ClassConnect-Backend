using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ClassConnect_Backend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]        
        public string Email { get; set; }

        [JsonIgnore]

        public string Password { get; set; }

        public UserProfile Profile { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
