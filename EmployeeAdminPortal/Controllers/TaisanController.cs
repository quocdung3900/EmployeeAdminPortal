using EmployeeAdminPortal.ModelFromDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TaisanController : ControllerBase
    {
        DataContext dbc;

        public TaisanController(DataContext db)
        {
            dbc = db;
        }

        [HttpGet]
        [Route("/Taisan/List")]
        public IActionResult Getlist()
        {
            return Ok(new { data = dbc.Taisans.ToList() });
        }

        [HttpGet("{idts}")]
        public IActionResult Get(int idts)
        {
            var Taisan = dbc.Taisans.Find(idts);
            if (Taisan == null)
            {
                return NotFound();
            }
            return Ok(Taisan);
        }

        [HttpPost]
        [Route("/Taisan/Insert")]
        public IActionResult Add(int idts, int idnv, string tents, DateOnly ngaynhan, DateOnly ngaytra, string tinhtrang, float giatritaisan)
        {
            Taisan ts = new Taisan();

            ts.Idnv = idnv;
            ts.Tents = tents;
            ts.Ngaynhan = ngaynhan;
            ts.Ngaytra = ngaytra;
            ts.Tinhtrang = tinhtrang;
            ts.Giatritaisan = giatritaisan;           
            dbc.Taisans.Add(ts);
            dbc.SaveChanges();
            return Ok(new { ts });
        }

        [HttpPut]
        [Route("/Taisan/Update")]
        public IActionResult Update(int idts, int idnv, string tents, DateOnly ngaynhan, DateOnly ngaytra, string tinhtrang, float giatritaisan)
        {
            Taisan ts = new Taisan();
            ts.Idts = idts;
            ts.Idnv = idnv;
            ts.Tents = tents;
            ts.Ngaynhan = ngaynhan;
            ts.Ngaytra = ngaytra;
            ts.Tinhtrang = tinhtrang;
            ts.Giatritaisan = giatritaisan;
            dbc.Taisans.Update(ts);
            dbc.SaveChanges();
            return Ok(new { ts });
        }

        [HttpDelete]
        [Route("/Taisan/Delete")]
        public IActionResult Detele(int idts)
        {
            Taisan ts = new Taisan();
            ts.Idts = idts;

            dbc.Taisans.Remove(ts);
            dbc.SaveChanges();
            return Ok(new { ts });
        }
    }
}
