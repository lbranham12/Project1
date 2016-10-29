using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionSite.Controllers
{
    public class MissionsController : Controller
    {
        // GET: Missions
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MissionFAQs(string missionName)
        {
            if (missionName == "Barcelona"){
                ViewBag.MissionName = "Spain Barcelona Mission";
                ViewBag.PresName = "President Merrill T. Dayton";
                ViewBag.MissionAddress= "Calle Calatrava No 10-12, bajos Barcelona, 08017 Barcelona Spain";
                ViewBag.MissionLanguage = "Spanish";
                ViewBag.MissionClimate = "Subtropical-Mediterranean Climate";
                ViewBag.MissionReligion = "Catholicism";
                ViewBag.MissionFlag = "../Content/Images/barcelonaflag.png";

            }
            else if (missionName == "Malaga")
            {
                ViewBag.MissionName = "Spain Malaga Mission";
                ViewBag.PresName = "President T. DarVel Andersen";
                ViewBag.MissionAddress = "Av. Jesus Santos Rein No 2,3 D-E Edif. Ofisol, Fuengirola 29640 Malaga, Spain";
                ViewBag.MissionLanguage = "Spanish";
                ViewBag.MissionClimate = "Subtropical-Mediterranean Climate";
                ViewBag.MissionReligion = "Catholicism";
                ViewBag.MissionFlag = "../Content/Images/Malaga.jpg";
            }
            else if (missionName == "Arcadia")
            {
                ViewBag.MissionName = "California Arcadia Mission";
                ViewBag.PresName = "President Moises Villanueva";
                ViewBag.MissionAddress = "614 West Foothill Blvd. Arcadia CA 91006-2030 USA";
                ViewBag.MissionLanguage = "Spanish or English";
                ViewBag.MissionClimate = "Mediterranean-like Climate";
                ViewBag.MissionReligion = "Catholicism";
                ViewBag.MissionFlag = "../Content/Images/califlag.png";
            }
            return View();
        }
    }
}