using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string ItemDept { get; set; }
        public string ItemDescription { get; set; }
        public DateTime ItemPrice { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}