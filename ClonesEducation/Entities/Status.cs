using System;
using System.Collections.Generic;
using System.Text;

namespace ClonesEducation.Entities
{
    public class Status
    {
        public Status(int id, string name, StatusConditions conditions = null)
        {
            Id = id;
            Name = name;
            Conditions = conditions;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public StatusConditions Conditions { get; set; }
    }
}
