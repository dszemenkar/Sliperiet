using Sliperiet.Shared.Helpers;
using Sliperiet.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sliperiet.Server.Interface
{
    public interface IAuthInterface
    {
        Task<ServiceResponse<int>> Register(AppUser appUser, string password);
        Task<ServiceResponse<string>> Login(string email, string password);
        Task<bool> UserExists(string email);
    }
}
