using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Markers_Pools_Id",
                schema: "dbo",
                table: "Markers");

            migrationBuilder.AddColumn<Guid>(
                name: "MarkerId1",
                schema: "dbo",
                table: "Pools",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pools_MarkerId1",
                schema: "dbo",
                table: "Pools",
                column: "MarkerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Pools_Markers_MarkerId1",
                schema: "dbo",
                table: "Pools",
                column: "MarkerId1",
                principalSchema: "dbo",
                principalTable: "Markers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pools_Markers_MarkerId1",
                schema: "dbo",
                table: "Pools");

            migrationBuilder.DropIndex(
                name: "IX_Pools_MarkerId1",
                schema: "dbo",
                table: "Pools");

            migrationBuilder.DropColumn(
                name: "MarkerId1",
                schema: "dbo",
                table: "Pools");

            migrationBuilder.AddForeignKey(
                name: "FK_Markers_Pools_Id",
                schema: "dbo",
                table: "Markers",
                column: "Id",
                principalSchema: "dbo",
                principalTable: "Pools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
