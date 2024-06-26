using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleEmailService.Migrations
{
    /// <inheritdoc />
    public partial class InitialSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SMTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnableSSL = table.Column<bool>(type: "bit", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Port = table.Column<int>(type: "int", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailSettings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EmailSettings",
                columns: new[] { "Id", "CreateDate", "DisplayName", "EnableSSL", "From", "IsDefault", "IsDelete", "Password", "Port", "SMTP" },
                values: new object[] { 1, new DateTime(2024, 6, 26, 18, 39, 25, 468, DateTimeKind.Local).AddTicks(3683), "Email Service", true, "artan.co.5827@gmail.com", true, false, "hvsssvjtdaeunevp", 587, "smtp.gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailSettings");
        }
    }
}
