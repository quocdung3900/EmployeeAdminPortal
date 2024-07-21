using EmployeeAdminPortal.ModelFromDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NghiviecController : ControllerBase
    {
        DataContext dbc;

        public NghiviecController(DataContext db)
        {
            dbc = db;
        }

        [HttpGet]
        [Route("/Nghiviec/List")]
        public IActionResult Getlist()
        {
            return Ok(new { data = dbc.Nghiviecs.ToList() });
        }

        [HttpGet("{idnghi}")]
        public IActionResult Get(int idnghi)
        {
            var Nghiviec = dbc.Nghiviecs.Find(idnghi);
            if (Nghiviec == null)
            {
                return NotFound();
            }
            return Ok(Nghiviec);
        }

        [HttpPost]
        [Route("/Nghiviec/Insert")]
        public IActionResult Add(int idnghi, int idluong, bool cophep, string lydo, DateOnly ngaynghibatdau, DateTimeOffset ngaynghiketthuc, string nguoiduyet)
        {
            Nghiviec n = new Nghiviec();

            n.Idluong = idluong;
            n.Cophep = cophep;
            n.Lydo = lydo;
            n.Ngaynghibatdau = ngaynghibatdau;
            n.Ngaynghiketthuc = ngaynghiketthuc;
            n.Nguoiduyet = nguoiduyet;
            dbc.Nghiviecs.Add(n);
            dbc.SaveChanges();
            return Ok(new { n });
        }

        [HttpPut]
        [Route("/Nghiviec/Update")]
        public IActionResult Update(int idnghi, int idluong, bool cophep, string lydo, DateOnly ngaynghibatdau, DateTimeOffset ngaynghiketthuc, string nguoiduyet)
        {
            Nghiviec n = new Nghiviec();
            n.Idnghi = idnghi;
            n.Idluong = idluong;
            n.Cophep = cophep;
            n.Lydo = lydo;
            n.Ngaynghibatdau = ngaynghibatdau;
            n.Ngaynghiketthuc = ngaynghiketthuc;
            n.Nguoiduyet = nguoiduyet;
            dbc.Nghiviecs.Update(n);
            dbc.SaveChanges();
            return Ok(new { n });
        }

        [HttpDelete]
        [Route("/Nghiviec/Delete")]
        public IActionResult Detele(int idnghi)
        {
            Nghiviec n = new Nghiviec();
            n.Idnghi = idnghi;

            dbc.Nghiviecs.Remove(n);
            dbc.SaveChanges();
            return Ok(new { n });
        }
    }
}
