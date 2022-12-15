﻿using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<RoleDTO, Role>().ReverseMap();
        }
    }
}
