using System.ComponentModel.DataAnnotations;

namespace ClassConnect_Backend.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Lrn { get; set; }
        public DateTime Birthdate { get; set; }

    }
}
