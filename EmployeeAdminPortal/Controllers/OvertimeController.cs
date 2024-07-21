using EmployeeAdminPortal.ModelFromDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OvertimeController : ControllerBase
    {
        DataContext dbc;

        public OvertimeController(DataContext db)
        {
            dbc = db;
        }

        [HttpGet]
        [Route("/Overtime/List")]
        public IActionResult Getlist()
        {
            return Ok(new { data = dbc.Overtimes.ToList() });
        }

        [HttpGet("{idot}")]
        public IActionResult Get(int idot)
        {
            var Overtime = dbc.Overtimes.Find(idot);
            if (Overtime == null)
            {
                return NotFound();
            }
            return Ok(Overtime);
        }

        [HttpPost]
        [Route("/Overtime/Insert")]
        public IActionResult Add(int idot, int idpc, int sogio, float hesoluong,float sotien)
        {
            Overtime ot = new Overtime();

            ot.Idpc = idpc;
            ot.Sogio = sogio;   
            ot.Hesoluong = hesoluong;
            ot.Sotien = sotien;

            dbc.Overtimes.Add(ot);
            dbc.SaveChanges();
            return Ok(new { ot });
        }

        [HttpPut]
        [Route("/Overtime/Update")]
        public IActionResult Update(int idot, int idpc, int sogio, float hesoluong, float sotien)
        {
            Overtime ot = new Overtime();
            ot.Idot = idot;
            ot.Idpc = idpc;
            ot.Sogio = sogio;
            ot.Hesoluong = hesoluong;
            ot.Sotien = sotien;
            dbc.Overtimes.Update(ot);
            dbc.SaveChanges();
            return Ok(new { ot });
        }

        [HttpDelete]
        [Route("/Overtime/Delete")]
        public IActionResult Detele(int idot)
        {
            Overtime ot = new Overtime();
            ot.Idot = idot;

            dbc.Overtimes.Remove(ot);
            dbc.SaveChanges();
            return Ok(new { ot });
        }
    }
}
