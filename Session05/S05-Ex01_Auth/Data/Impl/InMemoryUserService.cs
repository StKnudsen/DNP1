using System;
using System.Collections.Generic;
using System.Linq;
using S05_Ex01_Auth.Models;

namespace S05_Ex01_Auth.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;

        public InMemoryUserService() {
            users = new[] {
                new User {
                    City = "Horsens",
                    Domain = "via.dk",
                    Password = "password",
                    Role = "Studen",
                    BirthYear = 1986,
                    SecurityLevel = 5,
                    UserName = "Stefan"
                },
                new User {
                    City = "Aarhus",
                    Domain = "hotmail.com",
                    Password = "password",
                    Role = "Student",
                    BirthYear = 1998,
                    SecurityLevel = 3,
                    UserName = "Tina"
                },
                new User {
                    City = "Vejle",
                    Domain = "via.com",
                    Password = "password",
                    Role = "Guest",
                    BirthYear = 1990,
                    SecurityLevel = 1,
                    UserName = "Line"
                }
            }.ToList();
        }


        public User ValidateUser(string userName, string password) {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null) {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password)) {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}