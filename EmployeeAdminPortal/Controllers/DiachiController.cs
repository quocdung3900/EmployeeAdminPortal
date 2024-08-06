using Microsoft.AspNetCore.Http;
using EmployeeAdminPortal.ModelFromDB;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DiachiController : ControllerBase
    {
        DataContext dbc;

        public DiachiController(DataContext db)
        {
            dbc = db;
        }

        [HttpGet]
        [Route("/Diachi/List")]
        public IActionResult Getlist()
        {
            return Ok(new { data = dbc.Diachis.ToList() });
        }

        [HttpGet("{iddiachi}")]
        public IActionResult Get(int iddiachi)
        {
            var Diachi = dbc.Diachis.Find(iddiachi);
            if (Diachi == null)
            {
                return NotFound();
            }
            return Ok(Diachi);
        }

        [HttpPost]
        [Route("/Diachi/Insert")]
        public IActionResult Add( string quocgia, string tinhthanh, string quan, string phuong)
        {
            Diachi dc = new Diachi();
           
            dc.Quocgia = quocgia;
            dc.Tinhthanh = tinhthanh;
            dc.Quan = quan;
            dc.Phuong = phuong;
            dbc.Diachis.Add(dc);
            dbc.SaveChanges();
            return Ok(new { dc });
        }

        [HttpPut]
        [Route("/Diachi/Update")]
        public IActionResult Update(int iddiachi,string quocgia, string tinhthanh, string quan, string phuong)
        {
            Diachi dc = new Diachi();
            dc.Iddiachi = iddiachi;
            dc.Quocgia = quocgia;
            dc.Tinhthanh = tinhthanh;
            dc.Quan = quan;
            dc.Phuong = phuong;
            dbc.Diachis.Update(dc);
            dbc.SaveChanges();
            return Ok(new { dc });
        }

        [HttpDelete]
        [Route("/Diachi/Delete")]
        public IActionResult Detele(int iddiachi)
        {
            Diachi dc = new Diachi();
            dc.Iddiachi = iddiachi;

            dbc.Diachis.Remove(dc);
            dbc.SaveChanges();
            return Ok(new { dc });
        }
    }
}
