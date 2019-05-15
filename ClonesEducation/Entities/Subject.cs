using System;
using System.Collections.Generic;
using System.Text;

namespace ClonesEducation.Entities
{
    public class Subject
    {
        public Subject() { }
        public Subject(int id, int statusId, string name, decimal price)
        {
            Id = id;
            StatusId = statusId;
            Name = Name;
            Price = price;
        }

        public int Id { get; set; }
        public int StatusId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
