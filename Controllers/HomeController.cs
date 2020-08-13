using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ChefsDishes.Models;

namespace ChefsDishes.Controllers
{
    public class HomeController : Controller{
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("allchefs")]
        public IActionResult AllChefs()
        {
            List<Chef> ChefWithDishes = dbContext.Chefs
            .Include(Chef=> Chef.ThisChefsDishes)
            .ToList();
            return View(ChefWithDishes);
        }
        
        
        [HttpGet("alldishes")]
        public IActionResult AllDishes()
        {
            List<Dish> DishesWithChef = dbContext.Dishes
            .Include(dish=>dish.Creator)
            .ToList();
            return View(DishesWithChef);
        }

        [HttpGet("addchef")]
        public ViewResult AddChef()
        {
            return View();
        }

        [HttpGet("adddish")]
        public ViewResult AddDish()
        {
            List<Chef> allChef = dbContext.Chefs.ToList();
            NewDishModel newdish = new NewDishModel();
            newdish.allchefs = allChef;
            return View("adddish", newdish);
        }

        [HttpPost("addchef")]
        public IActionResult NewChef(Chef newChef)
        {
            if(!ModelState.IsValid)
            {
                return View("addchef", newChef);
            }
            else
            {
                DateTime now = DateTime.Today;
                if (DateTime.Compare( now,newChef.DateOfBirth) < 0)
                {
                    ModelState.AddModelError("DateOfBirth", "DOB must earlier than current date");
                    return View("NewChef");
                }
                else
                {
                    int age = now.Year - newChef.DateOfBirth.Year;
                    if(age<18)
                    {
                        ModelState.AddModelError("DateOfBirth", "A chef  must older than 18");
                        return View("NewChef");
                    }
                    else
                    {
                        dbContext.Chefs.Add(newChef);
                        dbContext.SaveChanges();
                        return RedirectToAction("allchefs");
                    }
                }
            }
        }
    
        [HttpPost("adddish")]
        public IActionResult NewDish(NewDishModel newdishmodel)
        {
            if (!ModelState.IsValid)
            {
                List<Chef> allChef = dbContext.Chefs.ToList();
                NewDishModel newdish = new NewDishModel();
                newdish.allchefs = allChef;
                return View("adddish", newdish);
            }
            else
            {
                Dish newdish = new Dish();
                newdish.Name = newdishmodel.Name;
                newdish.ChefId = newdishmodel.ChefId;
                newdish.Description = newdishmodel.Description;
                newdish.Calories = newdishmodel.Calories;
                newdish.Tastiness = newdishmodel.Tastiness;

                dbContext.Dishes.Add(newdish);
                dbContext.SaveChanges();
                return RedirectToAction("alldishes");
            }
        }
    
    
    }
}