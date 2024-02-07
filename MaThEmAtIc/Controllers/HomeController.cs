using MaThEmAtIc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MaThEmAtIc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public MaThDbContext _context;


        public HomeController(ILogger<HomeController> logger, MaThDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Authorize(LoginModel model)
        {
            var user = _context.Users.FirstOrDefault(x => x.Login.Equals(model.Login));
            if (user == null) 
            {
                model.Result = "Такого пользователя не существует";
                return View("Login", model);
            }
            if (!user.Password.Equals(model.Password))
            {
                model.Result = "Вы ввели неверный пароль";
                return View("Login", model);
            }
            if (user.RoleId == 1)
            {
                return View("Index", model);
            }
            if (user.RoleId == 2)
            {
                return View("Index", model);
            }
            return View();
        }

        public IActionResult NewUser()
        {
            return View("Register");
        }

        public IActionResult Register(RegisterModel model)
        {
            User user = new User()
            {
                Login = model.Login,
                Password = model.Password,
                RoleId = 2
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            return View("Login");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FOS()
        {
            return View("FOS");
        }

        public IActionResult Homework()
        {
            return View("Homework");
        }

        public IActionResult Lectures()
        {
            return View("Lectures");
        }

        public IActionResult RPD()
        {
            return View("RPD");
        }

        public IActionResult Login()
        {
            return View("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
