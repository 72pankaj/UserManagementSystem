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
        [HttpGet]
        public IActionResult Index()                    
        {
            //IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            var users = _userService.GetAllUsers();
            return View(users);
        }

        [HttpGet]
        public IActionResult GetUserById(int id)
        {
            var user = _userService.GetUserById(id);
            return View(user);
        }
    }
}
