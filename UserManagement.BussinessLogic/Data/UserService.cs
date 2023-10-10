using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.BussinessLogic.Interfaces;
using UserManagementDataAccessLayer.Interfaces;
//using UserManagementDataAccessLayer.Interfaces;
using UserManagementModels.Models;

namespace UserManagement.BussinessLogic.Data
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User GetUserById(int id)
        {
            var user = _userRepository.GetUserById(id);
            return user; 
        }
        //public void AddUser(User user)
        //{
        //    _userRepository.AddUser(user);
        //}

        // Implement other methods.
    }
}
