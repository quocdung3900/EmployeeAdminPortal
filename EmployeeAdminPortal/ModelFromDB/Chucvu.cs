using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.ModelFromDB;

[Table("CHUCVU")]
public partial class Chucvu
{
    [Key]
    [Column("IDCV")]
    public int Idcv { get; set; }

    [Column("TENCV")]
    [StringLength(50)]
    public string? Tencv { get; set; }

    [Column("IDCD")]
    public int? Idcd { get; set; }

    [ForeignKey("Idcd")]
    [InverseProperty("Chucvus")]
    public virtual Chucdanh? IdcdNavigation { get; set; }
}
