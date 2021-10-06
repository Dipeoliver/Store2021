using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store2021.Migrations
{
    public partial class AddClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "SalesRecord",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Obs",
                table: "SalesRecord",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Payment",
                table: "SalesRecord",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Document = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalesRecord_ClientId",
                table: "SalesRecord",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Client_ClientId",
                table: "SalesRecord",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Client_ClientId",
                table: "SalesRecord");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropIndex(
                name: "IX_SalesRecord_ClientId",
                table: "SalesRecord");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "SalesRecord");

            migrationBuilder.DropColumn(
                name: "Obs",
                table: "SalesRecord");

            migrationBuilder.DropColumn(
                name: "Payment",
                table: "SalesRecord");
        }
    }
}
