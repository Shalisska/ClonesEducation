using System;
using System.Collections.Generic;
using System.Text;

namespace ClonesEducation.Entities
{
    public class OperationOrder
    {
        public int OperationAgentId { get; set; }
        public ResourcePool Resource { get; set; }
        public OperationOrderType OrderType { get; set; }
    }

    public enum OperationOrderType
    {
        Income=0,
        Outcome=1
    }

    public enum OperationOrderStatus
    {
        Open=0,
        InProcess=1,
        Close=2
    }
}
