using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
// my using statements
using System.Linq;
using cmDemo.Models;
using cmDemo.ActionFilters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace cmDemo.Controllers
{
    public class DemoController : Controller
    {
        // ########## ROUTES ##########
        //  /
        //  /(add_routes_guide)
        //  /
        // ########## ROUTES ##########

        // Dapper connections
        // private readonly UserFactory userFactory;
        // private readonly DbConnector _dbConnector;

        // Entity PostGres Code First connection
        private CmDemoContext _context;

        public DemoController(CmDemoContext context)
        {
            // Dapper framework connections
            // _dbConnector = connect;
            // userFactory = new UserFactory();

            // Entity Framework connections
            _context = context;
        }

        // GET: /Home/
        [HttpGet]
        [Route("")]
        [ImportModelState]
        public IActionResult Index()
        {
            return View();
        }

    }
}
