using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Entities
{
    public class Plan
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public List<Architect> Architects { get; set; }
    }
}
