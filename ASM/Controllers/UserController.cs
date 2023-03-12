using ASM.Configurations;
using ASM.Models;
using ASM.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ASM.Controllers
{
    public class UserController : Controller
    {
        public UserController()
        {
            
        }
        private AsmDbContext AsmDbContext { get; set; } = new AsmDbContext();
        public IActionResult Index()
        {
           var lst = AsmDbContext.Users.ToList().FirstOrDefault();
            ViewData["Account"] = new UserVM()
            {
                Name = lst.Name,
                PassWord = lst.PassWord,
                RoleID = lst.RoleID,
                Status = lst.Status,
                UserID = lst.UserID,
            }; ;
            return View();
        }
    }
}
