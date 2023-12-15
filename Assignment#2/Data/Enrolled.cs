using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_2.Data
{
    public class Enrolled
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Student))]
        public int sid { get; set; }
        [ForeignKey(nameof(Class))]
        public int cid { get; set; }
        [Required]
        public int marks { get; set; }
        public Student student { get; set; }
    }
}
