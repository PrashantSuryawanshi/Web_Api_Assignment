using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;


namespace Sample_Web_Api.Modal
{
    [Table("Student")]
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CorseName { get; set; }

    }
}
