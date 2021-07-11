using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Subject.Commands
{
    public interface ICreateSubject
    {
        void Create(SubjectModel model);
    }
    public class CreateSubject : ICreateSubject
    {
        private readonly ISubjectRepository _subjectRepository;
        public CreateSubject(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }
        public void Create(SubjectModel model)
        {
            var EntityToModel = Convert(model);
            _subjectRepository.Insert(EntityToModel);
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
