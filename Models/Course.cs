using System.ComponentModel.DataAnnotations.Schema;

namespace ModelDbCon.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }


        [ForeignKey("Department")]
        public int dept_id { get; set; }
       // public string DeptName { get; set; }

        public Department dept { get; set; }
    }
}
