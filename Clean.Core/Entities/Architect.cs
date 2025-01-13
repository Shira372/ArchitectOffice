using Clean.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Models
{
    public class Architect
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }

        //Foreign Key
        //Relationships - One-To-Many
        //כשעושים קשר של יחיד ליחיד -להגדיר איפה יהיה המפתח הזר
        //רבים לרבים-מוסיף טבלה שהיא מכילה את הקשר ביניהם
        public int PlanId { get; set; }
        public Plan Plan { get; set; }
    }
}
