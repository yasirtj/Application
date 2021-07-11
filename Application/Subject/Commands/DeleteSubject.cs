using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Subject.Commands
{
    public interface IDeleteSubject
    {
        void Delete(SubjectModel model);
    }
    public class DeleteSubject : IDeleteSubject
    {
        private readonly ISubjectRepository _subjectRepository;
        public DeleteSubject(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }
        public void Delete(SubjectModel model)
        {
            var EntityToModel = Convert(model);
            _subjectRepository.Delete(EntityToModel.Id);

            _subjectRepository.Save();
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
