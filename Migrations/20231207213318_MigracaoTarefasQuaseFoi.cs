using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Organization_List.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoTarefasQuaseFoi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TB_TAREFAS",
                keyColumn: "IdTarefa",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2023, 12, 7, 18, 33, 17, 932, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "TB_TAREFAS",
                keyColumn: "IdTarefa",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2023, 12, 7, 18, 33, 17, 932, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "TB_TAREFAS",
                keyColumn: "IdTarefa",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2023, 12, 7, 18, 33, 17, 932, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "TB_TAREFAS",
                keyColumn: "IdTarefa",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2023, 12, 7, 18, 33, 17, 932, DateTimeKind.Local).AddTicks(155));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TB_TAREFAS",
                keyColumn: "IdTarefa",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2023, 12, 7, 17, 35, 39, 560, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "TB_TAREFAS",
                keyColumn: "IdTarefa",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2023, 12, 7, 17, 35, 39, 560, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "TB_TAREFAS",
                keyColumn: "IdTarefa",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2023, 12, 7, 17, 35, 39, 560, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "TB_TAREFAS",
                keyColumn: "IdTarefa",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2023, 12, 7, 17, 35, 39, 560, DateTimeKind.Local).AddTicks(8363));
        }
    }
}
