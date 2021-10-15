using S05_Ex02_AuthWithTailwind.Models;

namespace S05_Ex02_AuthWithTailwind.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
    }
}