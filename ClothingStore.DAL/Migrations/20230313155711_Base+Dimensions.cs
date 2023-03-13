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
                    color = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NamesCriteriaOfDimensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NamesCriteriaOfDimensions", x => x.Id);
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
                name: "UnionNamesAndDimensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamesDimensionsId = table.Column<int>(type: "int", nullable: true),
                    typeDimensionsId = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnionNamesAndDimensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnionNamesAndDimensions_NamesDimensions_NamesDimensionsId",
                        column: x => x.NamesDimensionsId,
                        principalTable: "NamesDimensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_UnionNamesAndDimensions_TypesDimensions_typeDimensionsId",
                        column: x => x.typeDimensionsId,
                        principalTable: "TypesDimensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "UnionNamesCriteriaOfDimensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamesCriteriaOfDimensionsId = table.Column<int>(type: "int", nullable: true),
                    typesDimensionsId = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnionNamesCriteriaOfDimensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnionNamesCriteriaOfDimensions_NamesCriteriaOfDimensions_NamesCriteriaOfDimensionsId",
                        column: x => x.NamesCriteriaOfDimensionsId,
                        principalTable: "NamesCriteriaOfDimensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_UnionNamesCriteriaOfDimensions_TypesDimensions_typesDimensionsId",
                        column: x => x.typesDimensionsId,
                        principalTable: "TypesDimensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    namesDimensionsId = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sizes_UnionNamesAndDimensions_namesDimensionsId",
                        column: x => x.namesDimensionsId,
                        principalTable: "UnionNamesAndDimensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "CriteriaOfDimensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MinSize = table.Column<int>(type: "int", nullable: true),
                    MaxSize = table.Column<int>(type: "int", maxLength: 3, nullable: true),
                    namesCriteriaOfDimensionsId = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriteriaOfDimensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CriteriaOfDimensions_UnionNamesCriteriaOfDimensions_namesCriteriaOfDimensionsId",
                        column: x => x.namesCriteriaOfDimensionsId,
                        principalTable: "UnionNamesCriteriaOfDimensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Dimensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriteriaOfDimensionsId = table.Column<int>(type: "int", nullable: true),
                    sizesId = table.Column<int>(type: "int", nullable: true),
                    UnionNamesAndDimensionsId = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dimensions_CriteriaOfDimensions_CriteriaOfDimensionsId",
                        column: x => x.CriteriaOfDimensionsId,
                        principalTable: "CriteriaOfDimensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Dimensions_Sizes_sizesId",
                        column: x => x.sizesId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Dimensions_UnionNamesAndDimensions_UnionNamesAndDimensionsId",
                        column: x => x.UnionNamesAndDimensionsId,
                        principalTable: "UnionNamesAndDimensions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CriteriaOfDimensions_namesCriteriaOfDimensionsId",
                table: "CriteriaOfDimensions",
                column: "namesCriteriaOfDimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_CriteriaOfDimensionsId",
                table: "Dimensions",
                column: "CriteriaOfDimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_sizesId",
                table: "Dimensions",
                column: "sizesId");

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_UnionNamesAndDimensionsId",
                table: "Dimensions",
                column: "UnionNamesAndDimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_namesDimensionsId",
                table: "Sizes",
                column: "namesDimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_TypesDimensions_typeHumanId",
                table: "TypesDimensions",
                column: "typeHumanId");

            migrationBuilder.CreateIndex(
                name: "IX_TypesDimensions_typeId",
                table: "TypesDimensions",
                column: "typeId");

            migrationBuilder.CreateIndex(
                name: "IX_UnionNamesAndDimensions_NamesDimensionsId",
                table: "UnionNamesAndDimensions",
                column: "NamesDimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_UnionNamesAndDimensions_typeDimensionsId",
                table: "UnionNamesAndDimensions",
                column: "typeDimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_UnionNamesCriteriaOfDimensions_NamesCriteriaOfDimensionsId",
                table: "UnionNamesCriteriaOfDimensions",
                column: "NamesCriteriaOfDimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_UnionNamesCriteriaOfDimensions_typesDimensionsId",
                table: "UnionNamesCriteriaOfDimensions",
                column: "typesDimensionsId");
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
                name: "CriteriaOfDimensions");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "UnionNamesCriteriaOfDimensions");

            migrationBuilder.DropTable(
                name: "UnionNamesAndDimensions");

            migrationBuilder.DropTable(
                name: "NamesCriteriaOfDimensions");

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
