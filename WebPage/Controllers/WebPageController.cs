using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage.DataContexts;
using WebPage.Models;

namespace WebPage.Controllers
{
    public class WebPageController : Controller
    {
        private readonly ApplicationContect context;
        public WebPageController(ApplicationContect context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var result = context.webFroms.ToList();


            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(WebFrom model)
        {
            if (ModelState.IsValid) 
            {
                var rest = new WebFrom()
                {
                    Date = model.Date,
                    Name = model.Name,
                    Email=model.Email,
                    Mobile=model.Mobile,
                    Salary=model.Salary,
                    Location=model.Location,
                    Department=model.Department,
                };
                context.webFroms.Add(rest);
                context.SaveChanges();
                TempData["error"] = "Record Savedl";
                return RedirectToAction("Index");
            }
           else
            {
                TempData["massege"] = "Empty field can't  Submit";
                return View(model);
            }
        }
        public IActionResult Delete(int Id,WebFrom pro)
        {
            var rest = context.webFroms.SingleOrDefault(m => m.Id == Id);
            context.webFroms.Remove(rest);
            context.SaveChanges();
            TempData["error"] = "Record Deleted";
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int Id)
        {
            var res = context.webFroms.SingleOrDefault(m => m.Id == Id);
            var result = new WebFrom()
            {
               Date =res.Date ,
               Name=res.Name,
               Email=res.Email,
               Mobile=res.Mobile,
               Salary=res.Salary,
               Location=res.Location,
               Department=res.Department,
            };


            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(WebFrom model)
        {
            var rest = new WebFrom()
            {
                Id=model.Id,
              Date=model.Date,
              Name=model.Name,
              Email=model.Email,
              Mobile=model.Mobile,
              Salary=model.Salary,
              Location=model.Location,
              Department=model.Department,
            };
            context.webFroms.Update(rest);
            context.SaveChanges();
            TempData["errorM"] = "Record Edit";
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(UserRegistration model)
        {
            var rest = new UserRegistration()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Password=model.Password,
                ConfirmPassword=model.ConfirmPassword,       
        };
            context.UserRegistrations.Add(rest);
            context.SaveChanges();
            TempData["errorM"] = "Record Edit";
            return RedirectToAction("Index");
           
        }
    }
}
