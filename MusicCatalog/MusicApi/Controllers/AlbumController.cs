using Microsoft.AspNetCore.Mvc;

namespace MusicApi.Controllers
{
    public class AlbumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
