using EmployeeAdminPortal.ModelFromDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PhongbanController : ControllerBase
    {
        DataContext dbc;

        public PhongbanController(DataContext db)
        {
            dbc = db;
        }

        [HttpGet]
        [Route("/Phongban/List")]
        public IActionResult Getlist()
        {
            return Ok(new { data = dbc.Phongbans.ToList() });
        }

        [HttpGet("{idpb}")]
        public IActionResult Get(int idpb)
        {
            var Phongban = dbc.Phongbans.Find(idpb);
            if (Phongban == null)
            {
                return NotFound();
            }
            return Ok(Phongban);
        }

        [HttpPost]
        [Route("/Phongban/Insert")]
        public IActionResult Add(int idpb, string tenpb, int idnv)
        {
            Phongban pb = new Phongban();

            pb.Idnv = idnv;
            pb.Tenpb = tenpb;
            dbc.Phongbans.Add(pb);
            dbc.SaveChanges();
            return Ok(new { pb });
        }

        [HttpPut]
        [Route("/Phongban/Update")]
        public IActionResult Update(int idpb, string tenpb, int idnv)
        {
            Phongban pb = new Phongban();
            pb.Idpb = idpb;
            pb.Idnv = idnv;
            pb.Tenpb = tenpb;
            dbc.Phongbans.Update(pb);
            dbc.SaveChanges();
            return Ok(new { pb });
        }

        [HttpDelete]
        [Route("/Phongban/Delete")]
        public IActionResult Detele(int idpb)
        {
            Phongban pb = new Phongban();
            pb.Idpb = idpb;

            dbc.Phongbans.Remove(pb);
            dbc.SaveChanges();
            return Ok(new { pb });
        }
    }
}
