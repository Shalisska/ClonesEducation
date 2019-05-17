using System;
using System.Collections.Generic;
using System.Text;

namespace ClonesEducation.Entities
{
    public class ResourcePool
    {
        public int ResourceId { get; set; }
        public double Count { get; set; }
        public decimal CostPrice { get; set; }
        public ResourcePoolStatus Status { get; set; }
    }
}
