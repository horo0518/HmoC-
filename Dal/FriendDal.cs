using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public class FriendDal : IFriendDal
    {
        DataBaseHmo DataBaseHmo;
        public FriendDal(DataBaseHmo DataBaseHmo)
        {
            this.DataBaseHmo = DataBaseHmo;
        }
        public List<Friend> GetAllFriend()
        {
            try
            {
                return DataBaseHmo.Friends.ToList();

            }
            catch(Exception ex) {throw new Exception(ex.Message); }
        }
             
       public void AddFriend(Friend Friend)
        {
            try
            {
                DataBaseHmo.Friends.Add(Friend);
                DataBaseHmo.SaveChanges();
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }

        public Friend GetFriendById(int id)
        {
            try
            {


                var Friend = DataBaseHmo.Friends.FirstOrDefault(x => x.Id == id);
                if (Friend != null)
                    return Friend;
                else
                    return null;
            }
            catch(Exception ex) { throw new Exception(ex.Message);}
        }
    }
}
      