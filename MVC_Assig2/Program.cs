using Microsoft.AspNetCore.Routing.Constraints;

namespace MVC_Assig2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //notes
            //Routing :process of mapping incoming requests to controller actions or endpoints
            //has two types : conventional routing and attribute routing
            // /x{name}=>mixed
            // //{name}=>variable
            // bydefault بتكون ال ميثود get لو عاوز حاجه تاني بتكتبها [HttpPost], [HttpPut]...
            //constraints : to restrict the values that a route parameter can take
            //view result : return View(); => return html file
            //content result : return Content => return string
            //contentResult and badrequest and notfound are implemented from IActionResult
            //content type : text/html, text/plain
            //redirection : RedirectToAction, RedirectToRoute
            //RedirectToAction : redirect to action in controller
            //RedirectToRoute : redirect to specific route
            //model binding : automatically mapping data from request to action method
            
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseStaticFiles();
            app.MapGet("/", () => "Hello World!");

            //app.MapGet("/{name}", async context =>
            //{
            //    var name = context.Request.RouteValues["name"];
            //    await context.Response.WriteAsync($"Hello, {name}!");
            //});
            //GetMovie?id=10&name=netflex
            app.MapControllerRoute(
                name: "default", constraints: new { id = new IntRouteConstraint() },
                pattern: "{controller=Movie}/{action=GetMovie}/{id?}"
                );

            app.Run();
        }
    }
}
