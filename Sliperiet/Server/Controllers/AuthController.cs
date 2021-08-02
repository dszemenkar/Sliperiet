using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sliperiet.Server.Interface;
using Sliperiet.Shared.Helpers;
using Sliperiet.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sliperiet.Server.Controllers
{
    public class AuthController : BaseApiController
    {
        private readonly IAuthInterface _authRepo;

        public AuthController(IAuthInterface authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegister request)
        {
            var response = await _authRepo.Register(
                new AppUser
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email,
                    DateOfBirth = request.DateOfBirth,
                    IsConfirmed = request.IsConfirmed
                },
                request.Password);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLogin request)
        {
            var response = await _authRepo.Login(
                request.Email, request.Password);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
