using Application.Student;
using Infrastructure.App;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Students
{
    public class StudentRepository : Repository<Entity.Student>, IStudentRepositorycs 
    {
        public StudentRepository(IStudentDbContext contextcs) : base(contextcs)  
        {
        }
    }
}
