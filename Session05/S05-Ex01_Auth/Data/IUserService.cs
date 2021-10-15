using S05_Ex01_Auth.Models;

namespace S05_Ex01_Auth.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
    }
}