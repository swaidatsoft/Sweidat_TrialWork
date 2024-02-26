using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.EF.Migrations
{
    /// <inheritdoc />
    public partial class SecondMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Companys_Company_Id",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Company_Id",
                table: "Users",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Company_Id",
                table: "Users",
                newName: "IX_Users_CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Companys_CompanyId",
                table: "Users",
                column: "CompanyId",
                principalTable: "Companys",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Companys_CompanyId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Users",
                newName: "Company_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CompanyId",
                table: "Users",
                newName: "IX_Users_Company_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Companys_Company_Id",
                table: "Users",
                column: "Company_Id",
                principalTable: "Companys",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
