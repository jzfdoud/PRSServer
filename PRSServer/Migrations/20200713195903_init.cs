using Microsoft.EntityFrameworkCore.Migrations;

namespace PRSServer.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 30, nullable: false),
                    Password = table.Column<string>(maxLength: 30, nullable: false),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    Phone = table.Column<string>(maxLength: 12, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    IsReviewer = table.Column<bool>(nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Address = table.Column<string>(maxLength: 30, nullable: false),
                    City = table.Column<string>(maxLength: 30, nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: false),
                    Zip = table.Column<string>(maxLength: 5, nullable: false),
                    Phone = table.Column<string>(maxLength: 12, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartNbr = table.Column<string>(maxLength: 30, nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Unit = table.Column<string>(maxLength: 15, nullable: false),
                    PhotoPath = table.Column<string>(maxLength: 225, nullable: false),
                    VendorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_VendorId",
                table: "Product",
                column: "VendorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Vendor");
        }
    }
}
