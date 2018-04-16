using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;


namespace CarDealership.Controllers
{
    public class HomeController : Controller
    {
        //public string Hello() { return "Hello friend!"; }
        [Route("/")]
        public ActionResult RunCar()
        {
          return CarProgram();
        }
    }
}
