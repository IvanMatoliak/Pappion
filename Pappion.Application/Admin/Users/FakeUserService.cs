using System;
using System.Threading.Tasks;
using Bogus;
using Pappion.Domain.Entities;

namespace Pappion.Application.Admin.Users
{
  public class FakeUserService : IUserService
  {
    public Task<User[]> GetAllAsync()
    {
      var fake = new Faker<User>()
        .RuleFor(p => p.Id, f => Guid.NewGuid())
        .RuleFor(p => p.Username, f => f.Internet.UserName())
        .RuleFor(p => p.FirstName, f => f.Name.FirstName())
        .RuleFor(p => p.LastName, f => f.Name.LastName())
        .RuleFor(p => p.Avatar, f => f.Internet.Avatar())
        .RuleFor(p => p.Email, f => f.Internet.Email())
        .RuleFor(p => p.PhoneNumber, f => f.Phone.PhoneNumber());

      return Task.FromResult(fake.Generate(10).ToArray());
    }
  }
}
