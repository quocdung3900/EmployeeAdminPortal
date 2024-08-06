using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.ModelFromDB;

[Table("NGANHANG")]
public partial class Nganhang
{
    [Key]
    [Column("IDNH")]
    public int Idnh { get; set; }

    [Column("TENNH")]
    [StringLength(50)]
    public string? Tennh { get; set; }

    [Column("IDCHINHANH")]
    public int Idchinhanh { get; set; }

    [Column("LOAITIEN")]
    [StringLength(50)]
    public string? Loaitien { get; set; }

    [ForeignKey("Idchinhanh")]
    [InverseProperty("Nganhangs")]
    public virtual Chinhanh? IdchinhanhNavigation { get; set; }

    [InverseProperty("IdnhNavigation")]
    public virtual ICollection<Luong> Luongs { get; set; } = new List<Luong>();
}
