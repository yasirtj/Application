using System;
using System.Collections.Generic;
using System.Text;

namespace Application.StudentGrade.Commands
{
    public interface IEditStudentGrade
    {
        void Edit(StudentGradeModel model); 
    }
    class EditStudentGrade : IEditStudentGrade
    {
        private readonly IStudentGradeRepository _studentGradeRepository;

        public EditStudentGrade(IStudentGradeRepository studentGradeRepository)
        {
            _studentGradeRepository = studentGradeRepository;
        }
        public void Edit(StudentGradeModel model)
        {
            //var EntityToModel = Convert(model);
            //_studentGradeRepository.Update(EntityToModel);

            //_studentGradeRepository.Save();
            
        }
        public Entity.StudentGrade Convert(StudentGradeModel model)
        {
            var studentGrade = new Entity.StudentGrade();
            studentGrade.Id = model.Id;
            studentGrade.StudentNo = model.StudentNo;
            studentGrade.SubjectNo = model.SubjectNo;
            studentGrade.Grade = model.Grade;
            return studentGrade;
        }
    }
}
