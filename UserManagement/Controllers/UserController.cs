using Microsoft.AspNetCore.Mvc;
using UserManagement.BussinessLogic.Interfaces;

namespace UserManagement.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()                    
        {
            var users = _userService.GetAllUsers();
            return View(users);
        }

        public IActionResult GetUserById(int id)
        {
            var user = _userService.GetUserById(id);
            return View(user);
        }
    }
}
