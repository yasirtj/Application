﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.StudentGrade.Commands
{
    public interface IDeleteStudentGrade
    {
        void Delete(StudentGradeModel model);
    }
    class DeleteStudentGrade : IDeleteStudentGrade
    {
        private readonly IStudentGradeRepository _studentGradeRepository;

        public DeleteStudentGrade(IStudentGradeRepository studentGradeRepository)
        {
            _studentGradeRepository = studentGradeRepository;
        }
        public void Delete(StudentGradeModel model)
        {
            var EntityToModel = Convert(model);
            _studentGradeRepository.Delete(EntityToModel.Id);

            _studentGradeRepository.Save();

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
