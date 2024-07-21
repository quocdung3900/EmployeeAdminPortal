using EmployeeAdminPortal.ModelFromDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HopdongController : ControllerBase
    {
        DataContext dbc;

        public HopdongController(DataContext db)
        {
            dbc = db;
        }

        [HttpGet]
        [Route("/Hopdong/List")]
        public IActionResult Getlist()
        {
            return Ok(new { data = dbc.Hopdongs.ToList() });
        }

        [HttpGet("{idhd}")]
        public IActionResult Get(int idhd)
        {
            var Hopdong = dbc.Hopdongs.Find(idhd);
            if (Hopdong == null)
            {
                return NotFound();
            }
            return Ok(Hopdong);
        }

        [HttpPost]
        [Route("/Hopdong/Insert")]
        public IActionResult Themhopdong(int idhd, int idnv, string tenhp, DateOnly ngaybatdau, DateTimeOffset ngayketthuc, DateOnly ngayky, int idluong, string nguoilamhopdong, float hesoluong)
        {
            Hopdong hd = new Hopdong();

            hd.Idnv = idnv;
            hd.Tenhp = tenhp;
            hd.Ngaybatdau = ngaybatdau;
            hd.Ngayketthuc = ngayketthuc;
            hd.Ngayky = ngayky;
            hd.Idluong = idluong;
            hd.Nguoilamhopdong = nguoilamhopdong;
            hd.Hesoluong = hesoluong;

            dbc.Hopdongs.Add(hd);
            dbc.SaveChanges();
            return Ok(new { hd });
        }

        [HttpPut]
        [Route("/Hopdong/Update")]
        public IActionResult Capnhathopdong(int idhd, int idnv, string tenhp, DateOnly ngaybatdau, DateTimeOffset ngayketthuc, DateOnly ngayky, int idluong, string nguoilamhopdong, float hesoluong)
        {
            Hopdong hd = new Hopdong();
            hd.Idhd = idhd;
            hd.Idnv = idnv;
            hd.Tenhp = tenhp;
            hd.Ngaybatdau = ngaybatdau;
            hd.Ngayketthuc = ngayketthuc;
            hd.Ngayky = ngayky;
            hd.Idluong = idluong;
            hd.Nguoilamhopdong = nguoilamhopdong;
            hd.Hesoluong = hesoluong;
            dbc.Hopdongs.Update(hd);
            dbc.SaveChanges();
            return Ok(new { hd });
        }

        [HttpDelete]
        [Route("/Hopdong/Delete")]
        public IActionResult Xoahopdong(int idhd)
        {
            Hopdong hd = new Hopdong();
            hd.Idhd = idhd;

            dbc.Hopdongs.Remove(hd);
            dbc.SaveChanges();
            return Ok(new { hd });
        }
    }
}
