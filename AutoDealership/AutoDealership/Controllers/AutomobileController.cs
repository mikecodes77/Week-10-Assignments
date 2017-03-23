using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoDealership.Models;

namespace AutoDealership.Controllers
{
    public class AutomobileController : Controller
    {
        // GET: Automobile
        public ActionResult Index()
        {
            //var automobile = from e in GetAutomobileList()
            //                 orderby e.ID
            //                 select e;

            var automobile = from e in autoList
                             orderby e.ID
                             select e;




            return View(automobile);
        }

        // GET: Automobile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Automobile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Automobile/Create
        [HttpPost]
        public ActionResult Create(Automobile auto)
        {
            try
            {
                // TODO: Add insert logic here
                autoList.Add(auto);


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Automobile/Edit/5
        public ActionResult Edit(int id)
        {
            List<Automobile> autolist = GetAutomobileList();
            var automobile = autoList.Single(m => m.ID == id);
            return View();
        }

        // POST: Automobile/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var automobile = autoList.Single(m => m.ID == id);
                if (TryUpdateModel(automobile))
                {
                    return RedirectToAction("Index");
                }
                return View(automobile);
            }
            catch
            {
                return View();
            }
        }

        // GET: Automobile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Automobile/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [NonAction]
        public List<Automobile> GetAutomobileList()
        {
            return new List<Automobile>
            {
                new Automobile
            {
                ID = 1,
                Make = "Dodge",
                Model = "Charger",
                Year = 2017,
                Color = "Black",
                },

                new Automobile
                {
                ID = 2,
                Make = "Ford",
                Model = "Mustang",
                Year = 2017,
                Color = "Red",
                },

                new Automobile
                {
                ID = 3,
                Make = "Pontiac",
                Model = "GTO",
                Year = 2017,
                Color = "Green",
                },

                new Automobile
                {
                ID = 4,
                Make = "Lincoln",
                Model = "Navigator",
                Year = 2017,
                Color = "Blue",
                },

        };
        }
    
    public static List<Automobile> autoList = new List<Automobile>
    {
        new Automobile
        {
            ID = 1,
                Make = "Dodge",
                Model = "Charger",
                Year = 2017,
                Color = "Black",
                },
        new Automobile
        {
            ID = 2,
                Make = "Ford",
                Model = "Mustang",
                Year = 2017,
                Color = "Red",
                },
        new Automobile
        {
            ID = 3,
                Make = "Pontiac",
                Model = "GTO",
                Year = 2017,
                Color = "Green",
                },
        new Automobile
        {
            ID = 4,
                Make = "Lincoln",
                Model = "Navigator",
                Year = 2017,
                Color = "Blue",
                },



        };
        //public ActionResult Index()
        //{
        //    var automobile = from e in autoList
        //                     orderby e.ID
        //                     select e;
        //    return View(automobile);
        //}
}
}




