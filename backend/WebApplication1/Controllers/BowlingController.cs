using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;
        public BowlingController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;
        }

        [HttpGet]
        public IEnumerable <Bowler> Get()
        {
            var bowlers = _bowlingRepository.Bowlers;
            foreach(var bowler in bowlers)
            {
                bowler.Team = _bowlingRepository.GetTeamById(bowler.TeamId);
            }
            //var joinedData = from bowler in _bowlingRepository.Bowlers
            //                 join team in _bowlingRepository.Teams
            //                 on bowler.TeamId equals team.TeamId
            //                 where team.TeamName == "Marlins" || team.TeamName == "Sharks"
            //                 select new Bowler
            //                 {
            //                     BowlerId = bowler.BowlerId,
            //                     BowlerLastName = bowler.BowlerLastName,
            //                     BowlerFirstName = bowler.BowlerFirstName,
            //                     BowlerMiddleInit = bowler.BowlerMiddleInit,
            //                     BowlerAddress = bowler.BowlerAddress,
            //                     BowlerCity = bowler.BowlerCity,
            //                     BowlerState = bowler.BowlerState,
            //                     BowlerZip = bowler.BowlerZip,
            //                     BowlerPhoneNumber = bowler.BowlerPhoneNumber,
            //                     TeamName = team.TeamName
            //                 };

            return bowlers;
        }

    }
}
