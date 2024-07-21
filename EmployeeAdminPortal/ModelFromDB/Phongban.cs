using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.ModelFromDB;

[Table("PHONGBAN")]
public partial class Phongban
{
    [Key]
    [Column("IDPB")]
    public int Idpb { get; set; }

    [Column("TENPB")]
    [StringLength(20)]
    public string? Tenpb { get; set; }

    [Column("IDNV")]
    public int? Idnv { get; set; }

    [InverseProperty("IdpbNavigation")]
    public virtual ICollection<Chucdanh> Chucdanhs { get; set; } = new List<Chucdanh>();

    [ForeignKey("Idnv")]
    [InverseProperty("Phongbans")]
    public virtual Nhanvien? IdnvNavigation { get; set; }
}
