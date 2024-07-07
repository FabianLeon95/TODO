using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TODO.Infrastructure.Database.Migrations
{
    /// <inheritdoc />
    public partial class TodoListUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripcion1",
                table: "TodoLists",
                newName: "Descripcion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "TodoLists",
                newName: "Descripcion1");
        }
    }
}
