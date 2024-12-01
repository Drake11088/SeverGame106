using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeverGame106.Migrations
{
    /// <inheritdoc />
    public partial class addIsdeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "AspNetUsers",
                newName: "IsDeleted");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "AspNetUsers",
                newName: "IsDelete");
        }
    }
}
