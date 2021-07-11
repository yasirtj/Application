using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Student.Commands
{
    public interface IEditStudent
    {
        void Edit(int Id,StudentModel model); 
    }
    class EditStudent : IEditStudent
    {
        private readonly IStudentRepositorycs _repositorycs; 

        public EditStudent(IStudentRepositorycs repositorycs)
        {
            _repositorycs = repositorycs;
        }
        public void Edit(int Id,StudentModel model)
        {
            var EntityToModel = Convert(model);
            _repositorycs.Update(Id,EntityToModel);

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
