using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public interface IFriendBll
    {
        List<FriendDto> GetAllFriend();
        FriendDto GetFriendById(int id);
        void AddFriend(FriendDto Friend);
        bool FriendExists(int friendId);

    }
}
