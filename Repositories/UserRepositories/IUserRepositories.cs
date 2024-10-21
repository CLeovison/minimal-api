using User.Api.Contracts.Data;

namespace User.Api.Repositories;

public interface IUserRepositories{
    Task<bool> CreateUserAsync(UserDto user);
    
}