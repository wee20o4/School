using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JOBBVU.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BangLuongs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuongToiDa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LuongToiThieu = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangLuongs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiaChis",
                columns: table => new
                {
                    MaDiaChi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TinhThanh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuanHuyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhuongXa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChiTiet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaChis", x => x.MaDiaChi);
                });

            migrationBuilder.CreateTable(
                name: "LienHes",
                columns: table => new
                {
                    MaLienHe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LienHes", x => x.MaLienHe);
                });

            migrationBuilder.CreateTable(
                name: "CongTys",
                columns: table => new
                {
                    MaCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCTY = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MaLienHe = table.Column<int>(type: "int", nullable: false),
                    MaDiaChi = table.Column<int>(type: "int", nullable: false),
                    LoaiHinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayThanhLap = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongTys", x => x.MaCT);
                    table.ForeignKey(
                        name: "FK_CongTys_DiaChis_MaDiaChi",
                        column: x => x.MaDiaChi,
                        principalTable: "DiaChis",
                        principalColumn: "MaDiaChi",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CongTys_LienHes_MaLienHe",
                        column: x => x.MaLienHe,
                        principalTable: "LienHes",
                        principalColumn: "MaLienHe",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDungs",
                columns: table => new
                {
                    MaNguoiDung = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoaiNguoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaLienHe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDungs", x => x.MaNguoiDung);
                    table.ForeignKey(
                        name: "FK_NguoiDungs_LienHes_MaLienHe",
                        column: x => x.MaLienHe,
                        principalTable: "LienHes",
                        principalColumn: "MaLienHe",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TuyenDungs",
                columns: table => new
                {
                    MaNTD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MaLienHe = table.Column<int>(type: "int", nullable: false),
                    MaCongTy = table.Column<int>(type: "int", nullable: false),
                    TrangThaiNTD = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuyenDungs", x => x.MaNTD);
                    table.ForeignKey(
                        name: "FK_TuyenDungs_CongTys_MaCongTy",
                        column: x => x.MaCongTy,
                        principalTable: "CongTys",
                        principalColumn: "MaCT",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TuyenDungs_LienHes_MaLienHe",
                        column: x => x.MaLienHe,
                        principalTable: "LienHes",
                        principalColumn: "MaLienHe",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "HoSoUngViens",
                columns: table => new
                {
                    MaHoSo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNguoiDung = table.Column<int>(type: "int", nullable: false),
                    KinhNghiem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BangCap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KyNang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoSoUngViens", x => x.MaHoSo);
                    table.ForeignKey(
                        name: "FK_HoSoUngViens_BangLuongs_MaLuong",
                        column: x => x.MaLuong,
                        principalTable: "BangLuongs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoSoUngViens_NguoiDungs_MaNguoiDung",
                        column: x => x.MaNguoiDung,
                        principalTable: "NguoiDungs",
                        principalColumn: "MaNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CongViecs",
                columns: table => new
                {
                    MaCV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieuDe = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YeuCau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaLuong = table.Column<int>(type: "int", nullable: false),
                    MaDiaChi = table.Column<int>(type: "int", nullable: false),
                    MaNTD = table.Column<int>(type: "int", nullable: false),
                    NgayDang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HanNop = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongViecs", x => x.MaCV);
                    table.ForeignKey(
                        name: "FK_CongViecs_BangLuongs_MaLuong",
                        column: x => x.MaLuong,
                        principalTable: "BangLuongs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CongViecs_DiaChis_MaDiaChi",
                        column: x => x.MaDiaChi,
                        principalTable: "DiaChis",
                        principalColumn: "MaDiaChi",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CongViecs_TuyenDungs_MaNTD",
                        column: x => x.MaNTD,
                        principalTable: "TuyenDungs",
                        principalColumn: "MaNTD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CongTys_MaDiaChi",
                table: "CongTys",
                column: "MaDiaChi");

            migrationBuilder.CreateIndex(
                name: "IX_CongTys_MaLienHe",
                table: "CongTys",
                column: "MaLienHe");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecs_MaDiaChi",
                table: "CongViecs",
                column: "MaDiaChi");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecs_MaLuong",
                table: "CongViecs",
                column: "MaLuong");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecs_MaNTD",
                table: "CongViecs",
                column: "MaNTD");

            migrationBuilder.CreateIndex(
                name: "IX_HoSoUngViens_MaLuong",
                table: "HoSoUngViens",
                column: "MaLuong");

            migrationBuilder.CreateIndex(
                name: "IX_HoSoUngViens_MaNguoiDung",
                table: "HoSoUngViens",
                column: "MaNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDungs_MaLienHe",
                table: "NguoiDungs",
                column: "MaLienHe");

            migrationBuilder.CreateIndex(
                name: "IX_TuyenDungs_MaCongTy",
                table: "TuyenDungs",
                column: "MaCongTy");

            migrationBuilder.CreateIndex(
                name: "IX_TuyenDungs_MaLienHe",
                table: "TuyenDungs",
                column: "MaLienHe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CongViecs");

            migrationBuilder.DropTable(
                name: "HoSoUngViens");

            migrationBuilder.DropTable(
                name: "TuyenDungs");

            migrationBuilder.DropTable(
                name: "BangLuongs");

            migrationBuilder.DropTable(
                name: "NguoiDungs");

            migrationBuilder.DropTable(
                name: "CongTys");

            migrationBuilder.DropTable(
                name: "DiaChis");

            migrationBuilder.DropTable(
                name: "LienHes");
        }
    }
}
