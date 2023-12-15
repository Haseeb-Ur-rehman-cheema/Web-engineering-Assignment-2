using System.ComponentModel.DataAnnotations;

namespace Assignment_2.Data
{
    public class Faculty
    {
        [Key]
        public int fid { get; set; }
        [Required]
        public string fname { get; set; }
        [Required]
        public int deptid { get; set; }
        [Required]
        public int standing { get; set; }
        [Required]
        public string deptname { get; set; }
    }
}
