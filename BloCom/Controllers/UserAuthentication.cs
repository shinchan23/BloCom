using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloCom.Controllers
{
    [ApiController]
    public class UserAuthentication : ControllerBase
    {
        public async Task<IActionResult> SignUp()
        {
            return Ok();
        }

        public async Task<IActionResult> Login()
        {
            return Ok();
        }

        public async Task<IActionResult> Logout()
        {
            return Ok();
        }
    }
}
