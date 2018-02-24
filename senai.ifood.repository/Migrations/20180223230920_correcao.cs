using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace senai.ifood.repository.Migrations
{
    public partial class correcao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosPermissoes_Permissoes_PermisaoId",
                table: "UsuariosPermissoes");

            migrationBuilder.DropIndex(
                name: "IX_UsuariosPermissoes_PermisaoId",
                table: "UsuariosPermissoes");

            migrationBuilder.DropColumn(
                name: "PermisaoId",
                table: "UsuariosPermissoes");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosPermissoes_PermissaoId",
                table: "UsuariosPermissoes",
                column: "PermissaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosPermissoes_Permissoes_PermissaoId",
                table: "UsuariosPermissoes",
                column: "PermissaoId",
                principalTable: "Permissoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosPermissoes_Permissoes_PermissaoId",
                table: "UsuariosPermissoes");

            migrationBuilder.DropIndex(
                name: "IX_UsuariosPermissoes_PermissaoId",
                table: "UsuariosPermissoes");

            migrationBuilder.AddColumn<int>(
                name: "PermisaoId",
                table: "UsuariosPermissoes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosPermissoes_PermisaoId",
                table: "UsuariosPermissoes",
                column: "PermisaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosPermissoes_Permissoes_PermisaoId",
                table: "UsuariosPermissoes",
                column: "PermisaoId",
                principalTable: "Permissoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
