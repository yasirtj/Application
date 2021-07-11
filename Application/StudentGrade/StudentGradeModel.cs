using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Application.StudentGrade
{
    public class StudentGradeModel
    {
        
        public int Id { get; set; }
        public int StudentNo { get; set; }
        //[ForeignKey("StudentNo")]
        //public virtual Student Student { get; set; }
        public int SubjectNo { get; set; }
        //[ForeignKey("SubjectNo")]
        //public virtual Subject Subject { get; set; }
        
        public int Grade { get; set; }
    }
}
