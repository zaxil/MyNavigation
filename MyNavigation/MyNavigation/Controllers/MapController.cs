using System;
using System.Collections.Generic;
System.Data.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyNavigation.Models;

namespace MyNavigation.Controllers
{
    public class MapController : Controller
    {
        static NavigationDatabaseEntities entities = new NavigationDatabaseEntities();

        // GET: Map
        public ActionResult Index()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(FormCollection form)
        {
            if(ModelState.IsValid)
            {
                int newRouteId = 0;
                if(entities.Addresses.Count() >0)
                {
                    newRouteId = (from address in entities.Addresses where address.TraceId != null select address.TraceId).Max();
                }
                ++newRouteId;

                Address newRoute = Address.CreateAddress(newRouteId);

                newRoute.DeparturePlace = form["departurePlace"].ToString();
                newRoute.DestinationPlace = form["destinationPlace"].ToString();
                newRoute.CreateDate = DateTime.Now;

                entities.AddToAddresses(newRoute);

                entities.SaveChanges();
                return View(newRoute);
            }
            return View();
        }
        public ActionResult Transfer()
        {
            List<int> Digits = new List<int>();
            for(int i = 0; i<10; i++)
            {
                Digits.Add(i);
            }

            //ViewData
            ViewData["First name"] = "John";
            ViewData["Last name"] = "Wick";
            ViewData["Digits"] = Digits;

            //ViewBag
            ViewBag.First_name = "Albert";
            ViewBag.Last_name = "Einstein";
            ViewBag.Digits = Digits;

            return View();
        }
    }
}