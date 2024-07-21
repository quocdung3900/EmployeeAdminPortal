using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.ModelFromDB;

[Table("TAISAN")]
public partial class Taisan
{
    [Key]
    [Column("IDTS")]
    public int Idts { get; set; }

    [Column("TENTS")]
    [StringLength(50)]
    public string? Tents { get; set; }

    [Column("NGAYNHAN")]
    public DateOnly? Ngaynhan { get; set; }

    [Column("NGAYTRA")]
    public DateOnly? Ngaytra { get; set; }

    [Column("TINHTRANG")]
    [StringLength(20)]
    public string? Tinhtrang { get; set; }

    [Column("GIATRITAISAN")]
    public double? Giatritaisan { get; set; }

    [Column("IDNV")]
    public int? Idnv { get; set; }

    [ForeignKey("Idnv")]
    [InverseProperty("Taisans")]
    public virtual Nhanvien? IdnvNavigation { get; set; }
}
