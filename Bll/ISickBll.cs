using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public interface ISickBll
    {
        List<SickDto> GetAllSick();
        SickDto GetSickById(int id);
        void AddSick(SickDto Sick);
    }
}
