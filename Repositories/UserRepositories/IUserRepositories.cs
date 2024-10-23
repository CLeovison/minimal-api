using User.Api.Contracts.Data;

namespace User.Api.Repositories;

public interface IUserRepositories
{
    //
    Task<bool> CreateUserAsync(UserDto user);
    Task<bool> GetUserById();
    Task<IEnumerable<UserDto>> GetAllUser();
    Task<bool> DeleteUser(Guid id);
    Task<bool> UpdateUser(UserDto user);
}