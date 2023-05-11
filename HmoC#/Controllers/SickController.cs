using Bll;
using Dal;
using Dto;
using Entity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HmoC_.Controllers
{
    [ApiController]
    [Route("api/Sick/")]

    public class SickController : ControllerBase
    {
        ISickBll SickBll;
        public SickController(ISickBll SickBll)
        {
            this.SickBll = SickBll;
        }
        // GET: api/<SickController>
        [HttpGet]
        public List<SickDto> Get()
        {
            try
            {
                return SickBll.GetAllSick();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // GET api/<SickController>/5
        [HttpGet("{id}")]
        public SickDto Get(int id)
        {
            try
            {
                return SickBll.GetSickById(id);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception(ex.Message);

            }
        }

        // POST api/<SickController>
        [HttpPost]
        public IActionResult AddSick([FromBody] SickDto SickDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (SickDto.GetPositive >= SickDto.DateOfRecovery)
                {
                    return BadRequest("Positive date must be before recovery date");
                }

                SickBll.AddSick(SickDto);

                return Ok();
        }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500, "Internal error");
            }
}

    }
}
