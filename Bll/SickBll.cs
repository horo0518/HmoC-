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
        IFriendBll FriendBll;
        public SickBll(ISickDal SickDal, IMapper Mapper, IFriendBll FriendBll)
        {
            this.SickDal = SickDal;
            this.Mapper = Mapper;
            this.FriendBll = FriendBll;
        }


        public void AddSick(SickDto sickDto)
        {
            try
            {
                // Check if the FriendId exists in the friends table
                if (!this.FriendBll.FriendExists(sickDto.FriendId))
                {
                    throw new Exception($"Friend with id {sickDto.FriendId} does not exist");
                }

                Sick sick = Mapper.Map<Sick>(sickDto);

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
