using ClonesEducation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClonesEducation.Repositories
{
    public class StatusRepository
    {
        private StatusConditionsRepository _statusConditionsRepository = new StatusConditionsRepository();

        public List<Status> GetStatuses()
        {
            var statuses = new List<Status>
            {
                new Status(0, "batr"),
                new Status(1, "rem"),
                new Status(2, "crest"),
                new Status(3, "mech")
            };

            return statuses;
        }
    }
}
