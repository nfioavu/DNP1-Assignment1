using System;
using System.Collections.Generic;
using System.Linq;
using Assignment1;
using Assignment1.Data;
using Microsoft.AspNetCore.Identity;


namespace SimpleSetup.Data
{
    public class UserService : IUserService
    {
        private List<User> users;

        public UserService()
        {
            users = new[]
            {
                new User
                {
                    Role = "admin",
                    Password = "123456",
                    SecurityLevel = 4, 
                    UserName = "Troels"
                },
                new User
                {
                    Role = "not admin",
                    Password = "654321",
                    SecurityLevel = 2, 
                    UserName = "Jakob"
                }
            }.ToList();

        }
        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception(("User not found"));
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}