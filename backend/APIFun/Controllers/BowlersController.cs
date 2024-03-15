using APIFun.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIFun.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlersController : ControllerBase
    {
        private IRepository  _bowlerRepository;
        public BowlersController(IRepository temp) 
        { 
            _bowlerRepository = temp;
            
        }
        [HttpGet]
        public IEnumerable<Bowlers> Get()
        {
            var bowlerData = _bowlerRepository.Bowlers.ToArray();
            return bowlerData;
        }
    }
}
