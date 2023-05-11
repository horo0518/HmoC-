using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public class VaccinationDal : IVaccinationDal
    {
        DataBaseHmo DataBaseHmo;
        public VaccinationDal(DataBaseHmo DataBaseHmo)
        {
            this.DataBaseHmo = DataBaseHmo;
        }
        public void AddVaccination(Vaccination Vaccination)
        {
            try
            {
                DataBaseHmo.Vaccinations.Add(Vaccination);
                DataBaseHmo.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Vaccination> GetAllVaccination()
        {
            try
            {
                return DataBaseHmo.Vaccinations.ToList();
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Vaccination>  GetVaccinationById(int id)
        {
            try
            {
                List<Vaccination> Vaccinations = DataBaseHmo.Vaccinations.Where(x => x.FriendId == id).ToList();
                if (Vaccinations != null)
                    return Vaccinations;
                else
                    return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
