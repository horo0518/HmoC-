using AutoMapper;
using Dal;
using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class VaccinationBll : IVaccinationBll
    {

        IVaccinationDal VaccinationDal;
        IMapper Mapper;
        IFriendBll FriendBll;

        public VaccinationBll(IVaccinationDal VaccinationDal, IMapper Mapper, IFriendBll FriendBll)
        {
            this.VaccinationDal = VaccinationDal;
            this.Mapper = Mapper;
            this.FriendBll = FriendBll;
        }


        public void AddVaccination(VaccinationDto VaccinationDto)
        {
            try
            {
                // Check if the FriendId exists in the friends table
                if (FriendBll.FriendExists(VaccinationDto.FriendId))
                {
                    throw new Exception($"Friend with id {VaccinationDto.FriendId} does not exist");
                }

                Vaccination Vaccination = Mapper.Map<Vaccination>(VaccinationDto);

                VaccinationDal.AddVaccination(Vaccination);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    
    public List<VaccinationDto> GetAllVaccination()
        {
            try
            {
                return Mapper.Map<List<VaccinationDto>>(this.VaccinationDal.GetAllVaccination());
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }

        public List<VaccinationDto> GetVaccinationById(int id)
        {
            try
            {
                return Mapper.Map<List<VaccinationDto>>(this.VaccinationDal.GetVaccinationById(id));
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
