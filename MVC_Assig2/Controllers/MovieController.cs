using Microsoft.AspNetCore.Mvc;

namespace MVC_Assig2.Controllers
{
    public class MovieController : Controller
    {
        public string Index()
        {
            return "Hello index";
        }
        [HttpGet]
        public IActionResult GetMovie(int? id, string name)
        {
            //return Content($"Movie ID: {id}, Movie Name: {name}");
            if (id == 0)
            {
                return BadRequest();
            }
            else if (id <10)
            {
                return NotFound();
            }
            else
            {
                ContentResult result = new ContentResult();
                result.Content = $"Movie ID: {id}</br> Movie Name: {name}";
                result.ContentType = "text/html";//textplain
                return result;
            }
        }
        public IActionResult ReditectTest()
        {
            return RedirectToAction(nameof(GetMovie),"Movie", new { id = 11, name = "youtube" });
            //return RedirectToRoute("default", new { controller = "Movie", action = "GetMovie"});
        }
        //Movie/test?arr[0]=10&arr[1]=11&arr[2]=12
        public IActionResult test(int[] arr)
        {
            return Content(string.Join(",", arr));
        }
 

    }
}