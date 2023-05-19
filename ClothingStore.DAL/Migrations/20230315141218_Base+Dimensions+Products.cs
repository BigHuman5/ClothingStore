using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothingStore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class BaseDimensionsProducts : Migration
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
                    fakePopularity = table.Column<int>(type: "int", nullable: false),
                    realPopularity = table.Column<int>(type: "int", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActual = table.Column<bool>(type: "bit", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.Id);
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
                name: "UnionCategoryAndTypeHuman",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryId = table.Column<int>(type: "int", nullable: true),
                    typeHumanId = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnionCategoryAndTypeHuman", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnionCategoryAndTypeHuman_Category_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_UnionCategoryAndTypeHuman_TypesHumans_typeHumanId",
                        column: x => x.typeHumanId,
                        principalTable: "TypesHumans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Subcategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    unionCategoryAndTypeHumanId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subcategories_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subcategories_UnionCategoryAndTypeHuman_unionCategoryAndTypeHumanId",
                        column: x => x.unionCategoryAndTypeHumanId,
                        principalTable: "UnionCategoryAndTypeHuman",
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
                    UnionCategoryAndTypeHumanId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_UnionNamesAndDimensions_UnionCategoryAndTypeHuman_UnionCategoryAndTypeHumanId",
                        column: x => x.UnionCategoryAndTypeHumanId,
                        principalTable: "UnionCategoryAndTypeHuman",
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
                    UnionCategoryAndTypeHumanId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_UnionNamesCriteriaOfDimensions_UnionCategoryAndTypeHuman_UnionCategoryAndTypeHumanId",
                        column: x => x.UnionCategoryAndTypeHumanId,
                        principalTable: "UnionCategoryAndTypeHuman",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    brandId = table.Column<int>(type: "int", nullable: true),
                    subcategoryId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    collectionId = table.Column<int>(type: "int", nullable: true),
                    About = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Addition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fakePopularity = table.Column<int>(type: "int", nullable: false),
                    realPopularity = table.Column<int>(type: "int", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Brands_brandId",
                        column: x => x.brandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Cards_Collections_collectionId",
                        column: x => x.collectionId,
                        principalTable: "Collections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Cards_Subcategories_subcategoryId",
                        column: x => x.subcategoryId,
                        principalTable: "Subcategories",
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cardId = table.Column<int>(type: "int", nullable: true),
                    colorId = table.Column<int>(type: "int", nullable: true),
                    sizeId = table.Column<int>(type: "int", nullable: true),
                    howMany = table.Column<int>(type: "int", nullable: false),
                    howManyPictures = table.Column<int>(type: "int", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Cards_cardId",
                        column: x => x.cardId,
                        principalTable: "Cards",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Colors_colorId",
                        column: x => x.colorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Products_Sizes_sizeId",
                        column: x => x.sizeId,
                        principalTable: "Sizes",
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
                name: "IX_Cards_brandId",
                table: "Cards",
                column: "brandId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_collectionId",
                table: "Cards",
                column: "collectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_subcategoryId",
                table: "Cards",
                column: "subcategoryId");

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
                name: "IX_Products_cardId",
                table: "Products",
                column: "cardId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_colorId",
                table: "Products",
                column: "colorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_sizeId",
                table: "Products",
                column: "sizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_namesDimensionsId",
                table: "Sizes",
                column: "namesDimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Subcategories_CategoryId",
                table: "Subcategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Subcategories_unionCategoryAndTypeHumanId",
                table: "Subcategories",
                column: "unionCategoryAndTypeHumanId");

            migrationBuilder.CreateIndex(
                name: "IX_UnionCategoryAndTypeHuman_categoryId",
                table: "UnionCategoryAndTypeHuman",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UnionCategoryAndTypeHuman_typeHumanId",
                table: "UnionCategoryAndTypeHuman",
                column: "typeHumanId");

            migrationBuilder.CreateIndex(
                name: "IX_UnionNamesAndDimensions_NamesDimensionsId",
                table: "UnionNamesAndDimensions",
                column: "NamesDimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_UnionNamesAndDimensions_UnionCategoryAndTypeHumanId",
                table: "UnionNamesAndDimensions",
                column: "UnionCategoryAndTypeHumanId");

            migrationBuilder.CreateIndex(
                name: "IX_UnionNamesCriteriaOfDimensions_NamesCriteriaOfDimensionsId",
                table: "UnionNamesCriteriaOfDimensions",
                column: "NamesCriteriaOfDimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_UnionNamesCriteriaOfDimensions_UnionCategoryAndTypeHumanId",
                table: "UnionNamesCriteriaOfDimensions",
                column: "UnionCategoryAndTypeHumanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "CriteriaOfDimensions");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "UnionNamesCriteriaOfDimensions");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Collections");

            migrationBuilder.DropTable(
                name: "Subcategories");

            migrationBuilder.DropTable(
                name: "UnionNamesAndDimensions");

            migrationBuilder.DropTable(
                name: "NamesCriteriaOfDimensions");

            migrationBuilder.DropTable(
                name: "NamesDimensions");

            migrationBuilder.DropTable(
                name: "UnionCategoryAndTypeHuman");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "TypesHumans");
        }
    }
}
