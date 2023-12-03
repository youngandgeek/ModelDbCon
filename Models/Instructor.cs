using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelDbCon.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Salary { get; set; }

        [ForeignKey("Department")]
        public int dept_id { get; set; }
      
        public Department dept{get; set;}


        [ForeignKey("Course")]
        public int course_id { get; set; }

        public Course crs { get; set; }

    }

}
