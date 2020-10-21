using System;
using System.Threading;
using Microsoft.AspNetCore.Mvc;

namespace SlowServer.Controllers
{
    [ApiController]
    public class SlowController : ControllerBase
    {
        private TimeSpan _sleepDuration;
        public SlowController()
        {
            _sleepDuration = TimeSpan.FromSeconds(20);
        }

        [HttpGet("{*url}", Order = int.MaxValue)]
        public IActionResult Get()
        {
            Thread.Sleep(_sleepDuration);
            return Ok();
        }

        [HttpPost("{*url}", Order = int.MaxValue)]
        public IActionResult Post()
        {
            Thread.Sleep(_sleepDuration);
            return Ok();
        }
    }
}
