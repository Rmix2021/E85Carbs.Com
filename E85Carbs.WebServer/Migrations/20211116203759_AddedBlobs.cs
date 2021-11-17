using Microsoft.EntityFrameworkCore.Migrations;

namespace E85Carbs.WebServer.Migrations
{
    public partial class AddedBlobs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildGalleryImage_CustomerBuild_CustomerBuildId",
                table: "BuildGalleryImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerBuild",
                table: "CustomerBuild");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuildGalleryImage",
                table: "BuildGalleryImage");

            migrationBuilder.RenameTable(
                name: "CustomerBuild",
                newName: "customerBuilds");

            migrationBuilder.RenameTable(
                name: "BuildGalleryImage",
                newName: "buildGalleryImages");

            migrationBuilder.RenameIndex(
                name: "IX_BuildGalleryImage_CustomerBuildId",
                table: "buildGalleryImages",
                newName: "IX_buildGalleryImages_CustomerBuildId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customerBuilds",
                table: "customerBuilds",
                column: "CustomerBuildId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_buildGalleryImages",
                table: "buildGalleryImages",
                column: "BuildGalleryImageId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "dc4f3ef8-9444-4564-a53b-820168ef9fdd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a24fc78-11e0-4efc-bd32-afa8e612ed0c", "AQAAAAEAACcQAAAAEJXJIpazqS657bXebf/IjZUlBwxqGnupwSj3wnEQEbRW1UhG1aXluEv7FKKb7vIxjQ==", "22455d3f-c7bd-4004-886c-20eaf4a2917a" });

            migrationBuilder.AddForeignKey(
                name: "FK_buildGalleryImages_customerBuilds_CustomerBuildId",
                table: "buildGalleryImages",
                column: "CustomerBuildId",
                principalTable: "customerBuilds",
                principalColumn: "CustomerBuildId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_buildGalleryImages_customerBuilds_CustomerBuildId",
                table: "buildGalleryImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customerBuilds",
                table: "customerBuilds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_buildGalleryImages",
                table: "buildGalleryImages");

            migrationBuilder.RenameTable(
                name: "customerBuilds",
                newName: "CustomerBuild");

            migrationBuilder.RenameTable(
                name: "buildGalleryImages",
                newName: "BuildGalleryImage");

            migrationBuilder.RenameIndex(
                name: "IX_buildGalleryImages_CustomerBuildId",
                table: "BuildGalleryImage",
                newName: "IX_BuildGalleryImage_CustomerBuildId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerBuild",
                table: "CustomerBuild",
                column: "CustomerBuildId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuildGalleryImage",
                table: "BuildGalleryImage",
                column: "BuildGalleryImageId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_BuildGalleryImage_CustomerBuild_CustomerBuildId",
                table: "BuildGalleryImage",
                column: "CustomerBuildId",
                principalTable: "CustomerBuild",
                principalColumn: "CustomerBuildId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
