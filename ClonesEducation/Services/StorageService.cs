using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClonesEducation.Entities;

namespace ClonesEducation.Services
{
    public class StorageService
    {
        public StorageResource GetStorageResource(Storage storage, int resourceId)
        {
            var resource = storage.Resources.FirstOrDefault(r => r.ResourceId == resourceId);

            if (resource == null)
                return null;

            return resource;
        }

        public (ResourcePool Resource, ResourcePool TargetResource) TakeResource(ResourcePool resource, double value)
        {
            var resourcePool = new ResourcePool();
            if (value >= resource.Count)
            {

            }
        }
    }
}
