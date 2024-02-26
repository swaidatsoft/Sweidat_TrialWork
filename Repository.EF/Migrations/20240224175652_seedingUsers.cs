using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repository.EF.Migrations
{
    /// <inheritdoc />
    public partial class seedingUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CompanyId", "Confirm_Password", "Email", "FirstName", "Is_AgreeToPrivacy", "Is_AgreeToTerms", "LastName", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, 1, "123654", "a@fake.com", "Demo", false, true, "Demo1", "123654", "DemoFake1" },
                    { 2, 2, "123654", "b@fake.com", "Demo2", false, true, "Demo2", "123654", "DemoFake2" },
                    { 3, 3, "123654", "b@fake.com", "Demo3", false, true, "Demo2 ", "123654", "DemoFake3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);
        }
    }
}
