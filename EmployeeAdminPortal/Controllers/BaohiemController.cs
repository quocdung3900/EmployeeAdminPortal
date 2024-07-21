using Microsoft.AspNetCore.Http;
using EmployeeAdminPortal.ModelFromDB;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BaohiemController : ControllerBase
    {
        DataContext dbc;

        public BaohiemController(DataContext db)
        {
            dbc = db;
        }

        [HttpGet]
        [Route("/Baohiem/List")]
        public IActionResult Getlist()
        {
            return Ok(new { data = dbc.Baohiems.ToList() });
        }
        [HttpGet("{idbh}")]
        public IActionResult Get(int idbh)
        {
            var Baohiem = dbc.Baohiems.Find(idbh);
            if (Baohiem == null)
            {
                return NotFound();
            }
            return Ok(Baohiem);
        }
        [HttpPost]
        [Route("/Baohiem/Insert")]
        public IActionResult Add(int idbh, int idnv, int sobh, DateOnly ngaycap, string noicap, DateOnly thoihan, string noikhambenh)
        {
            Baohiem bh = new Baohiem();

            bh.Idnv = idnv;
            bh.Sobh = sobh;
            bh.Ngaycap = ngaycap;
            bh.Noicap = noicap;
            bh.Thoihan = thoihan;
            bh.Noikhambenh = noikhambenh;
            
            dbc.Baohiems.Add(bh);
            dbc.SaveChanges();
            return Ok(new { bh });
        }

        [HttpPut]
        [Route("/Baohiem/Update")]
        public IActionResult Update(int idbh, int idnv, int sobh, DateOnly ngaycap, string noicap, DateOnly thoihan, string noikhambenh)
        {
            Baohiem bh = new Baohiem();
            bh.Idbh = idbh;
            bh.Idnv = idnv;
            bh.Sobh = sobh;
            bh.Ngaycap = ngaycap;
            bh.Noicap = noicap;
            bh.Thoihan = thoihan;
            bh.Noikhambenh = noikhambenh;
            dbc.Baohiems.Update(bh);
            dbc.SaveChanges();
            return Ok(new { bh });
        }

        [HttpDelete]
        [Route("/Baohiem/Delete")]
        public IActionResult Detele(int idbh)
        {
            Baohiem bh = new Baohiem();
            bh.Idbh = idbh;

            dbc.Baohiems.Remove(bh);
            dbc.SaveChanges();
            return Ok(new { bh });
        }
    }
}
