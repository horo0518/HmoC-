using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public class SickDal : ISickDal
    {
        DataBaseHmo DataBaseHmo;
        public SickDal(DataBaseHmo DataBaseHmo)
        {
            this.DataBaseHmo = DataBaseHmo;
        }
        public void AddSick(Sick Sick)

        {
            try
            {
                DataBaseHmo.Sicks.Add(Sick);
                DataBaseHmo.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<Sick> GetAllSick()
        {
            try
            {
                return DataBaseHmo.Sicks.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Sick GetSickById(int id)
        {
            try
            {
                var Sick = DataBaseHmo.Sicks.FirstOrDefault(x => x.FriendId == id);
                if (Sick != null)
                    return Sick;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
