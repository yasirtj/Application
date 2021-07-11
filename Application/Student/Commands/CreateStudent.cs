using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Student.Commands
{
    public interface ICreateStudent
    {
        void Go(StudentModel model);
    }
   public class CreateStudent : ICreateStudent 
    {
        private readonly IStudentRepositorycs _repositorycs; 

        public CreateStudent(IStudentRepositorycs repositorycs)
        {
            _repositorycs = repositorycs;
        }
        public void Go(StudentModel model) 
        {
            var EntityToModel = Convert(model);
            _repositorycs.Insert(EntityToModel);
            _repositorycs.Save();
        }

        public Entity.Student Convert(StudentModel model)
        {
            var student = new Entity.Student();
            student.Id = model.Id;
            student.Name = model.Name;
            return student;
        }
    }
}
