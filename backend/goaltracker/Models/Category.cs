using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace goaltracker.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Goal> Goals { get; set; }
        public float Progress { get; set; }
    }
}
