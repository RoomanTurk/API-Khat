using Microsoft.AspNetCore.Mvc;
using API_Khat.Models;
namespace API_Khat.Controllers
{
    public class APIController : ControllerBase
    {
        APP app = new APP();
        public IActionResult Index()
        {
            app.A();
            app.B();
            return Ok($"Point A In Line = [ {app.isOnLineA} ]\nPoint B In Line = [ {app.isOnLineB} ]");
        }
    }
}
