using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementModels.Models;

namespace UserManagement.BussinessLogic.Interfaces
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        void AddUser(User user);

        User GetUserById(int id);
        // Add other methods for user management.
    }
}
