using Microsoft.Extensions.DependencyInjection;
using Pappion.Application.Admin.Users;

namespace Pappion.Application.Admin
{
  public static class AdminSideDependencyInjection
  {
    public static IServiceCollection AddAdminSide(this IServiceCollection service)
    {
      service.AddScoped<IUserService, FakeUserService>();

      return service;
    }
  }
}
