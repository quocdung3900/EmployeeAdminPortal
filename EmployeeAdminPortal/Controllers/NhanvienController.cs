using EmployeeAdminPortal.ModelFromDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class NhanvienController : ControllerBase
    {
        DataContext dbc;

        public NhanvienController(DataContext db)
        {
            dbc = db;
        }

        [HttpGet]
        [Route("/Nhanvien/List")]
        public IActionResult Getlist()
        {
            return Ok(new { data = dbc.Nhanviens.ToList() });
        }
        [HttpGet("{idnv}")]
        public IActionResult Get(int idnv)
        {
            var Nhanvien = dbc.Nhanviens.Find(idnv);
            if (Nhanvien == null)
            {
                return NotFound();
            }
            return Ok(Nhanvien);
        }
        [HttpPost]
        [Route("/Nhanvien/Insert")]
        public IActionResult Add(string hoten, bool gioitinh, DateOnly ngaysinh, string diachi, string quequan, int dienthoai, string email, int cccd, string quoctich, bool tthonnhan, string qtct)
        {
            Nhanvien nv = new Nhanvien();
            nv.Hoten = hoten;
            nv.Gioitinh = gioitinh;
            nv.Ngaysinh = ngaysinh;
            nv.Diachi = diachi;
            nv.Quequan = quequan;
            nv.Dienthoai = dienthoai;
            nv.Email = email;
            nv.Cccd = cccd;
            nv.Quoctich = quoctich;
            nv.Tthonnhan = tthonnhan;
            nv.Qtct = qtct;
            dbc.Nhanviens.Add(nv);
            dbc.SaveChanges();
            return Ok(new { nv });
        }

        [HttpPut]
        [Route("/Nhanvien/Update")]
        public IActionResult Update(int idnv, string hoten, bool gioitinh, DateOnly ngaysinh, string diachi, string quequan, int dienthoai, string email, int cccd, string quoctich, bool tthonnhan, string qtct)
        {
            Nhanvien nv = new Nhanvien();
            nv.Idnv = idnv;
            nv.Hoten = hoten;
            nv.Gioitinh = gioitinh;
            nv.Ngaysinh = ngaysinh;
            nv.Diachi = diachi;
            nv.Quequan = quequan;
            nv.Dienthoai = dienthoai;
            nv.Email = email;
            nv.Cccd = cccd;
            nv.Quoctich = quoctich;
            nv.Tthonnhan = tthonnhan;
            nv.Qtct = qtct;
            dbc.Nhanviens.Update(nv);
            dbc.SaveChanges();
            return Ok(new { nv });
        }

        [HttpDelete]
        [Route("/Nhanvien/Delete")]
        public IActionResult Xoanhanvien(int idnv)
        {
            Nhanvien nv = new Nhanvien();
            nv.Idnv = idnv;
            dbc.Nhanviens.Remove(nv);
            dbc.SaveChanges();
            return Ok(new { nv });
        }
    }
}
