using AutoMapper;
using BLL.DTOs;
using DAL.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class MapperConfig
    {
        static MapperConfiguration cfg = new MapperConfiguration(c =>
        {
            c.CreateMap<UserRole, CreateRoleDTO>().ReverseMap();
            c.CreateMap<UserRole, ResponseRoleDTO>().ReverseMap();
        });
        public static Mapper GetMapper()
        {
            return new Mapper(cfg);
        }
    }
}
