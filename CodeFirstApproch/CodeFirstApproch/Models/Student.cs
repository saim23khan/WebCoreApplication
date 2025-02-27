using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproch.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Column("StudenName",TypeName ="varchar(100)")]
        public string Name { get; set; }

        [Column("FatherName", TypeName = "varchar(100)")]
        public string FatherName { get; set; }

        [Column("StudenGender", TypeName = "varchar(10)")]
        public string Gender { get; set; }

        [Column("GurdianContactNo")]
        public int ContactNo { get; set; }

        [Column("StudenClass", TypeName = "varchar(50)")]
        public string Grade { get; set; }

        [Column("StudenAge")]
        public int Age { get; set; }
    }
}
