using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace E85Carbs.WebServer.Migrations
{
    public partial class AddedColumnTypeMedBlobx2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "ProductGalleryByte",
                table: "productGalleryImages",
                type: "MediumBlob",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(4000)");

            migrationBuilder.CreateTable(
                name: "CustomerBuild",
                columns: table => new
                {
                    CustomerBuildId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CustomerName = table.Column<string>(type: "text", nullable: false),
                    CustomerBuildTitle = table.Column<string>(type: "text", nullable: false),
                    CustomerBuildDescription = table.Column<string>(type: "text", nullable: false),
                    MainBuildImage = table.Column<byte[]>(type: "MediumBlob", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBuild", x => x.CustomerBuildId);
                });

            migrationBuilder.CreateTable(
                name: "BuildGalleryImage",
                columns: table => new
                {
                    BuildGalleryImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BuildGalleryImageName = table.Column<string>(type: "text", nullable: false),
                    BuildGalleryByte = table.Column<byte[]>(type: "varbinary(4000)", nullable: false),
                    CustomerBuildId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildGalleryImage", x => x.BuildGalleryImageId);
                    table.ForeignKey(
                        name: "FK_BuildGalleryImage_CustomerBuild_CustomerBuildId",
                        column: x => x.CustomerBuildId,
                        principalTable: "CustomerBuild",
                        principalColumn: "CustomerBuildId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "b23d58c2-36b1-44a1-a782-fdf8795c1956");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88545b7c-2cca-4040-bc8a-6a87bf26895a", "AQAAAAEAACcQAAAAEPpMMmtgDuLMIhMV5D3oSdfcuQmu7QoUsIZMywvTOSyebt34HgiamOUnEQzLH/rFtg==", "5c9ed07e-e7ae-4f19-b5c6-1f76f575f9c1" });

            migrationBuilder.CreateIndex(
                name: "IX_BuildGalleryImage_CustomerBuildId",
                table: "BuildGalleryImage",
                column: "CustomerBuildId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildGalleryImage");

            migrationBuilder.DropTable(
                name: "CustomerBuild");

            migrationBuilder.AlterColumn<byte[]>(
                name: "ProductGalleryByte",
                table: "productGalleryImages",
                type: "varbinary(4000)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "MediumBlob");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "5bed0965-3c3c-4673-83e1-9db3e8ea50eb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "659e1f0f-8286-4b54-a8f6-a97f47c31008", "AQAAAAEAACcQAAAAEB9rLDqvMCTaFo3GEdCZH3kQbfcy8x/QoULaOeXqF44YfbCePwVDbu72Z1zSXdeehQ==", "91e2fc3e-3045-4f27-b79f-aef17db81acc" });
        }
    }
}
