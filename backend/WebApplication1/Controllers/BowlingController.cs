using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;
        public BowlingController(IBowlingRepository temp) {
            _bowlingRepository = temp;
        }
        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlingData = _bowlingRepository.Bowlers.ToArray();

            return bowlingData;
        }
    }
}
