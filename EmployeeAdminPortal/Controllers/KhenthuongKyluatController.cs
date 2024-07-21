using EmployeeAdminPortal.ModelFromDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EmployeeAdminPortal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KhenthuongKyluatController : ControllerBase
    {
        DataContext dbc;

        public KhenthuongKyluatController(DataContext db)
        {
            dbc = db;
        }

        [HttpGet]
        [Route("/KhenthuongKyluat/List")]
        public IActionResult Getlist()
        {
            return Ok(new { data = dbc.KhenthuongKyluats.ToList() });
        }

        [HttpGet("{idktkl}")]
        public IActionResult Get(int idktkl)
        {
            var KhenthuongKyluat = dbc.KhenthuongKyluats.Find(idktkl);
            if (KhenthuongKyluat == null)
            {
                return NotFound();
            }
            return Ok(KhenthuongKyluat);
        }

        [HttpPost]
        [Route("/KhenthuongKyluat/Insert")]
        public IActionResult Add(int idktkl, bool loai, string noidung, DateOnly ngay)
        {
           KhenthuongKyluat ktkl = new KhenthuongKyluat();

            ktkl.Loai = loai;
            ktkl.Noidung = noidung;
            ktkl.Ngay = ngay;
            dbc.KhenthuongKyluats.Add(ktkl);
            dbc.SaveChanges();
            return Ok(new { ktkl });
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update(int idktkl, bool loai, string noidung, DateOnly ngay)
        {
            KhenthuongKyluat ktkl = new KhenthuongKyluat();
            ktkl.Idktkl = idktkl;
            ktkl.Loai = loai;
            ktkl.Noidung = noidung;
            ktkl.Ngay = ngay;
            dbc.KhenthuongKyluats.Update(ktkl);
            dbc.SaveChanges();
            return Ok(new { ktkl });
        }

        [HttpDelete]
        [Route("/KhenthuongKyluat/Delete")]
        public IActionResult Detele(int idktkl)
        {
            KhenthuongKyluat ktkl = new KhenthuongKyluat();
            ktkl.Idktkl = idktkl;

            dbc.KhenthuongKyluats.Remove(ktkl);
            dbc.SaveChanges();
            return Ok(new { ktkl });
        }
    }
}
