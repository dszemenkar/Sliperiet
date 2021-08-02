using Sliperiet.Shared.Helpers;
using Sliperiet.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sliperiet.Client.Interfaces
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(UserRegister request);
        Task<ServiceResponse<string>> Login(UserLogin request);
        Task<AppUser> GetCurrentAppUser();
    }
}
