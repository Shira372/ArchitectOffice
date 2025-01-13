using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.DTOs
{
    public class ArchitectDTO
    {
        //משמש כדי להעביר את נתוני ה-- לשכבות אחרות-ArchitectDTO
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public int PlanId { get; set; }
        public PlanDTO Plan { get; set; }
    }
}
