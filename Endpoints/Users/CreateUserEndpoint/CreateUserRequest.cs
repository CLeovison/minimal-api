namespace UserApi.Request;

public record CreateUserRespose
{
    public string Username { get; init; } = default!;
    public string Password { get; init; } = default!;
    public string Firstname { get; init; } = default!;
    public string Lastname { get; init; } = default!;
    public string Email { get; init; } = default!;

}