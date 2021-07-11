using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity
{
    public class Student 
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
