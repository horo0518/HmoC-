using Bll;
using Dto;
using Entity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HmoC_.Controllers
{
    [ApiController]
    [Route("api/Friend")]

    public class FriendController : ControllerBase
    {
        IFriendBll FriendBll;
        public FriendController(IFriendBll FriendBll)
        {
            this.FriendBll = FriendBll;
        }
        // GET: api/<FriendController>
        [HttpGet]
        public List<FriendDto> Get()
        {
            try
            {
                return FriendBll.GetAllFriend();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // GET api/<FriendController>/5
        [HttpGet("{id}")]
        public FriendDto Get(int id)
        {
            try
            {
                return FriendBll.GetFriendById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // POST api/<FriendController>
        [HttpPost]
        public IActionResult AddFriend([FromBody] FriendDto FriendDto)
        {
            try
            {


                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                FriendBll.AddFriend(FriendDto);

                return Ok();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
