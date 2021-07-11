using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UI.ViewModels
{
    public class StudentGradeViewModel
    {
        
        public int Id { get; set; }
        public int StudentNo { get; set; }
        [ForeignKey("StudentNo")]
        public virtual StudentViewModel StudentVM { get; set; }
        public int SubjectNo { get; set; }
        [ForeignKey("SubjectNo")]
        public virtual SubjectViewModel SubjectVM { get; set; }
        
        public int Grade { get; set; }

    }
}
