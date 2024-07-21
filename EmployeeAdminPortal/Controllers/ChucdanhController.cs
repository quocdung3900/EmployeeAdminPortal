using EmployeeAdminPortal.ModelFromDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ChucdanhController : ControllerBase
    {
        DataContext dbc;

        public ChucdanhController(DataContext db)
        {
            dbc = db;
        }

        [HttpGet]
        [Route("/Chucdanh/List")]
        public IActionResult Getlist()
        {
            return Ok(new { data = dbc.Chucdanhs.ToList() });
        }
        [HttpGet("{idcd}")]
        public IActionResult Get(int idcd)
        {
            var Chucdanh = dbc.Chucdanhs.Find(idcd);
            if (Chucdanh == null)
            {
                return NotFound();
            }
            return Ok(Chucdanh);
        }
        [HttpPost]
        [Route("/Chucdanh/Insert")]
        public IActionResult Add(int idcd, string tencd, int idpb)
        {
            Chucdanh cd = new Chucdanh();

            cd.Tencd = tencd;
            cd.Idpb = idpb;
            dbc.Chucdanhs.Add(cd);
            dbc.SaveChanges();
            return Ok(new { cd });
        }

        [HttpPut]
        [Route("/Chucdanh/Update")]
        public IActionResult Update(int idcd, string tencd, int idpb)
        {
            Chucdanh cd = new Chucdanh();
            cd.Idcd = idcd;
            cd.Tencd = tencd;
            cd.Idpb = idpb;
            dbc.Chucdanhs.Update(cd);
            dbc.SaveChanges();
            return Ok(new { cd });
        }

        [HttpDelete]
        [Route("/Chucdanh/Delete")]
        public IActionResult Detele(int idcd)
        {
            Chucdanh cd = new Chucdanh();
            cd.Idcd = idcd;

            dbc.Chucdanhs.Remove(cd);
            dbc.SaveChanges();
            return Ok(new { cd });
        }
    }
}
