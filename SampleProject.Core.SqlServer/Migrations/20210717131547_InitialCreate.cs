using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleProject.Core.SqlServer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticleCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArticleCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_ArticleCategories_ArticleCategoryId",
                        column: x => x.ArticleCategoryId,
                        principalTable: "ArticleCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "Id", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Title" },
                values: new object[] { 1, new DateTime(2021, 7, 17, 17, 45, 46, 429, DateTimeKind.Local).AddTicks(4721), null, null, null, "Domain Driven Design" });

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "Id", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Title" },
                values: new object[] { 2, new DateTime(2021, 7, 17, 17, 45, 46, 434, DateTimeKind.Local).AddTicks(7992), null, null, null, "Asp Core" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleCategoryId", "Content", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "ShortDescription", "Title" },
                values: new object[] { 1, 1, "Value Object in Domain Driven Design", new DateTime(2021, 7, 17, 17, 45, 46, 465, DateTimeKind.Local).AddTicks(8048), null, null, null, "Value Object in Domain Driven Design", "Value Object" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleCategoryId", "Content", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "ShortDescription", "Title" },
                values: new object[] { 2, 1, "Domian Event in Domain Driven Design", new DateTime(2021, 7, 17, 17, 45, 46, 465, DateTimeKind.Local).AddTicks(9402), null, null, null, "Domian Event in Domain Driven Design", "Domian Event" });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleCategoryId",
                table: "Articles",
                column: "ArticleCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "ArticleCategories");
        }
    }
}
