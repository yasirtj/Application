using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Subject.Commands
{
    public interface IEditSubject
    {
        void Edit(SubjectModel model);
    }
    public class EditSubject : IEditSubject
    {
        private readonly ISubjectRepository _subjectRepository;
        public EditSubject(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }
        public void Edit(SubjectModel model)
        {
            //var EntityToModel = Convert(model);
            //_subjectRepository.Update(EntityToModel);

            //_subjectRepository.Save();
        }

        public Entity.Subject Convert(SubjectModel model)
        {
            var subject = new Entity.Subject();
            subject.Id = model.Id;
            subject.Name = model.Name;
            subject.FullGrade = model.FullGrade;
            subject.PassGrade = model.PassGrade;
            return subject;

        }
    }
}
