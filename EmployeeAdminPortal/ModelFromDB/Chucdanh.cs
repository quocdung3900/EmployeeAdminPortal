using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.ModelFromDB;

[Table("CHUCDANH")]
public partial class Chucdanh
{
    [Key]
    [Column("IDCD")]
    public int Idcd { get; set; }

    [Column("TENCD")]
    [StringLength(50)]
    public string? Tencd { get; set; }

    [Column("IDPB")]
    public int? Idpb { get; set; }

    [InverseProperty("IdcdNavigation")]
    public virtual ICollection<Chucvu> Chucvus { get; set; } = new List<Chucvu>();

    [ForeignKey("Idpb")]
    [InverseProperty("Chucdanhs")]
    public virtual Phongban? IdpbNavigation { get; set; }
}
