﻿using Application.DTO.Company;
using Application.DTO.Pagination;
using Application.DTO.Sale;
using AutoMapper;
using Domain.Entities;
using Domain.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Company, CompanyDTO>().ReverseMap();
            CreateMap<Sale, SaleDTO>().ReverseMap();
            CreateMap<PaginationParameters, PaginationParametersDTO>().ReverseMap();
        }
    }
}
