using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementModels.Models;

namespace UserManagementDataAccessLayer.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        void AddUser(User user);
    }
}
