using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UI.ViewModels
{
    public class SubjectViewModel
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int FullGrade { get; set; }
        public int PassGrade { get; set; }
    }
}
