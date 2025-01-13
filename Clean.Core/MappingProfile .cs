using AutoMapper;
using Clean.Core.DTOs;
using Clean.Core.Entities;
using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Architect, ArchitectDTO>().ReverseMap();
            CreateMap<Plan, PlanDTO>().ReverseMap();
        }

    }
}
