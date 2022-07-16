using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pools_Markers_Id",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Markers_Pools_Id",
                schema: "dbo",
                table: "Markers");

            migrationBuilder.AddForeignKey(
                name: "FK_Pools_Markers_Id",
                schema: "dbo",
                table: "Pools",
                column: "Id",
                principalSchema: "dbo",
                principalTable: "Markers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
