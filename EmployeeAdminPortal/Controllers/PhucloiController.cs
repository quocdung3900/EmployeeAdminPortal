using EmployeeAdminPortal.ModelFromDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PhucloiController : ControllerBase
    {
        DataContext dbc;

        public PhucloiController(DataContext db)
        {
            dbc = db;
        }

        [HttpGet]
        [Route("/Phucloi/List")]
        public IActionResult Getlist()
        {
            return Ok(new { data = dbc.Phuclois.ToList() });
        }

        [HttpGet("{idpl}")]
        public IActionResult Get(int idpl)
        {
            var Phucloi = dbc.Phuclois.Find(idpl);
            if (Phucloi == null)
            {
                return NotFound();
            }
            return Ok(Phucloi);
        }

        [HttpPost]
        [Route("/Phucloi/Insert")]
        public IActionResult Add(int idpl, string loaiphucloi, DateOnly ngay, float sotien)
        {
            Phucloi pl = new Phucloi();

            pl.Loaiphucloi = loaiphucloi;
            pl.Ngay = ngay;
            pl.Sotien = sotien;

            dbc.Phuclois.Add(pl);
            dbc.SaveChanges();
            return Ok(new { pl });
        }

        [HttpPut]
        [Route("/Phucloi/Update")]
        public IActionResult Update(int idpl, string loaiphucloi, DateOnly ngay, float sotien)
        {
            Phucloi pl = new Phucloi();
            pl.Idpl = idpl;
            pl.Loaiphucloi = loaiphucloi;
            pl.Ngay = ngay;
            pl.Sotien = sotien;
            dbc.Phuclois.Update(pl);
            dbc.SaveChanges();
            return Ok(new { pl });
        }

        [HttpDelete]
        [Route("/Phucloi/Delete")]
        public IActionResult Detele(int idpl)
        {
            Phucloi pl = new Phucloi();
            pl.Idpl = idpl;

            dbc.Phuclois.Remove(pl);
            dbc.SaveChanges();
            return Ok(new { pl });
        }
    }
}
