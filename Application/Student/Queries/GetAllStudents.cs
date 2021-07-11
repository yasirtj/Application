using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Student.Queries
{
    public interface IGetAllStudents
    {
        IEnumerable<Entity.Student> GetAll();
    }
    public class GetAllStudents : IGetAllStudents
    {
        private readonly IStudentRepositorycs _repositorycs;
       
        public GetAllStudents(IStudentRepositorycs repositorycs)
        {
            _repositorycs = repositorycs;
        }
        public IEnumerable<Entity.Student> GetAll()
        {
            return _repositorycs.GetAll();
            
        }
    }
}
