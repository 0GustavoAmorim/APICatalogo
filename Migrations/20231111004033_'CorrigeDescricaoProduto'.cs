﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class CorrigeDescricaoProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descrição",
                table: "Produtos",
                newName: "Descricao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Produtos",
                newName: "Descrição");
        }
    }
}
