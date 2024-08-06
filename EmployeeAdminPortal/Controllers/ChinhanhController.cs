using Microsoft.AspNetCore.Http;
using EmployeeAdminPortal.ModelFromDB;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ChinhanhController : ControllerBase
    {
        DataContext dbc;

        public ChinhanhController(DataContext db)
        {
            dbc = db;
        }

        [HttpGet]
        [Route("/Chinhanh/List")]
        public IActionResult Getlist()
        {
            return Ok(new { data = dbc.Chinhanhs.ToList() });
        }

        [HttpGet("{idchinhanh}")]
        public IActionResult Get(int idchinhanh)
        {
            var Chinhanh = dbc.Chinhanhs.Find(idchinhanh);
            if (Chinhanh == null)
            {
                return NotFound();
            }
            return Ok(Chinhanh);
        }

        [HttpPost]
        [Route("/Chinhanh/Insert")]
        public IActionResult Add( int idnh, string quocgia, string tinhthanh, string quan, string phuong)
        {
            Chinhanh cn = new Chinhanh();
            cn.Idnh = idnh;
            cn.Quocgia = quocgia;
            cn.Tinhthanh = tinhthanh;
            cn.Quan = quan;
            cn.Phuong = phuong;
            dbc.Chinhanhs.Add(cn);
            dbc.SaveChanges();
            return Ok(new { cn });
        }

        [HttpPut]
        [Route("/Chinhanh/Update")]
        public IActionResult Update(int idchinhanh,int idnh, string quocgia, string tinhthanh, string quan, string phuong)
        {
            Chinhanh cn = new Chinhanh();
            cn.Idchinhanh = idchinhanh;
            cn.Idnh = idnh;
            cn.Quocgia = quocgia;
            cn.Tinhthanh = tinhthanh;
            cn.Quan = quan;
            cn.Phuong = phuong;
            dbc.Chinhanhs.Update(cn);
            dbc.SaveChanges();
            return Ok(new { cn });
        }

        [HttpDelete]
        [Route("/Chinhanh/Delete")]
        public IActionResult Detele(int idchinhanh)
        {
            Chinhanh cn = new Chinhanh();
            cn.Idchinhanh = idchinhanh;

            dbc.Chinhanhs.Remove(cn);
            dbc.SaveChanges();
            return Ok(new { cn });
        }
    }
}
