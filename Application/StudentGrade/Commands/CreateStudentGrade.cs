using System;
using System.Collections.Generic;
using System.Text;

namespace Application.StudentGrade.Commands
{
    public interface ICreateStudentGrade
    {
        void Create(StudentGradeModel model);
    }
    public class CreateStudentGrade : ICreateStudentGrade
    {
        private readonly IStudentGradeRepository _studentGradeRepository;
        public CreateStudentGrade(IStudentGradeRepository studentGradeRepository)
        {
            _studentGradeRepository = studentGradeRepository;
        }
        public void Create(StudentGradeModel model)
        {
            var EntityToModel = Convert(model);
            _studentGradeRepository.Insert(EntityToModel);
            _studentGradeRepository.Save();
        }
        public Entity.StudentGrade Convert(StudentGradeModel model)
        {
            var studetnGrade = new Entity.StudentGrade();
            studetnGrade.Id = model.Id;
            studetnGrade.StudentNo = model.StudentNo;
            studetnGrade.SubjectNo = model.SubjectNo;
            studetnGrade.Grade = model.Grade;

            return studetnGrade;
        }
    }
}
