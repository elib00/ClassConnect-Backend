using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ClassConnect_Backend.Models
{
    public class UserProfile
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }


        [JsonIgnore]

        public User User { get; set; }  

    }
}
