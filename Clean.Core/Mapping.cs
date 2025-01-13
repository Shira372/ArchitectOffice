using Clean.Core.DTOs;
using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//לא נשתמש בזה-אלא רק שנזכור מה היה קודם
namespace Clean.Core
{
    //Mapping-היא מחלקה שאין לי שום ענין ליצור ממנה מופעים ולכן היא מחלקה גלובלית -סטטית
    public class Mapping
    {
        public ArchitectDTO MapToArchitectDTO(Architect architect)
        {
            return new ArchitectDTO {Id=architect.Id,Name = architect.Name,Status=architect.Status,PlanId=architect.PlanId};
        }
    }
}
