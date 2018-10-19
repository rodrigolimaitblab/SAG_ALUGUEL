using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudEF_Console.Migrations
{
    public partial class NovoMundo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    departamento_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    descricao = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.departamento_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Idioma",
                columns: table => new
                {
                    idioma_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    descricao = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Idioma", x => x.idioma_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Veiculo_Publicacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    tipo = table.Column<string>(type: "varchar(25)", nullable: false),
                    descricao = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Veiculo_Publicacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pesquisadores",
                columns: table => new
                {
                    pesquisador_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    departamento_id = table.Column<int>(nullable: false),
                    nome = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pesquisadores", x => x.pesquisador_id);
                    table.ForeignKey(
                        name: "FK_Pesquisadores_Departamento_departamento_id",
                        column: x => x.departamento_id,
                        principalTable: "Departamento",
                        principalColumn: "departamento_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Artigo",
                columns: table => new
                {
                    artigo_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    idioma_original = table.Column<int>(nullable: false),
                    idioma_traduzido = table.Column<int>(nullable: true),
                    veiculo_publicacao_id = table.Column<int>(nullable: true),
                    titulo = table.Column<string>(maxLength: 50, nullable: false),
                    ano = table.Column<int>(type: "int", nullable: false),
                    pesquisador_id = table.Column<int>(nullable: false),
                    datapublicacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    ISBN = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artigo", x => x.artigo_id);
                    table.ForeignKey(
                        name: "FK_Artigo_tbl_Idioma_idioma_original",
                        column: x => x.idioma_original,
                        principalTable: "tbl_Idioma",
                        principalColumn: "idioma_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Artigo_tbl_Idioma_idioma_traduzido",
                        column: x => x.idioma_traduzido,
                        principalTable: "tbl_Idioma",
                        principalColumn: "idioma_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Artigo_Pesquisadores_pesquisador_id",
                        column: x => x.pesquisador_id,
                        principalTable: "Pesquisadores",
                        principalColumn: "pesquisador_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Artigo_tbl_Veiculo_Publicacao_veiculo_publicacao_id",
                        column: x => x.veiculo_publicacao_id,
                        principalTable: "tbl_Veiculo_Publicacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    tipo = table.Column<string>(nullable: true),
                    texto = table.Column<string>(nullable: true),
                    pesquisador_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contato_Pesquisadores_pesquisador_id",
                        column: x => x.pesquisador_id,
                        principalTable: "Pesquisadores",
                        principalColumn: "pesquisador_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artigo_idioma_original",
                table: "Artigo",
                column: "idioma_original");

            migrationBuilder.CreateIndex(
                name: "IX_Artigo_idioma_traduzido",
                table: "Artigo",
                column: "idioma_traduzido");

            migrationBuilder.CreateIndex(
                name: "IX_Artigo_pesquisador_id",
                table: "Artigo",
                column: "pesquisador_id");

            migrationBuilder.CreateIndex(
                name: "IX_Artigo_veiculo_publicacao_id",
                table: "Artigo",
                column: "veiculo_publicacao_id");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_pesquisador_id",
                table: "Contato",
                column: "pesquisador_id");

            migrationBuilder.CreateIndex(
                name: "IX_Pesquisadores_departamento_id",
                table: "Pesquisadores",
                column: "departamento_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artigo");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "tbl_Idioma");

            migrationBuilder.DropTable(
                name: "tbl_Veiculo_Publicacao");

            migrationBuilder.DropTable(
                name: "Pesquisadores");

            migrationBuilder.DropTable(
                name: "Departamento");
        }
    }
}
