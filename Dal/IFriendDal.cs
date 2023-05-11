using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Dal
{
    public interface IFriendDal
    {
        List<Friend> GetAllFriend();
        Friend GetFriendById(int id);
        void AddFriend(Friend Friend);

    }
}
