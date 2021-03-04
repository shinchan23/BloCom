using BloCom.DTOs;
using BloCom.Entities;
using BloCom.Repositories;
using BloCom.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloCom.Controllers
{
    [ApiController]
    [Route("auth")]
    public class UserAuthentication : ControllerBase
    {
        private readonly IUserAuthRepository _userAuthRepository;

        public UserAuthentication(IUserAuthRepository userAuthRepository)
        {
            _userAuthRepository = userAuthRepository;
        }
        [HttpPost("signup")]
        public async Task<IActionResult> SignUp(UserSignupDto userSignupDto)
        {
            ServiceResponse<int> response =  await _userAuthRepository.SignUp(
                new User { UserName = userSignupDto.Username , Email = userSignupDto.Email}, userSignupDto.Password
                );

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
            
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            return Ok();
        }
    }
}
