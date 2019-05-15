using System;
using System.Collections.Generic;
using System.Text;

namespace ClonesEducation.Entities
{
    public class ClonesSubject
    {
        public ClonesSubject(int subjectId, ClonesSubjectStatus? status=null)
        {
            SubjectId = subjectId;
            SubjectStatus = status ?? ClonesSubjectStatus.NotActive;
        }

        public int SubjectId { get; set; }
        public ClonesSubjectStatus SubjectStatus { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public decimal SubjectCost { get; set; }
        public decimal BoostCost { get; set; }
    }

    public enum ClonesSubjectStatus
    {
        NotActive=0,
        InProcess=1,
        Recieved=2
    }
}
