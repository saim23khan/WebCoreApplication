using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace CodeFirstApproch.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Column("StudenName",TypeName ="varchar(100)")]
        [Required]
        public string Name { get; set; }

        [Column("FatherName", TypeName = "varchar(100)")]
        [Required]
        public string FatherName { get; set; }

        [Column("StudenGender", TypeName = "varchar(10)")]
        [Required]
        public string Gender { get; set; }

        [Column("GurdianContactNo")]
        [Required]
        public long ContactNo { get; set; }

        [Column("StudenClass", TypeName = "varchar(50)")]
        [Required]
        public string Grade { get; set; }

        [Column("StudenAge")]
        [Required]
        public int Age { get; set; }
    }
}
