using System;
using System.Collections.Generic;
using System.Text;

namespace ClonesEducation.Entities
{
    public class Transaction
    {
        public OperationOrder Income { get; set; }
        public OperationOrder Outcome { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }

    public enum TransactionStatus
    {
        Create=0,
        Done=1
    }
}
