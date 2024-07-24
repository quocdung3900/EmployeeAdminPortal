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
    public interface INhanvienService
    {
        IEnumerable<Nhanvien> GetNhanviens();
        Nhanvien GetNhanvienById(int idnv);
        void AddNhanvien(Nhanvien nhanvien);
        void UpdateNhanvien(Nhanvien nhanvien);
        void DeleteNhanvien(int idnv);
    }
}