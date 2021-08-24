using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCMovie.Controllers
{
    public class MoviesController : Controller
    {
        /*GET: /Movie/
         * Returns a string
         */
        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        // GET: /Movie/
        // Action Method
        public IActionResult Index()
        {
            // Calls controller's View Method. 
            return View();
        }

        /* GET: /Movie/Admin/
         * Requires using System.Text.Encodings.Web;
         * Access URL: https://localhost:5001/Movies/Admin?username=Yifan&userID=7
         * */
        //public string Admin(string username, int userID = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello, {username}, your user ID is: {userID}");
        //}

        /* GET: /Movie/Admin/
         * Requires using System.Text.Encodings.Web;
         * Changes the parameter matching to default routing logic parameter
         * Access URL: https://localhost:5001/Movies/Admin/7?username=Yifan
         * Returns a string
         */
        //public string Admin(string username, int ID = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello, {username}, your user ID is: {ID}");
        //}


        // GET: /Movie/Admin/
        // Action Method
        public IActionResult Admin(string username, int userID = 1)
        {
            ViewData["Username"] = "Username:" + username;
            ViewData["UserID"] = "User ID: "+ userID;

            return View();
        }


    }
}
