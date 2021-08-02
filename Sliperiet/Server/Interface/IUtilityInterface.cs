using Sliperiet.Shared.Models;
using System.Threading.Tasks;

namespace Sliperiet.Server.Interface
{
    public interface IUtilityInterface
    {
        Task<AppUser> GetUser();
    }
}
