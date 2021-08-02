using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sliperiet.Server.Data;
using Sliperiet.Server.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sliperiet.Server.Controllers
{
    [Authorize]
    public class UserController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly IUtilityInterface _utility;

        public UserController(DataContext context, IUtilityInterface utility)
        {
            _context = context;
            _utility = utility;
        }

        [HttpGet]
        public async Task<IActionResult> GetCurrentAppUser()
        {
            var user = await _utility.GetUser();
            return Ok(user);
        }
    }
}
