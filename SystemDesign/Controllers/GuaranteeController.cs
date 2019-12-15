using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using SystemDesign.Models;

namespace SystemDesign.Controllers
{
    public class GuaranteeController : Controller
    {
        public static List<Guarantee> Guarantees = new List<Guarantee>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Post(Guarantee guarantee)
        {
            if (ModelState.IsValid)
            {
                Guarantees.Add(guarantee);

                return new JsonResult("The guarantee added successfully");
            }
            else
            {
                return new JsonResult("The guarantee had errors");
            }
        }

        public IActionResult Get()
        {
            return new JsonResult(Guarantees);
        }

        public IActionResult GetById(int id)
        {
            return new JsonResult(Guarantees.Where(p => p.Id == id).FirstOrDefault());
        }
    }
}
