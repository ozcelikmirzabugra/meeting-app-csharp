using System.Runtime.CompilerServices;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers {
    public class HomeController : Controller {
        // localhost
        // localhost/home
        // localhost/home/index
        public IActionResult Index() {
            int clock = DateTime.Now.Hour;
            // ViewBag.salute = clock > 12 ? "Have a nice days" : "Morning";
            // ViewBag.username = "Mirza";

            ViewData["Salute"] = clock > 12 ? "Have a nice days" : "Morning";
            // ViewData["Username"] = "Mirza";
            int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();


            var meetingInfo = new MeetingInfo() {
                Id = 1,
                Location = "Ankara, Etimesgut",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = UserCount
            };
            return View(meetingInfo);
        }
    }
}