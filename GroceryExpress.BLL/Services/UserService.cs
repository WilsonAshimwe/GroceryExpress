﻿using GroceryExpress.BLL.Infrastructures;
using GroceryExpress.BLL.Interfaces;
using GroceryExpress.DOMAIN.Entities;

namespace GroceryExpress.BLL.Services
{
    public class UserService(IUserRepository _userRepository, PasswordHasher _passwordHasher)
    {
        public async Task<User> Add(string firstname, 
                           string lastname,
                           string username,
                           string email,
                           string password,
                           string phonenumber,
                           DateOnly birthdate,
                           string street,
                           string number,
                           string? box,
                           string city,
                           int postalcode)
        {
            byte[] hashedPassword = _passwordHasher.Hash(email + password);


            Address address = new Address()
            {
                Street = street,
                Number = number,
                Box = box,
                City = city,
                PostalCode = postalcode

            };

            return await _userRepository.Add(

                new User()
                {
                    FirstName = firstname,
                    LastName = lastname,
                    Username = username,
                    Email = email,
                    Password = hashedPassword,
                    PhoneNumber = phonenumber,
                    BirthDate = birthdate,
                    Address = address,
                }

);

        }

        public async Task<User> Get(int id)
        {
            User? user = await _userRepository.Find(id);
            if (user == null)
            {
                throw new KeyNotFoundException($"There is no user with id {id}");
            }
            return user;
        }

        public async Task<List<User>> GetAll()
        {
            return await _userRepository.FindAll();
        }

        public async Task<User> GetWithAddress(int id)
        {
            User? user = await _userRepository.FindWithAddress(id);
            if (user == null)
            {
                throw new KeyNotFoundException($"There is no user with id {id}");
            }
            return user;
        }
        public async Task<User> GetWithOrders(int id)
        {
            User? user = await _userRepository.FindWithOrders(id);
            if (user == null)
            {
                throw new KeyNotFoundException($"There is no user with id {id}");
            }
            return user;
        }

        public async Task Delete(int id)
        {

            User? user = await _userRepository.Find(id);
            if (user == null)
            {
                throw new KeyNotFoundException($"There is no user with id {id}");
            }
            await _userRepository.Delete(user);



        }

        public async Task<User> Update(int id,
                           string firstname,
                           string lastname,
                           string username,
                           string email,
                           string password,
                           string phonenumber,
                           DateOnly birthdate,
                           string street,
                           string number,
                           string? box,
                           string city,
                           int postalcode)
        {

            User? user = await _userRepository.Find(id);
            if (user is null)
            {
                throw new KeyNotFoundException($"the user with {id} cannot be found");
            };
            byte[] hashedPassword = _passwordHasher.Hash(email + password);

            user.FirstName = firstname;
            user.LastName = lastname;
            user.Username = username;
            user.Email = email;
            user.Password= hashedPassword;
            user.PhoneNumber = phonenumber;
            user.BirthDate = birthdate;
            user.Address.Street = street;
            user.Address.Number = number;
            user.Address.Box = box;
            user.Address.City = city;
            user.Address.PostalCode = postalcode;

            return await _userRepository.Update(user);

        }


    }
}
