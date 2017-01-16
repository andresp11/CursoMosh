using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using cursoVidly.Models;
using cursoVidly.DTOS;

namespace cursoVidly.App_Start
{
    public class MappingProfile: Profile
    {

        public MappingProfile()
        {
            //Domain to DTO
            Mapper.CreateMap<Customers, CustomerDTO>();
            Mapper.CreateMap<Movies, MovieDTO>();
            Mapper.CreateMap<MembershipType, MembershipTypeDTO>();
            Mapper.CreateMap<Genre, GenreDTO>();
            Mapper.CreateMap<Rental, NewRentalDTO>();

            //Dto to Domain
            Mapper.CreateMap<CustomerDTO, Customers>().ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDTO, Movies>().ForMember(m => m.Id, opt => opt.Ignore());

            Mapper.CreateMap<NewRentalDTO,Rental>();
        }
    }



}