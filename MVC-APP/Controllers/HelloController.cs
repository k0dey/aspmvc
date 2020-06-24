using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVC_APP.Controllers
{
    public class HelloController : Controller
    {
        // localhost:44311/Hello/anythingWeWant
        // GET: /Hello/
        public IActionResult Index()
        {
            return View(); // Index() speaks to a file with the same name as our controller in the views folder
            // views/hello: by default it looks for index, just like any web server
            // view = the name of the method - if it matches the views/insertnamehere
        }

        public IActionResult About()
        {
            return View();
        }
        //// GET: /Hello/Wassup
        //public string Wassup() // sub-view of Hello controller
        //{
        //    return "Wasssupppp";
        //}

        //public string Demo(string name, int ID)
        //{
        //    //name = "Kerry";
        //    //ID = 1;
        //    return HtmlEncoder.Default.Encode($"Hello, {name}. Your ID number is {ID}.");
        //}

    }
}
