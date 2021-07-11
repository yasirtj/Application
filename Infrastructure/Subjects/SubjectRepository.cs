using Application.Subject;
using Infrastructure.App;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Subjects
{
    public class SubjectRepository : Repository<Entity.Subject>, ISubjectRepository
    {
        public SubjectRepository(IStudentDbContext context) : base(context) { }
      
    }
}
