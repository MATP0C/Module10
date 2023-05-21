using System;

namespace Module10
{
    class Program
    {
        static void Main()
        {
            var user = new User();
            var account = new Account();

            IUpdater<Account> updater = new UserService();

            var userService = new UserService();
            userService.Update(user);
            Console.ReadKey();
        }
    }
    public class User
    {

    }

    public class Account : User
    {

    }

    public interface IUpdater<in User>
    {
        void Update(User entity);
    }

    public class UserService : IUpdater<User>
    {
        public void Update(User entity)
        {

        }
    }
}