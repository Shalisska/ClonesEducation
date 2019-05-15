using ClonesEducation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClonesEducation.Repositories
{
    public class StatusConditionsRepository
    {
        public StatusConditionsRepository()
        {
            StatusConditions = GetStatusConditions();
        }

        private List<StatusConditions> StatusConditions { get; set; }

        public List<StatusConditions> GetStatusConditions()
        {
            var conditions = new List<StatusConditions>
            {
                new StatusConditions(1, 0),
                new StatusConditions(2, 1),
                new StatusConditions(3, 2)
            };
            return conditions;
        }


    }
}
