using System;
using System.Collections.Generic;
using System.Text;

namespace ClonesEducation.Entities
{
    public class StatusConditions
    {
        public StatusConditions(int statusId, int needStatusId, List<Subject> subjects=null, int licenseCost = 0)
        {
            StatusId = statusId;
            NeedStatusId = needStatusId;
            Subjects = subjects;
            LicenseCost = licenseCost;
        }

        public int StatusId { get; set; }
        public int NeedStatusId { get; set; }
        public List<Subject> Subjects { get; set; }
        public int LicenseCost { get; set; }
    }
}
