using System.ComponentModel.DataAnnotations.Schema;

namespace ModelDbCon.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

       //rs between student and department
        [ForeignKey("Department")]
        public int Dept { get; set;}
        //refrence the department table to the student
        public Department Department { get; set; }

    }
}
