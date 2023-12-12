using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_2.Data
{
    public class Class
    {
        [Key]
        public int cid { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public int room_number { get; set; }
        [ForeignKey(nameof(Faculty))]
        public int fid { get; set; }
    }
}
