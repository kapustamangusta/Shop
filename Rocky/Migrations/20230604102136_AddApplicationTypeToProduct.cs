using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rocky.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationTypeToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "application_id",
                table: "product",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "application_type_Id",
                table: "product",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_product_application_type_Id",
                table: "product",
                column: "application_type_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_product_application_type_application_type_Id",
                table: "product",
                column: "application_type_Id",
                principalTable: "application_type",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_application_type_application_type_Id",
                table: "product");

            migrationBuilder.DropIndex(
                name: "IX_product_application_type_Id",
                table: "product");

            migrationBuilder.DropColumn(
                name: "application_id",
                table: "product");

            migrationBuilder.DropColumn(
                name: "application_type_Id",
                table: "product");
        }
    }
}
