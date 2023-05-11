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
    public class FriendBll : IFriendBll
    {
        IFriendDal FriendDal;
        IMapper Mapper;
        public FriendBll(IFriendDal FriendDal, IMapper Mapper)
        {

            this.FriendDal=FriendDal; 
            this.Mapper=Mapper;
        }

        public void AddFriend(FriendDto FriendDto)
        {
            try
            {
                Friend friend = Mapper.Map<Friend>(FriendDto);
                FriendDal.AddFriend(friend);
            }
            catch (Exception ex)
            {
                 throw new Exception(ex.Message);

            }

        }

        public List<FriendDto> GetAllFriend()
        {
            try
            {
                return Mapper.Map<List<FriendDto>>(this.FriendDal.GetAllFriend());
            }
            catch (Exception ex) { throw new Exception(ex.Message);}
        }

        public FriendDto GetFriendById(int id)
        {
            try
            {
                return Mapper.Map<FriendDto>(this.FriendDal.GetFriendById(id));
            }
            catch (Exception ex) { throw new Exception(ex.Message);}
        }
    }
}
