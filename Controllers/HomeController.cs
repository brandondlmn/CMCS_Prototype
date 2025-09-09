using Microsoft.AspNetCore.Mvc;

namespace CMCS_Prototype.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Login page
        }

        public IActionResult LecturerDashboard()
        {
            return View(); // Lecturer dashboard
        }

        public IActionResult CoordinatorDashboard()
        {
            return View(); // Coordinator dashboard
        }

        public IActionResult ManagerDashboard()
        {
            return View(); // Manager dashboard
        }
    }//end of class
}//end of namespace