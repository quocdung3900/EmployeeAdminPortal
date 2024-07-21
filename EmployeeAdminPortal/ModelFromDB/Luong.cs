using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.ModelFromDB;

[Table("LUONG")]
public partial class Luong
{
    [Key]
    [Column("IDLUONG")]
    public int Idluong { get; set; }

    [Column("IDHD")]
    public int? Idhd { get; set; }

    [Column("THANG")]
    public int? Thang { get; set; }

    [Column("NGAYCONG")]
    public int? Ngaycong { get; set; }

    [Column("NGAYNGHI")]
    public int? Ngaynghi { get; set; }

    [Column("NGAYDENMUON")]
    public int? Ngaydenmuon { get; set; }

    [Column("NGAYVESOM")]
    public int? Ngayvesom { get; set; }

    [Column("NGUOIDUYET")]
    [StringLength(50)]
    public string? Nguoiduyet { get; set; }

    [Column("IDNH")]
    public int? Idnh { get; set; }

    [Column("TIENTHUONG")]
    public double? Tienthuong { get; set; }

    [Column("TIENPHAT")]
    public double? Tienphat { get; set; }

    [Column("HESOLUONG")]
    public double? Hesoluong { get; set; }

    [Column("LUONGCB")]
    public double? Luongcb { get; set; }

    [Column("TONGLUONG")]
    public double? Tongluong { get; set; }

    [Column("IDPC")]
    public int? Idpc { get; set; }

    [Column("IDPL")]
    public int? Idpl { get; set; }

    [Column("IDKTKL")]
    public int? Idktkl { get; set; }

    [Column("IDNGHI")]
    public int? Idnghi { get; set; }

    [ForeignKey("Idhd")]
    [InverseProperty("Luongs")]
    public virtual Hopdong? IdhdNavigation { get; set; }

    [ForeignKey("Idktkl")]
    [InverseProperty("Luongs")]
    public virtual KhenthuongKyluat? IdktklNavigation { get; set; }

    [ForeignKey("Idnghi")]
    [InverseProperty("Luongs")]
    public virtual Nghiviec? IdnghiNavigation { get; set; }

    [ForeignKey("Idnh")]
    [InverseProperty("Luongs")]
    public virtual Nganhang? IdnhNavigation { get; set; }

    [ForeignKey("Idpc")]
    [InverseProperty("Luongs")]
    public virtual Phucloi? Idpc1 { get; set; }

    [ForeignKey("Idpc")]
    [InverseProperty("Luongs")]
    public virtual Phucap? IdpcNavigation { get; set; }
}
