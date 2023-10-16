using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaisSabor.Migrations
{
    /// <inheritdoc />
    public partial class carrinhoitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescricaoLonga",
                table: "Items");

            migrationBuilder.CreateTable(
                name: "CarrinhoItens",
                columns: table => new
                {
                    CarrinhoItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    CarrinhoId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoItens", x => x.CarrinhoItemId);
                    table.ForeignKey(
                        name: "FK_CarrinhoItens_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoItens_ItemId",
                table: "CarrinhoItens",
                column: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoItens");

            migrationBuilder.AddColumn<string>(
                name: "DescricaoLonga",
                table: "Items",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
