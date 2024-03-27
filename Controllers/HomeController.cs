using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController:Controller{

        public IActionResult Index(){
            ViewBag.Ad="Alperen";
            int UserCount = Repository.Users.Where(i=>i.WillAttend==true).Count();
            
            MeetingInfo meeting = new() {
                Id = 1,
                Date =new DateTime(2024,12,7,08,30,0),
                Location = "İzmir",
                NumberOfPeople = UserCount
            };
            return View(meeting);
        }
    }
    
}