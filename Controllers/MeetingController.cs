using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController:Controller{
        
        [HttpGet]
        public IActionResult Apply(){
            return View();
        }
        [HttpPost]
        public IActionResult Apply(UserInfo userInfo){
            if(ModelState.IsValid){
            Repository.CreateUser(userInfo);
            ViewBag.UserCount = Repository.Users.Where(i=>i.WillAttend==true).Count();
            return View("Thanks",userInfo);
            }
            else{
                return View(userInfo);
            }
        }
        public IActionResult List(){
        
            return View(Repository.Users);
        }
        //meeting/details/id
        public IActionResult Details(int id){
            return View(Repository.getById(id));
        }
    }
}