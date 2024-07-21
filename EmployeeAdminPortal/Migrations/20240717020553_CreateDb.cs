using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAdminPortal.Migrations
{
    /// <inheritdoc />
    public partial class CreateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KHENTHUONG_KYLUAT",
                columns: table => new
                {
                    IDKTKL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOAI = table.Column<bool>(type: "bit", nullable: true),
                    NOIDUNG = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NGAY = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHENTHUONG_KYLUAT", x => x.IDKTKL);
                });

            migrationBuilder.CreateTable(
                name: "NGANHANG",
                columns: table => new
                {
                    IDNH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENNH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CHINHANH = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NGANHANG", x => x.IDNH);
                });

            migrationBuilder.CreateTable(
                name: "NGHIVIEC",
                columns: table => new
                {
                    IDNGHI = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDLUONG = table.Column<int>(type: "int", nullable: true),
                    COPHEP = table.Column<bool>(type: "bit", nullable: true),
                    LYDO = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NGAYNGHIBATDAU = table.Column<DateOnly>(type: "date", nullable: true),
                    NGAYNGHIKETTHUC = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NGUOIDUYET = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NGHIVIEC", x => x.IDNGHI);
                });

            migrationBuilder.CreateTable(
                name: "NHANVIEN",
                columns: table => new
                {
                    IDNV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HOTEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GIOITINH = table.Column<bool>(type: "bit", nullable: true),
                    NGAYSINH = table.Column<DateOnly>(type: "date", nullable: true),
                    DIACHI = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    QUEQUAN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DIENTHOAI = table.Column<int>(type: "int", nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CCCD = table.Column<int>(type: "int", nullable: true),
                    QUOCTICH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TTHONNHAN = table.Column<bool>(type: "bit", nullable: true),
                    QTCT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHANVIEN", x => x.IDNV);
                });

            migrationBuilder.CreateTable(
                name: "OVERTIME",
                columns: table => new
                {
                    IDOT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPC = table.Column<int>(type: "int", nullable: true),
                    SOGIO = table.Column<int>(type: "int", nullable: true),
                    HESOLUONG = table.Column<double>(type: "float", nullable: true),
                    SOTIEN = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OVERTIME", x => x.IDOT);
                });

            migrationBuilder.CreateTable(
                name: "PHUCLOI",
                columns: table => new
                {
                    IDPL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOAIPHUCLOI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NGAY = table.Column<DateOnly>(type: "date", nullable: true),
                    SOTIEN = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHUCLOI", x => x.IDPL);
                });

            migrationBuilder.CreateTable(
                name: "BAOHIEM",
                columns: table => new
                {
                    IDBH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDNV = table.Column<int>(type: "int", nullable: true),
                    SOBH = table.Column<int>(type: "int", nullable: true),
                    NGAYCAP = table.Column<DateOnly>(type: "date", nullable: true),
                    NOICAP = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    THOIHAN = table.Column<DateOnly>(type: "date", nullable: true),
                    NOIKHAMBENH = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BAOHIEM", x => x.IDBH);
                    table.ForeignKey(
                        name: "FK_BAOHIEM_NHANVIEN_IDNV",
                        column: x => x.IDNV,
                        principalTable: "NHANVIEN",
                        principalColumn: "IDNV");
                });

            migrationBuilder.CreateTable(
                name: "HOPDONG",
                columns: table => new
                {
                    IDHD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENHP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NGAYBATDAU = table.Column<DateOnly>(type: "date", nullable: true),
                    NGAYKETTHUC = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NGAYKY = table.Column<DateOnly>(type: "date", nullable: true),
                    IDNV = table.Column<int>(type: "int", nullable: true),
                    NGUOILAMHOPDONG = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IDLUONG = table.Column<int>(type: "int", nullable: true),
                    HESOLUONG = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HOPDONG", x => x.IDHD);
                    table.ForeignKey(
                        name: "FK_HOPDONG_NHANVIEN_IDNV",
                        column: x => x.IDNV,
                        principalTable: "NHANVIEN",
                        principalColumn: "IDNV");
                });

            migrationBuilder.CreateTable(
                name: "PHONGBAN",
                columns: table => new
                {
                    IDPB = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENPB = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IDNV = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHONGBAN", x => x.IDPB);
                    table.ForeignKey(
                        name: "FK_PHONGBAN_NHANVIEN_IDNV",
                        column: x => x.IDNV,
                        principalTable: "NHANVIEN",
                        principalColumn: "IDNV");
                });

            migrationBuilder.CreateTable(
                name: "TAISAN",
                columns: table => new
                {
                    IDTS = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENTS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NGAYNHAN = table.Column<DateOnly>(type: "date", nullable: true),
                    NGAYTRA = table.Column<DateOnly>(type: "date", nullable: true),
                    TINHTRANG = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    GIATRITAISAN = table.Column<double>(type: "float", nullable: true),
                    IDNV = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAISAN", x => x.IDTS);
                    table.ForeignKey(
                        name: "FK_TAISAN_NHANVIEN_IDNV",
                        column: x => x.IDNV,
                        principalTable: "NHANVIEN",
                        principalColumn: "IDNV");
                });

            migrationBuilder.CreateTable(
                name: "PHUCAP",
                columns: table => new
                {
                    IDPC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOAIPHUCAP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IDOT = table.Column<int>(type: "int", nullable: true),
                    NGAY = table.Column<DateOnly>(type: "date", nullable: true),
                    SOTIEN = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHUCAP", x => x.IDPC);
                    table.ForeignKey(
                        name: "FK_PHUCAP_OVERTIME_IDOT",
                        column: x => x.IDOT,
                        principalTable: "OVERTIME",
                        principalColumn: "IDOT");
                });

            migrationBuilder.CreateTable(
                name: "CHUCDANH",
                columns: table => new
                {
                    IDCD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENCD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IDPB = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHUCDANH", x => x.IDCD);
                    table.ForeignKey(
                        name: "FK_CHUCDANH_PHONGBAN_IDPB",
                        column: x => x.IDPB,
                        principalTable: "PHONGBAN",
                        principalColumn: "IDPB");
                });

            migrationBuilder.CreateTable(
                name: "LUONG",
                columns: table => new
                {
                    IDLUONG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDHD = table.Column<int>(type: "int", nullable: true),
                    THANG = table.Column<int>(type: "int", nullable: true),
                    NGAYCONG = table.Column<int>(type: "int", nullable: true),
                    NGAYNGHI = table.Column<int>(type: "int", nullable: true),
                    NGAYDENMUON = table.Column<int>(type: "int", nullable: true),
                    NGAYVESOM = table.Column<int>(type: "int", nullable: true),
                    NGUOIDUYET = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IDNH = table.Column<int>(type: "int", nullable: true),
                    TIENTHUONG = table.Column<double>(type: "float", nullable: true),
                    TIENPHAT = table.Column<double>(type: "float", nullable: true),
                    HESOLUONG = table.Column<double>(type: "float", nullable: true),
                    LUONGCB = table.Column<double>(type: "float", nullable: true),
                    TONGLUONG = table.Column<double>(type: "float", nullable: true),
                    IDPC = table.Column<int>(type: "int", nullable: true),
                    IDPL = table.Column<int>(type: "int", nullable: true),
                    IDKTKL = table.Column<int>(type: "int", nullable: true),
                    IDNGHI = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LUONG", x => x.IDLUONG);
                    table.ForeignKey(
                        name: "FK_LUONG_HOPDONG_IDHD",
                        column: x => x.IDHD,
                        principalTable: "HOPDONG",
                        principalColumn: "IDHD");
                    table.ForeignKey(
                        name: "FK_LUONG_KHENTHUONG_KYLUAT_IDKTKL",
                        column: x => x.IDKTKL,
                        principalTable: "KHENTHUONG_KYLUAT",
                        principalColumn: "IDKTKL");
                    table.ForeignKey(
                        name: "FK_LUONG_NGANHANG_IDNH",
                        column: x => x.IDNH,
                        principalTable: "NGANHANG",
                        principalColumn: "IDNH");
                    table.ForeignKey(
                        name: "FK_LUONG_NGHIVIEC_IDNGHI",
                        column: x => x.IDNGHI,
                        principalTable: "NGHIVIEC",
                        principalColumn: "IDNGHI");
                    table.ForeignKey(
                        name: "FK_LUONG_PHUCAP_IDPC",
                        column: x => x.IDPC,
                        principalTable: "PHUCAP",
                        principalColumn: "IDPC");
                    table.ForeignKey(
                        name: "FK_LUONG_PHUCLOI_IDPC",
                        column: x => x.IDPC,
                        principalTable: "PHUCLOI",
                        principalColumn: "IDPL");
                });

            migrationBuilder.CreateTable(
                name: "CHUCVU",
                columns: table => new
                {
                    IDCV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENCV = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IDCD = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHUCVU", x => x.IDCV);
                    table.ForeignKey(
                        name: "FK_CHUCVU_CHUCDANH_IDCD",
                        column: x => x.IDCD,
                        principalTable: "CHUCDANH",
                        principalColumn: "IDCD");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BAOHIEM_IDNV",
                table: "BAOHIEM",
                column: "IDNV");

            migrationBuilder.CreateIndex(
                name: "IX_CHUCDANH_IDPB",
                table: "CHUCDANH",
                column: "IDPB");

            migrationBuilder.CreateIndex(
                name: "IX_CHUCVU_IDCD",
                table: "CHUCVU",
                column: "IDCD");

            migrationBuilder.CreateIndex(
                name: "IX_HOPDONG_IDNV",
                table: "HOPDONG",
                column: "IDNV");

            migrationBuilder.CreateIndex(
                name: "IX_LUONG_IDHD",
                table: "LUONG",
                column: "IDHD");

            migrationBuilder.CreateIndex(
                name: "IX_LUONG_IDKTKL",
                table: "LUONG",
                column: "IDKTKL");

            migrationBuilder.CreateIndex(
                name: "IX_LUONG_IDNGHI",
                table: "LUONG",
                column: "IDNGHI");

            migrationBuilder.CreateIndex(
                name: "IX_LUONG_IDNH",
                table: "LUONG",
                column: "IDNH");

            migrationBuilder.CreateIndex(
                name: "IX_LUONG_IDPC",
                table: "LUONG",
                column: "IDPC");

            migrationBuilder.CreateIndex(
                name: "IX_PHONGBAN_IDNV",
                table: "PHONGBAN",
                column: "IDNV");

            migrationBuilder.CreateIndex(
                name: "IX_PHUCAP_IDOT",
                table: "PHUCAP",
                column: "IDOT");

            migrationBuilder.CreateIndex(
                name: "IX_TAISAN_IDNV",
                table: "TAISAN",
                column: "IDNV");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BAOHIEM");

            migrationBuilder.DropTable(
                name: "CHUCVU");

            migrationBuilder.DropTable(
                name: "LUONG");

            migrationBuilder.DropTable(
                name: "TAISAN");

            migrationBuilder.DropTable(
                name: "CHUCDANH");

            migrationBuilder.DropTable(
                name: "HOPDONG");

            migrationBuilder.DropTable(
                name: "KHENTHUONG_KYLUAT");

            migrationBuilder.DropTable(
                name: "NGANHANG");

            migrationBuilder.DropTable(
                name: "NGHIVIEC");

            migrationBuilder.DropTable(
                name: "PHUCAP");

            migrationBuilder.DropTable(
                name: "PHUCLOI");

            migrationBuilder.DropTable(
                name: "PHONGBAN");

            migrationBuilder.DropTable(
                name: "OVERTIME");

            migrationBuilder.DropTable(
                name: "NHANVIEN");
        }
    }
}
