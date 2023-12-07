using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Organization_List.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoTarefasFoi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TB_TAREFAS",
                columns: new[] { "IdTarefa", "DataCriacao", "DescTarefa", "NomeTarefa", "StatusTarefa", "TarefaClass" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 7, 17, 35, 39, 560, DateTimeKind.Local).AddTicks(8357), "Passear Com o Tobias no parque pois está um dia lindo", "Passear com o Cachorro", false, 1 },
                    { 2, new DateTime(2023, 12, 7, 17, 35, 39, 560, DateTimeKind.Local).AddTicks(8360), "Fazer o almoço para a mamãe", "Fazer o almoço", false, 2 },
                    { 3, new DateTime(2023, 12, 7, 17, 35, 39, 560, DateTimeKind.Local).AddTicks(8361), "Estudar para a prova de matemática", "Estudar", false, 3 },
                    { 4, new DateTime(2023, 12, 7, 17, 35, 39, 560, DateTimeKind.Local).AddTicks(8363), "Fazer o trabalho de história", "Fazer o trabalho", false, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TB_TAREFAS",
                keyColumn: "IdTarefa",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TB_TAREFAS",
                keyColumn: "IdTarefa",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TB_TAREFAS",
                keyColumn: "IdTarefa",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TB_TAREFAS",
                keyColumn: "IdTarefa",
                keyValue: 4);
        }
    }
}
