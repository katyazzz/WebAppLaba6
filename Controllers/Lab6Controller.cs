using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppLaba6.Controllers
{
    public class Lab6Controller : Controller
    {
        public ActionResult FirstViewMethod()
        {
            List<string> vegetables = GetVegetablesList();
            return View(vegetables);
        }
        public ActionResult SecondViewMethod() { 
        return View(GetVegetablesList().OrderBy(x => x).ToList());
         
        }
        public ActionResult ThirdViewMethod() { 
            return View(GetVegetablesList().OrderBy(x => x).ToList());
        }
        // GET: Lab6

        public List<string> GetVegetablesList()
        {
            List<string> vegetables = new List<string>();
            vegetables.Add("Томат");
            vegetables.Add("Огурец");
            vegetables.Add("Картофель");
            vegetables.Add("Кабачок");
            vegetables.Add("Баклажан");
            vegetables.Add("Капуста");
            vegetables.Add("Брокколи");
            vegetables.Add("Черри");
            vegetables.Add("Лук");
            vegetables.Add("Редис");
            vegetables.Add("Хрен");

            return vegetables;
        }
    }
}