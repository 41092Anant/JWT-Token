namespace JWT.Data
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string username, string password);
    }
}
