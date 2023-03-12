using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothingStore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class BaseDimensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NamesDimensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NamesDimensions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypesHumans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesHumans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypesDimensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typeId = table.Column<int>(type: "int", nullable: true),
                    typeHumanId = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesDimensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypesDimensions_TypesHumans_typeHumanId",
                        column: x => x.typeHumanId,
                        principalTable: "TypesHumans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_TypesDimensions_Types_typeId",
                        column: x => x.typeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Dimensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typeDimensionsId = table.Column<int>(type: "int", nullable: true),
                    nameDimensionsId = table.Column<int>(type: "int", nullable: true),
                    MinSize = table.Column<int>(type: "int", nullable: false),
                    MaxSize = table.Column<int>(type: "int", nullable: false),
                    StringSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dimensions_NamesDimensions_nameDimensionsId",
                        column: x => x.nameDimensionsId,
                        principalTable: "NamesDimensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Dimensions_TypesDimensions_typeDimensionsId",
                        column: x => x.typeDimensionsId,
                        principalTable: "TypesDimensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_nameDimensionsId",
                table: "Dimensions",
                column: "nameDimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_typeDimensionsId",
                table: "Dimensions",
                column: "typeDimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_TypesDimensions_typeHumanId",
                table: "TypesDimensions",
                column: "typeHumanId");

            migrationBuilder.CreateIndex(
                name: "IX_TypesDimensions_typeId",
                table: "TypesDimensions",
                column: "typeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.DropTable(
                name: "NamesDimensions");

            migrationBuilder.DropTable(
                name: "TypesDimensions");

            migrationBuilder.DropTable(
                name: "TypesHumans");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
