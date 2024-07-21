using Microsoft.AspNetCore.Http;
using EmployeeAdminPortal.ModelFromDB;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NganhangController : ControllerBase
    {
        DataContext dbc;

        public NganhangController(DataContext db)
        {
            dbc = db;
        }

        [HttpGet]
        [Route("/Nganhang/List")]
        public IActionResult Getlist()
        {
            return Ok(new { data = dbc.Nganhangs.ToList() });
        }

        [HttpGet("{idnh}")]
        public IActionResult Get(int idnh)
        {
            var Nganhang = dbc.Nganhangs.Find(idnh);
            if (Nganhang == null)
            {
                return NotFound();
            }
            return Ok(Nganhang);
        }

        [HttpPost]
        [Route("/Nganhang/Insert")]
        public IActionResult Add(int idnh, string tennh, string chinhanh)
        {
            Nganhang nh = new Nganhang();

            nh.Tennh = tennh;
            nh.Chinhanh = chinhanh;
            dbc.Nganhangs.Add(nh);
            dbc.SaveChanges();
            return Ok(new { nh });
        }

        [HttpPut]
        [Route("/Nganhang/Update")]
        public IActionResult Update(int idnh, string tennh, string chinhanh)
        {
            Nganhang nh = new Nganhang();
            nh.Idnh = idnh;
            nh.Tennh = tennh;
            nh.Chinhanh = chinhanh;
            dbc.Nganhangs.Update(nh);
            dbc.SaveChanges();
            return Ok(new { nh });
        }

        [HttpDelete]
        [Route("/Nganhang/Delete")]
        public IActionResult Detele(int idnh)
        {
            Nganhang nh = new Nganhang();
            nh.Idnh = idnh;

            dbc.Nganhangs.Remove(nh);
            dbc.SaveChanges();
            return Ok(new { nh });
        }
    }
}
