using System;
using System.Collections.Generic;
using System.Text;
using JasonFinalExam.DataAccessLayer;
using JasonFinalExam.Pocos;

namespace LocgicalLayer
{
    class StudentLogical
    {
        private FinalExamRepository<Student> _repository;

        public StudentLogical(FinalExamRepository<Student> repository)         
        {
            _repository = repository;
        }

        protected void Verify(Student[] pocos)
        {
            List<Exception> exceptions = new List<Exception>();

            foreach (var poco in pocos)
            {
                if (String.IsNullOrEmpty(poco.ID.ToString()))
                {
                    exceptions.Add(new Exception("ID cannot be empty or null"));
                }
            }

            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }

        public void Add(Student[] pocos)
        {
            Verify(pocos);
            _repository.Add(pocos);
        }

        public void Update(Student[] pocos)
        {
            Verify(pocos);
            _repository.Update(pocos);
        }

        public Student Get(int ID)
        {
            return _repository.Get(ID);
        }

        public void Remove(Student[] studnets)
        {
            _repository.Remove(studnets);
        }
    }
}
