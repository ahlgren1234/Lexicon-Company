﻿using AutoMapper;
using Companies.API.DTOs;
using Companies.Shared.DTOs;
using Domain.Models.Entities;

namespace Companies.Infrastructure.Data
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Company, CompanyDto>()
                .ForMember(dest => dest.Address, opt => opt.MapFrom
                (src => $"{src.Address}{(string.IsNullOrEmpty(src.Country) ? string.Empty : ", ")}{src.Country}"));
            CreateMap<ApplicationUser, EmployeeDto>().ReverseMap();
            CreateMap<CompanyCreateDto, Company>();
            CreateMap<CompanyUpdateDto, Company>();
            CreateMap<ApplicationUser, EmployeeUpdateDto>().ReverseMap();
        }



    }
}
