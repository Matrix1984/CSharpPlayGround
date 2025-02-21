using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPractice.Repository.Deposits;

namespace CPractice.Repository.Users
{
    public class UserRepository
    {
        public IList<User> Users()
        {
            List<User> users = new List<User>();

            var user1= new User();

            user1.Id = 1;

            user1.Name= "Test user";

            user1.DOb = new DateTime(2001, 1, 2);

            user1.Description = "new user";

            user1.Deposits = new List<Deposit>();

            var deposit1= new Deposit();

            deposit1.Id = 1;

            deposit1.Amount = 200;
            
            user1.Deposits.Add(deposit1);


            users.Add(user1);


            var user2 = new User();

            user2.Id = 2;

            user2.Name = "Shlomi";

            user2.DOb = new DateTime(2000, 1, 2);

            user2.Description = "problematic user";


            user2.Deposits = new List<Deposit>();

            var deposit2 = new Deposit();

            deposit2.Id = 2;

            deposit2.Amount = 100;

            user1.Deposits.Add(deposit2);


            var deposit3 = new Deposit();

            deposit3.Id = 3;

            deposit3.Amount = 10;

            user2.Deposits.Add(deposit3);

            users.Add(user2); 


            var user3 = new User();

            user3.Id = 3;

            user3.Name = "Moshe";

            user3.DOb = new DateTime(1984, 4, 7);

            user3.Description = "homeless user";


            user2.Deposits = new List<Deposit>();

            var deposit5 = new Deposit();

            deposit5.Id = 5;

            deposit5.Amount = 1000;

            user3.Deposits.Add(deposit5);


            var deposit6 = new Deposit();

            deposit6.Id = 6;

            deposit6.Amount = 1220;

            user3.Deposits.Add(deposit6);

            users.Add(user3);


            var user4 = new User();

            user4.Id = 4;

            user4.Name = "Shlomit";

            user4.DOb = new DateTime(1984, 4, 7);

            user4.Description = "Manipulative female";

            users.Add(user4);



            var user5 = new User();

            user5.Id = 5;

            user5.Name = "Dan";

            user5.DOb = new DateTime(1984, 4, 23);

            user5.Description = "Programmer";

            users.Add(user5);



            var user6 = new User();

            user6.Id = 6;

            user6.Name = "Maoz";

            user6.DOb = new DateTime(1984, 4, 23);

            user6.Description = "Security worker";

            users.Add(user5);



            var user7 = new User();

            user7.Id = 7;

            user7.Name = "Nurit";

            user7.DOb = new DateTime(1994, 11, 6);

            user7.Description = "Secretary";

            users.Add(user7);


            var user8 = new User();

            user8.Id = 8;

            user8.Name = "Nurit";

            user8.DOb = new DateTime(1974, 2, 2);

            user8.Description = "Secretary";

            users.Add(user8);



            var user9 = new User();

            user9.Id = 9;

            user9.Name = "Nurit";

            user9.DOb = new DateTime(1974, 2, 2);

            user9.Description = "Secretary";

            users.Add(user9);


            var user10 = new User();

            user10.Id = 10;

            user10.Name = "Haim";

            user10.DOb = new DateTime(1964, 1, 1);

            user10.Description = "Baker";

            users.Add(user10);

            return users;
        }
    }
}
