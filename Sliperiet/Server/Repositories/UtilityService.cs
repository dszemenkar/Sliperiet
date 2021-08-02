using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Sliperiet.Server.Data;
using Sliperiet.Server.Interface;
using Sliperiet.Shared.Models;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Sliperiet.Server.Repositories
{
    public class UtilityService : IUtilityInterface
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UtilityService(DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<AppUser> GetUser()
        {
            var userId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
            var user = await _context.AppUsers.Include(x => x.AppUserRoles).FirstOrDefaultAsync(x => x.Id == userId);
            return user;
        }
    }
}

