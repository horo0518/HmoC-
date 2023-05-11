using Bll;
using Dal;
using Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HmoC_.Controllers
{

    [Route("api/Vaccination")]
    [ApiController]
    public class VaccinationController : ControllerBase
    {
        IVaccinationBll VaccinationBll;
        public VaccinationController(IVaccinationBll VaccinationBll)
        {
            this.VaccinationBll = VaccinationBll;
        }
        // GET: api/<VaccinationController>
        [HttpGet]
        public List<VaccinationDto> Get()
        {
            try
            {
                return VaccinationBll.GetAllVaccination();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // GET api/<VaccinationController>/5
        [HttpGet("{id}")]
        public List<VaccinationDto> Get(int id)
        {
            try
            {
                return VaccinationBll.GetVaccinationById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpPost]
        public ActionResult AddVaccination([FromBody] VaccinationDto vaccinationDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // Check if the member already has four vaccinations
                List<VaccinationDto> vaccinations = VaccinationBll.GetVaccinationById(vaccinationDto.FriendId);
                if (vaccinations != null && vaccinations.Count >= 4)
                {
                    return BadRequest("The member already has four vaccinations");
                }

                VaccinationBll.AddVaccination(vaccinationDto);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
