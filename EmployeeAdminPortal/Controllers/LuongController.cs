using EmployeeAdminPortal.ModelFromDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace EmployeeAdminPortal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LuongController : ControllerBase
    {
        DataContext dbc;

        public LuongController(DataContext db)
        {
            dbc = db;
        }

        [HttpGet]
        [Route("/Luong/List")]
        public IActionResult Getlist()
        {
            return Ok(new { data = dbc.Luongs.ToList() });
        }

        [HttpGet("{idluong}")]
        public IActionResult Get(int idluong)
        {
            var Luong = dbc.Luongs.Find(idluong);
            if (Luong == null)
            {
                return NotFound();
            }
            return Ok(Luong);
        }

        [HttpPost]
        [Route("/Luong/Insert")]
        public IActionResult Add(int idluong, int idhd, int idnh, int idpc, int idpl, int idktkl, int idnghi, int thang, int ngaycong, int ngaynghi, int ngaydenmuon, int ngayvesom, string nguoiduyet, float tienthuong, float tienphat, float hesoluong, float luongcb, float tongluong)
        {
            Luong lg = new Luong();

            lg.Idhd = idhd;
            lg.Idnh = idnh;
            lg.Idpc = idpc;
            lg.Idpl = idpl;
            lg.Idktkl = idktkl;
            lg.Idnghi = idnghi;
            lg.Thang = thang;
            lg.Ngaycong = ngaycong;
            lg.Ngaynghi = ngaynghi;
            lg.Ngaydenmuon = ngaydenmuon;
            lg.Ngayvesom = ngayvesom;
            lg.Nguoiduyet = nguoiduyet;
            lg.Tienthuong = tienthuong;
            lg.Tienphat = tienphat;
            lg.Hesoluong = hesoluong;
            lg.Luongcb = luongcb;
            lg.Tongluong = tongluong;

            dbc.Luongs.Add(lg);
            dbc.SaveChanges();
            return Ok(new { lg });
        }

        [HttpPut]
        [Route("/Luong/Update")]
        public IActionResult Update(int idluong, int idhd, int idnh, int idpc, int idpl, int idktkl, int idnghi, int thang, int ngaycong, int ngaynghi, int ngaydenmuon, int ngayvesom, string nguoiduyet, float tienthuong, float tienphat, float hesoluong, float luongcb, float tongluong)
        {
            Luong lg = new Luong();
            lg.Idluong = idluong;
            lg.Idhd = idhd;
            lg.Idnh = idnh;
            lg.Idpc = idpc;
            lg.Idpl = idpl;
            lg.Idktkl = idktkl;
            lg.Idnghi = idnghi;
            lg.Thang = thang;
            lg.Ngaycong = ngaycong;
            lg.Ngaynghi = ngaynghi;
            lg.Ngaydenmuon = ngaydenmuon;
            lg.Ngayvesom = ngayvesom;
            lg.Nguoiduyet = nguoiduyet;
            lg.Tienthuong = tienthuong;
            lg.Tienphat = tienphat;
            lg.Hesoluong = hesoluong;
            lg.Luongcb = luongcb;
            lg.Tongluong = tongluong;
            dbc.Luongs.Update(lg);
            dbc.SaveChanges();
            return Ok(new { lg });
        }

        [HttpDelete]
        [Route("/Luong/Delete")]
        public IActionResult Detele(int idluong)
        {
            Luong lg = new Luong();
            lg.Idluong = idluong;

            dbc.Luongs.Remove(lg);
            dbc.SaveChanges();
            return Ok(new { lg });
        }
    }
}
