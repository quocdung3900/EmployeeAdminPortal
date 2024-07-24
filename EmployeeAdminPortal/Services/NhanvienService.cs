using EmployeeAdminPortal.ModelFromDB;
using EmployeeAdminPortal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeAdminPortal.Services
{
    public class NhanvienService : INhanvienService
    {
        private readonly DataContext _dbContext;

        public NhanvienService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Nhanvien> GetNhanviens()
        {
            return _dbContext.Nhanviens.ToList();
        }

        public Nhanvien GetNhanvienById(int idnv)
        {
            return _dbContext.Nhanviens.Find(idnv);
        }

        public void AddNhanvien(Nhanvien nhanvien)
        {
            _dbContext.Nhanviens.Add(nhanvien);
            _dbContext.SaveChanges();
        }

        public void UpdateNhanvien(Nhanvien nhanvien)
        {
            _dbContext.Entry(nhanvien).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeleteNhanvien(int idnv)
        {
            var nhanvien = _dbContext.Nhanviens.Find(idnv);
            if (nhanvien != null)
            {
                _dbContext.Nhanviens.Remove(nhanvien);
                _dbContext.SaveChanges();
            }
        }
    }
}
// hiện chưa tách thành công Controller và Services 