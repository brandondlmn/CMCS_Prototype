using Microsoft.AspNetCore.Mvc;

namespace CMCS_Prototype.Controllers
{
    public class ClaimController : Controller
    {
        public IActionResult Submit()
        {
            return View(); // Claim submission page
        }

        public IActionResult Reports()
        {
            return View(); // Reports page
        }
    }//end of class
}//end of namespace
