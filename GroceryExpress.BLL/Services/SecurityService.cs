using GroceryExpress.BLL.Infrastructures;
using GroceryExpress.BLL.Interfaces;
using GroceryExpress.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryExpress.BLL.Services
{
    public class SecurityService(ILoginRepository _loginRepository, PasswordHasher _passwordHasher)
    {
        public async Task<User> Login(string  email, string password) { 
        
        User? user = await _loginRepository.GetByEmail(email);

            if(user == null) {
                throw new ValidationException("No user with that email");
            }
            if (!_passwordHasher.Hash(user.Email + password).SequenceEqual(user.Password))
            {
                throw new ValidationException("The password is not valide");
            }
            return user;

        }
    }
}
