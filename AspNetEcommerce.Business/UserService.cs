using AspNetEcommerce.Data;
using AspNetEcommerce.Data.Entity;

namespace AspNetEcommerce.Business
{
    public interface IUserService
    {
        List<User> GetAllUsers();
    }

    public class UserService : IUserService
    {
        public UserService(AppDbContext db)
        {
            Db = db;
        }

        public AppDbContext Db { get; }

        public List<User> GetAllUsers()
        {
            var users = Db.Users.ToList();

            return users;
        }
    }
}
