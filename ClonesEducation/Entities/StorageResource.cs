using System;
using System.Collections.Generic;
using System.Text;

namespace ClonesEducation.Entities
{
    public class StorageResource
    {
        public int ResourceId { get; set; }
        public List<ResourcePool> Pools { get; set; }
    }
}
