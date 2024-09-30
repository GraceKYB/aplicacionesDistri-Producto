using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Login.Migrations
{
    public partial class MigracionSi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatNombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Subcategorias",
                columns: table => new
                {
                    SubcId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubcNombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategorias", x => x.SubcId);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProNombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProDescripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ProPrecio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProStock = table.Column<int>(type: "int", nullable: false),
                    ProImagen = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CatId = table.Column<int>(type: "int", nullable: false),
                    SubcId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProId);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_CatId",
                        column: x => x.CatId,
                        principalTable: "Categorias",
                        principalColumn: "CatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Subcategorias_SubcId",
                        column: x => x.SubcId,
                        principalTable: "Subcategorias",
                        principalColumn: "SubcId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CatId",
                table: "Productos",
                column: "CatId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_SubcId",
                table: "Productos",
                column: "SubcId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Subcategorias");
        }
    }
}
