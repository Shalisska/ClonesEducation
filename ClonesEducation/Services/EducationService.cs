using ClonesEducation.Entities;
using ClonesEducation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClonesEducation.Services
{
    public class EducationService
    {
        public EducationService()
        {
            _subjectRepository = new SubjectRepository();
        }

        private SubjectRepository _subjectRepository;

        public TimeSpan BaseEducateTime = TimeSpan.FromSeconds(72);

        public TimeSpan GetTimeForLearnSubject(int boost)
        {
            if (boost < 2)
                return BaseEducateTime;

            if (boost >= 2 && boost <= 10)
                return BaseEducateTime / boost;

            if (boost == 20)
                return new TimeSpan(0);

            return BaseEducateTime;
        }

        public void StartLearning(int id, int boost)
        {
            var subject = _subjectRepository.GetSubject(id);
            var duration = GetTimeForLearnSubject(boost);
            var startDate = DateTime.Now;

            var subjectProcessed = new ClonesSubject(id)
            {
                SubjectStatus = ClonesSubjectStatus.InProcess,
                StartDate = startDate,
                FinishDate = startDate + duration,
                SubjectCost = subject.Price,
                BoostCost = boost
            };

            _subjectRepository.SubjectsInProcess.Add(subjectProcessed);
        }

        public double CheckProgress()
        {
            var time = DateTime.Now;

            var subject = _subjectRepository.SubjectsInProcess.FirstOrDefault();
            var duration = subject.FinishDate - subject.StartDate;
            var progress = (time - subject.StartDate) / duration * 100;

            return progress > 100 ? 100 : progress;
        }

        public void ShowProgress()
        {
            var progress = 0d;
            var counter = 72;

            while (progress < 100 && counter > 0)
            {
                progress = CheckProgress();
                Console.WriteLine(progress);
                counter--;

                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
