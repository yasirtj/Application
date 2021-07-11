using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Student.Commands
{
    public interface IDeleteStudent
    {
        void Delete(StudentModel model);
    }
    class DeleteStudentStudent : IDeleteStudent
    {
        private readonly IStudentRepositorycs _repositorycs;
        public DeleteStudentStudent(IStudentRepositorycs repositorycs)
        {
            _repositorycs = repositorycs;
        }
        public void Delete(StudentModel model)
        {
            var EntityToModel = Convert(model); 
            _repositorycs.Delete(EntityToModel.Id);
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
