using EmployeeAdminPortal.ModelFromDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ChucvuController : ControllerBase
    {
        DataContext dbc;

        public ChucvuController(DataContext db)
        {
            dbc = db;
        }

        [HttpGet]
        [Route("/Chucvu/List")]
        public IActionResult Getlist()
        {
            return Ok(new { data = dbc.Chucvus.ToList() });
        }

        [HttpGet("{idcv}")]
        public IActionResult Get(int idcv)
        {
            var Chucvu = dbc.Chucvus.Find(idcv);
            if (Chucvu == null)
            {
                return NotFound();
            }
            return Ok(Chucvu);
        }

        [HttpPost]
        [Route("/Chucvu/Insert")]
        public IActionResult Add(int idcv, string tencv, int idcd)
        {
            Chucvu cv = new Chucvu();

            cv.Tencv = tencv;
            cv.Idcd = idcd;
            dbc.Chucvus.Add(cv);
            dbc.SaveChanges();
            return Ok(new { cv });
        }

        [HttpPut]
        [Route("/Chucvu/Update")]
        public IActionResult Update(int idcv, string tencv, int idcd)
        {
            Chucvu cv = new Chucvu();
            cv.Idcv = idcv;
            cv.Tencv = tencv;
            cv.Idcd = idcd;
            dbc.Chucvus.Update(cv);
            dbc.SaveChanges();
            return Ok(new { cv });
        }

        [HttpDelete]
        [Route("/Chucvu/Delete")]
        public IActionResult Detele(int idcv)
        {
            Chucvu cv = new Chucvu();
            cv.Idcv = idcv;

            dbc.Chucvus.Remove(cv);
            dbc.SaveChanges();
            return Ok(new { cv });
        }
    }
}
