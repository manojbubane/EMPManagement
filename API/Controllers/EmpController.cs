using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Microsoft.AspNetCore.Mvc;
using API.Models;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api4/[controller]")]
   // [Route("API/[]")]
    public class EmpController : ControllerBase
    {
        private readonly EmpContext _context;
        public EmpController(EmpContext context)
        {
            _context = context;

        }

        [HttpGet]

        public async Task<ActionResult<List<PersonalInfo>>> getEmployees()
        {
            var emp =await _context.PersonalInfos.ToListAsync();
            return Ok(emp);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<List<PersonalInfo>>> getEmployee(int id)
        {
            //var emp =await _context.PersonalInfos.ToListAsync();
            var emp= await _context.PersonalInfos.FindAsync(keyValues: id);

            return Ok(emp);
        }
        // private readonly ILogger<EmpController> _logger;

        // public EmpController(ILogger<EmpController> logger)
        // {
        //     _logger = logger;
        // }

        // public IActionResult Index()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}