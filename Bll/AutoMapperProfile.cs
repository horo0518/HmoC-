using AutoMapper;
using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class AutoMapperProfil:Profile
    {
        public AutoMapperProfil()
        {

            CreateMap<Friend, FriendDto>();
            CreateMap<FriendDto, Friend>();


            CreateMap<Vaccination, VaccinationDto>();
            CreateMap<VaccinationDto, Vaccination>();

            CreateMap<Sick, SickDto>();
            CreateMap<SickDto, Sick>();




        }
    }
}
