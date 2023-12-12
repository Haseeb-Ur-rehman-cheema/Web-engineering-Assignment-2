using System.ComponentModel.DataAnnotations;

namespace Assignment_2.Data
{
    public class Student
    {
        [Key]
        public int sid { get; set; }
        [Required]
        public string sname { get; set; }
        [Required]
        public string major { get; set; }
        [Required]
        public int standing { get; set; }
    }
}
