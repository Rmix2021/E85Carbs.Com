using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E85Carbs.WebServer.Migrations
{
    public partial class AddedColumnTypeMedBlob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "MainProductImage",
                table: "Products",
                type: "MediumBlob",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(4000)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "MainProductImage",
                table: "Products",
                type: "varbinary(4000)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "MediumBlob");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "e5b4c203-bafc-4d6e-86ed-46201ad62eb6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9aba6098-e3ea-4270-8296-e2de61016138", "AQAAAAEAACcQAAAAEIxgchOeJqavd5Ol84htoDSlh9y8h2DAeAjHcqa2Zv2LaKPakH0H7alPMDL7d6UgvQ==", "2e7ad0e8-7245-4c76-9ca1-03c4288d8411" });
        }
    }
}
