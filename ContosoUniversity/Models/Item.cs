using System;
using System.Collections.Generic;

namespace TheStore.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string ItemDept { get; set; }
        public string ItemDescription { get; set; }
        public Decimal ItemPrice { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}