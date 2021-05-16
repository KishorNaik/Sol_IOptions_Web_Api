using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Controllers
{
    [Produces("application/json")]
    [Route("api/demo")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly MySettingModel mySettingModel = null;

        public DemoController(IOptions<MySettingModel> options)
        {
            mySettingModel = options.Value;
        }

        [HttpGet("get-mysetting-values")]
        public IActionResult GetMySettingValue()
        {
            return base.Ok(mySettingModel);
        }
    }
}