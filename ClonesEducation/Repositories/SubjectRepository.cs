using ClonesEducation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClonesEducation.Repositories
{
    public class SubjectRepository
    {
        public SubjectRepository()
        {
            Subjects = GetSubjects();
            SubjectsInProcess = new List<ClonesSubject>();
        }

        private List<Subject> Subjects { get; set; }
        public List<ClonesSubject> SubjectsInProcess { get; set; }

        public List<Subject> GetSubjects()
        {
            var subjects = new List<Subject>
            {
                new Subject(0, 1, "rem 1", 1),
                new Subject(1, 1, "rem 2", 1),
                new Subject(2, 1, "rem 3", 1),
                new Subject(3, 1, "rem 4", 1),
                new Subject(4, 1, "rem 5", 1)
            };

            return subjects;
        }

        public Subject GetSubject(int id)
        {
            var subject = Subjects.FirstOrDefault(s => s.Id == id);
            return subject;
        }
    }
}
