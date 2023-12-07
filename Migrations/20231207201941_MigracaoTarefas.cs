using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Organization_List.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoTarefas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TarefaClass",
                table: "TB_TAREFAS",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TarefaClass",
                table: "TB_TAREFAS");
        }
    }
}
