using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SchnappsController : ControllerBase
    {
        private readonly ILogger<SchnappsController> _logger;

        public SchnappsController(ILogger<SchnappsController> logger)
        {
            _logger = logger;
        }

    }
}
