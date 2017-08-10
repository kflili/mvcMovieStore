﻿using AutoMapper;
using mvcMovieStore.Dtos;
using mvcMovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcMovieStore.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();

            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<MovieDto, Movie>();
        }
    }
}