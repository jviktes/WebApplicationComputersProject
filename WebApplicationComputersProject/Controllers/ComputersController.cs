using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplicationComputersProject.Models;
using WebApplicationComputersProject.Services;

namespace WebApplicationComputersProject.Controllers
{
        [Authorize]
        [ApiController]
        [Route("[controller]")]
        public class ComputersController : Controller
        {

        private readonly ILogger<ComputersController> _logger;

        public ComputersController(ILogger<ComputersController> logger)
        {
            _logger = logger;
        }

        [Route("Index")]
        [HttpGet()]
        public IActionResult Index()
        {
            List<Computer> data = new List<Computer>();
            DataServices dataServices = new DataServices();
            data = dataServices.GetComputers();

            return View("~/Views/Computers/Index.cshtml", data);
        }

        [Route("Details/{computerId:int}/")]
        [HttpGet()]
        public IActionResult Details(int computerId)
        {
        //TODO metoda na vyber podle ID z fakeDat..
            WebApplicationComputersProject.Models.Computer computer = new Computer() { ComputerDomain="ff", ComputerId=5, ComputerName="pc"};
            return View("~/Views/Computers/Details.cshtml", computer);//
        }


        //[HttpGet()]
        [HttpPost]
        [Authorize]
        [Route("UpdatePlannedMigrationDate/{computerId:int}/")]
        public ActionResult UpdatePlannedMigrationDate(int computerId) 
        {

            //TODO pouzit roli!
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            //System.Web.Security.Roles.GetRolesForUser();
            if (User.IsInRole("External"))
            {

            }

            var _data = HttpContext.Request.Form["data"].ToString();

            //parsing datumu:
            if (!DateTime.TryParse(_data, out DateTime date)) {
                return Json(new { result = "ERROR" }); //TODO html bad request
            }
            //save to DB
            return Json(new { result = "OK" }); //TODO html 200
        }

    }
}