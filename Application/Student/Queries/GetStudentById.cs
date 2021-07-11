using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Student.Queries
{
    public interface IGetStudentById
    {
        StudentModel GetById(long id);
    }
    public class GetStudentById : IGetStudentById
    {
        private readonly IStudentRepositorycs _repositorycs;
        public GetStudentById(IStudentRepositorycs repositorycs)
        {
            repositorycs = _repositorycs;
        }

        public StudentModel GetById(long id)
        {
          var Entity =  _repositorycs.Get(id);
          var Model = Convert1(Entity);
            return Model;

        }
        public Entity.Student Convert(StudentModel model)
        {
            var student = new Entity.Student();
            student.Id = model.Id;
            student.Name = model.Name;

            return student;
        }

        public StudentModel Convert1(Entity.Student student)
        {
            var Entity = new StudentModel();
            Entity.Id = student.Id;
            Entity.Name = student.Name;
            return Entity;
        }
    }
}
