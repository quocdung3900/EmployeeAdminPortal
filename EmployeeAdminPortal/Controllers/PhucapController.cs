using EmployeeAdminPortal.ModelFromDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PhucapController : ControllerBase
    {
        
            DataContext dbc;

            public PhucapController(DataContext db)
            {
                dbc = db;
            }

            [HttpGet]
            [Route("/Phucap/List")]
            public IActionResult Getlist()
            {
                return Ok(new { data = dbc.Phucaps.ToList() });
            }

            [HttpGet("{idpc}")]
            public IActionResult Get(int idpc)
            {
             var Phucap = dbc.Phucaps.Find(idpc);
                  if (Phucap == null)
                  {
                    return NotFound();
                  }
               return Ok(Phucap);
            }

            [HttpPost]
            [Route("/Phucap/Insert")]
            public IActionResult Add(int idpc, string loaiphucap, int idot, DateOnly ngay, float sotien)
            {
                Phucap pc = new Phucap();

                pc.Loaiphucap = loaiphucap;
                pc.Idot = idot; 
                pc.Sotien = sotien;

                dbc.Phucaps.Add(pc);
                dbc.SaveChanges();
                return Ok(new { pc });
            }

            [HttpPut]
            [Route("/Phucap/Update")]
            public IActionResult Update(int idpc, string loaiphucap, int idot, DateOnly ngay, float sotien)
            {
                 Phucap pc = new Phucap();
                 pc.Idpc = idpc;
                 pc.Loaiphucap = loaiphucap;
                 pc.Idot = idot;
                 pc.Sotien = sotien;
            dbc.Phucaps.Update(pc);
                dbc.SaveChanges();
                return Ok(new { pc });
            }

            [HttpDelete]
            [Route("/Phucap/Delete")]
            public IActionResult Detele(int idpc)
            {
                Phucap pc = new Phucap();
                pc.Idpc = idpc;

                dbc.Phucaps.Remove(pc);
                dbc.SaveChanges();
                return Ok(new { pc });
            }
        }
}
