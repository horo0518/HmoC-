using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public interface IVaccinationDal
    {
        List<Vaccination> GetAllVaccination();
       List<Vaccination> GetVaccinationById(int id);
        void AddVaccination(Vaccination Vaccination);
    }
}
