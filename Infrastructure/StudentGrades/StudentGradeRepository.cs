using Application.StudentGrade;
using Infrastructure.App;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.StudentGrades
{
   public class StudentGradeRepository : Repository<Entity.StudentGrade>, IStudentGradeRepository
    {
        public StudentGradeRepository(IStudentDbContext Context):base(Context)
        {

        }
    }
}
