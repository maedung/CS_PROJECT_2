using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeltTest2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;


namespace BeltTest2.Controllers
{
    public class HomeController : Controller
    {
    private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("Register")]
        public IActionResult Register(User newuser)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.username == newuser.username);
                if(userInDb == null)
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newuser.password = Hasher.HashPassword(newuser, newuser.password);
                    dbContext.Users.Add(newuser);
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("username", "Username already in use!");
                return View("Index");
            }
            return View("Index");
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginUser user)
        {
            if(ModelState.IsValid)
            {
                var userindb = dbContext.Users.FirstOrDefault(u => u.username == user.login_username);
                if(userindb == null)
                {
                    ModelState.AddModelError("login_username", "Invalid Username/Password!");
                    return View("Index");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(user, userindb.password, user.login_password);
                if(result == 0)
                {
                    ModelState.AddModelError("login_username", "Invalid Email/Password");
                    return View("Index");
                }
                HttpContext.Session.SetInt32("userid", userindb.id);
                return RedirectToAction("HobbyPage");
            }
            return View("Index");
        }

        [HttpGet("Hobby")]
        public IActionResult HobbyPage()
        {
            if(HttpContext.Session.GetInt32("userid") == null)
            {
                ModelState.AddModelError("login_username", "Log In First!");
                return View("Index");
            }
            List<Hobby> Allhobbies = dbContext.Hobbies.Include(u => u.Hobbylist).ThenInclude(u => u.User).ToList();
            ViewBag.allhobby = Allhobbies;
            return View();
        }

        [HttpGet("Hobby/new")]
        public IActionResult NewHobby()
        {
            if(HttpContext.Session.GetInt32("userid") == null)
            {
                ModelState.AddModelError("login_username", "Log In First!");
                return View("Index");
            }
            return View();
        }

        [HttpPost("newhobby")]
        public IActionResult Posthobby(Hobby newhobby)
        {
            if(ModelState.IsValid)
            {
                Hobby test = dbContext.Hobbies.FirstOrDefault(u => u.name == newhobby.name);
                if(test != null)
                {
                    ModelState.AddModelError("name", "Name already exist!");
                    return View("NewHobby");
                }
                var creator = dbContext.Users.FirstOrDefault(u => u.id == HttpContext.Session.GetInt32("userid"));
                newhobby.Creator = creator;
                dbContext.Hobbies.Add(newhobby);
                dbContext.SaveChanges();
                return RedirectToAction("HobbyPage");
            }
            return View("NewHobby");
        }

        [HttpGet("Hobby/{id}")]
        public IActionResult HobbyDetail(int id)
        {
            var thisuser = dbContext.Users.FirstOrDefault(u => u.id == HttpContext.Session.GetInt32("userid"));
            ViewBag.thisuser = thisuser;
            Hobby thishobby = dbContext.Hobbies.Include(u => u.Hobbylist).ThenInclude(u => u.User).FirstOrDefault(a => a.id == id);
            ViewBag.thishobby = thishobby;
            return View(thishobby);
        }

        [HttpPost("Join")]
        public IActionResult JoinHobby(int userid, int hobbyid, string proficiency)
        {
            var thisuser = dbContext.Users.FirstOrDefault(u => u.id == HttpContext.Session.GetInt32("userid"));
            ViewBag.thisuser = thisuser;            
            Hobby thishobby = dbContext.Hobbies.Include(u => u.Hobbylist).ThenInclude(u => u.User).FirstOrDefault(u => u.id == hobbyid);
            ViewBag.thishobby = thishobby;            
            if(thishobby.Hobbylist.Any(u => u.userid == thisuser.id))
            {
                ModelState.AddModelError("name", "You are already in this Hobby!");
                return View("HobbyDetail",thishobby);
            }
            Enthusiast newone = new Enthusiast();
            newone.userid = userid;
            newone.hobbyid = hobbyid;
            newone.proficiency = proficiency;
            dbContext.Enthusiasts.Add(newone);
            dbContext.SaveChanges();
            return Redirect($"Hobby/{hobbyid}");
        }

        [HttpGet("Edit/{id}")]
        public IActionResult EditHobby(int id)
        {
            Hobby thishobby = dbContext.Hobbies.FirstOrDefault(u => u.id == id);
            User thisuser = dbContext.Users.FirstOrDefault(u => u.id == HttpContext.Session.GetInt32("userid"));
            ViewBag.thisuser = thisuser;
            return View(thishobby);
        }

        [HttpPost("Update/{id}")]
        public IActionResult UpdateHobby(int id, Hobby updatehobby, string description)
        {
            if(ModelState.IsValid)
            {
                Hobby test = dbContext.Hobbies.FirstOrDefault(u => u.name == updatehobby.name);
                if(test != null)
                {
                    ModelState.AddModelError("name", "Name already exist!");
                    Hobby ahobby = dbContext.Hobbies.FirstOrDefault(u => u.id == id);
                    User auser = dbContext.Users.FirstOrDefault(u => u.id == HttpContext.Session.GetInt32("userid"));
                    ViewBag.thisuser = auser;
                    return View("EditHobby",ahobby);
                }
                Hobby edithobby = dbContext.Hobbies.FirstOrDefault(u => u.id == id);
                edithobby.name = updatehobby.name;
                edithobby.description = description;
                dbContext.SaveChanges();
                return RedirectToAction("HobbyPage");
            }
            Hobby thishobby = dbContext.Hobbies.FirstOrDefault(u => u.id == id);
            User thisuser = dbContext.Users.FirstOrDefault(u => u.id == HttpContext.Session.GetInt32("userid"));
            ViewBag.thisuser = thisuser;
            return View("EditHobby",thishobby);
        }


        public IActionResult Privacy()
        {
            return View();
        }

    }
}
