namespace PokeDex.Contracts.Exceptions
{
    public class UserAuthenticationException : Exception
    {
        public UserAuthenticationException(String message) : base(message)
        {
        }
    }
}
