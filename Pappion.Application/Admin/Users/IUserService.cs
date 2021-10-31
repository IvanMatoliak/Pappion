using System.Threading.Tasks;
using Pappion.Domain.Entities;

namespace Pappion.Application.Admin.Users
{
  public interface IUserService
  {
    Task<User[]> GetAllAsync();
  }
}