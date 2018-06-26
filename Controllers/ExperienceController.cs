using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace cv_site_mvc.Controllers
{
    public class ExperienceController : Controller
    {
        // 
        // GET: /Experience/

        public IActionResult Index()
        {
            return View();
        }

    }
}