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
    public class SickBll : ISickBll
    {
        ISickDal SickDal;
        IMapper Mapper;
        public SickBll(ISickDal SickDal, IMapper Mapper)
        {
            this.SickDal = SickDal;
            this.Mapper = Mapper;
        }

        public void AddSick(SickDto SickDto)
        {
            try
            {

                Sick sick = Mapper.Map<Sick>(SickDto);

                SickDal.AddSick(sick);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public List<SickDto> GetAllSick()
        {
            try
            {
                return Mapper.Map<List<SickDto>>(SickDal.GetAllSick());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public SickDto GetSickById(int id)
        {
            try
            {
                return Mapper.Map<SickDto>(SickDal.GetSickById(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




    }
}
