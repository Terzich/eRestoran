using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eRestoran.WebAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "DiscountType",
                columns: table => new
                {
                    DiscountTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountType", x => x.DiscountTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    GenderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gender = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "ItemType",
                columns: table => new
                {
                    ItemTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemType", x => x.ItemTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Quantity",
                columns: table => new
                {
                    QuantityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 30, nullable: true),
                    Mark = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quantity", x => x.QuantityId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantName = table.Column<string>(maxLength: 50, nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: true),
                    NumberOfTables = table.Column<int>(nullable: true),
                    OpenAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CloseAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    Image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.RestaurantId);
                    table.ForeignKey(
                        name: "CityId_Restaurant_FK",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Surname = table.Column<string>(maxLength: 30, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    CityId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(maxLength: 30, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 30, nullable: true),
                    GenderId = table.Column<int>(nullable: false),
                    Username = table.Column<string>(maxLength: 50, nullable: true),
                    PasswordSalt = table.Column<string>(maxLength: 128, nullable: true),
                    PasswordHash = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "CityId_FK",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "GenderId_FK",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemCategory",
                columns: table => new
                {
                    ItemCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(maxLength: 35, nullable: false),
                    ItemTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategory", x => x.ItemCategoryId);
                    table.ForeignKey(
                        name: "ItemTypeId_FK",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemType",
                        principalColumn: "ItemTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Award",
                columns: table => new
                {
                    AwardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    AwardDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Award", x => x.AwardId);
                    table.ForeignKey(
                        name: "Award_User_FK",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant_Review",
                columns: table => new
                {
                    Restaurant_ReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    Grade = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant_Review", x => x.Restaurant_ReviewId);
                    table.ForeignKey(
                        name: "Restaurant_Review_UserId_FK",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.UserRoleId);
                    table.ForeignKey(
                        name: "Role_UserRole_FK",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "User_UserRole_FK",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visit",
                columns: table => new
                {
                    VisitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    DateOfVisit = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visit", x => x.VisitId);
                    table.ForeignKey(
                        name: "Visit_UserId_FK",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visitor_Recommendation",
                columns: table => new
                {
                    Visitor_RecommendationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Recommendation_Description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitor_Recommendation", x => x.Visitor_RecommendationId);
                    table.ForeignKey(
                        name: "Visitor_Recommendation_UserId_FK",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantMenu_Item",
                columns: table => new
                {
                    RestaurantMenu_ItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(maxLength: 35, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    ItemCategoryId = table.Column<int>(nullable: false),
                    QuantityId = table.Column<int>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantMenu_Item", x => x.RestaurantMenu_ItemId);
                    table.ForeignKey(
                        name: "ItemCategoryId_FK",
                        column: x => x.ItemCategoryId,
                        principalTable: "ItemCategory",
                        principalColumn: "ItemCategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "QuantityId_FK",
                        column: x => x.QuantityId,
                        principalTable: "Quantity",
                        principalColumn: "QuantityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    DiscountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    DiscountTypeId = table.Column<int>(nullable: false),
                    ItemTypeId = table.Column<int>(nullable: true),
                    ItemCategoryId = table.Column<int>(nullable: true),
                    RestaurantMenu_ItemId = table.Column<int>(nullable: true),
                    DiscountDate = table.Column<DateTime>(type: "date", nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    DiscountValue = table.Column<decimal>(type: "decimal(2, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount", x => x.DiscountId);
                    table.ForeignKey(
                        name: "DiscountType_Discount_FK",
                        column: x => x.DiscountTypeId,
                        principalTable: "DiscountType",
                        principalColumn: "DiscountTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ItemCategory_Discount_FK",
                        column: x => x.ItemCategoryId,
                        principalTable: "ItemCategory",
                        principalColumn: "ItemCategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ItemType_Discount_FK",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemType",
                        principalColumn: "ItemTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "RestaurantMenu_Item_Discount_FK",
                        column: x => x.RestaurantMenu_ItemId,
                        principalTable: "RestaurantMenu_Item",
                        principalColumn: "RestaurantMenu_ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "User_Discount_FK",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems_Review",
                columns: table => new
                {
                    MenuItems_ReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    RestaurantMenu_ItemId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    Grade = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems_Review", x => x.MenuItems_ReviewId);
                    table.ForeignKey(
                        name: "RestaurantMenu_ItemId_FK",
                        column: x => x.RestaurantMenu_ItemId,
                        principalTable: "RestaurantMenu_Item",
                        principalColumn: "RestaurantMenu_ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "UserId_FK",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SuperOffer",
                columns: table => new
                {
                    SuperOfferId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    OfferStart = table.Column<DateTime>(type: "datetime", nullable: false),
                    OfferEnd = table.Column<DateTime>(type: "datetime", nullable: false),
                    ItemTypeId = table.Column<int>(nullable: true),
                    ItemCategoryId = table.Column<int>(nullable: true),
                    RestaurantMenu_ItemId = table.Column<int>(nullable: true),
                    DiscountValue = table.Column<decimal>(type: "decimal(5, 2)", nullable: true),
                    DiscountType = table.Column<int>(nullable: true),
                    Active = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperOffer", x => x.SuperOfferId);
                    table.ForeignKey(
                        name: "SuperOffer_DiscountType_FK",
                        column: x => x.DiscountType,
                        principalTable: "DiscountType",
                        principalColumn: "DiscountTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ItemCategory_SuperOffer_FK",
                        column: x => x.ItemCategoryId,
                        principalTable: "ItemCategory",
                        principalColumn: "ItemCategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ItemType_SuperOffer_FK",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemType",
                        principalColumn: "ItemTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "RestaurantMenu_Item_SuperOffer_FK",
                        column: x => x.RestaurantMenu_ItemId,
                        principalTable: "RestaurantMenu_Item",
                        principalColumn: "RestaurantMenu_ItemId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Award_UserId",
                table: "Award",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Discount_DiscountTypeId",
                table: "Discount",
                column: "DiscountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Discount_ItemCategoryId",
                table: "Discount",
                column: "ItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Discount_ItemTypeId",
                table: "Discount",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Discount_RestaurantMenu_ItemId",
                table: "Discount",
                column: "RestaurantMenu_ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Discount_UserId",
                table: "Discount",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCategory_ItemTypeId",
                table: "ItemCategory",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_Review_RestaurantMenu_ItemId",
                table: "MenuItems_Review",
                column: "RestaurantMenu_ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_Review_UserId",
                table: "MenuItems_Review",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_CityId",
                table: "Restaurant",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_Review_UserId",
                table: "Restaurant_Review",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantMenu_Item_ItemCategoryId",
                table: "RestaurantMenu_Item",
                column: "ItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantMenu_Item_QuantityId",
                table: "RestaurantMenu_Item",
                column: "QuantityId");

            migrationBuilder.CreateIndex(
                name: "IX_SuperOffer_DiscountType",
                table: "SuperOffer",
                column: "DiscountType");

            migrationBuilder.CreateIndex(
                name: "IX_SuperOffer_ItemCategoryId",
                table: "SuperOffer",
                column: "ItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SuperOffer_ItemTypeId",
                table: "SuperOffer",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SuperOffer_RestaurantMenu_ItemId",
                table: "SuperOffer",
                column: "RestaurantMenu_ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CityId",
                table: "User",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_User_GenderId",
                table: "User",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Visit_UserId",
                table: "Visit",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitor_Recommendation_UserId",
                table: "Visitor_Recommendation",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Award");

            migrationBuilder.DropTable(
                name: "Discount");

            migrationBuilder.DropTable(
                name: "MenuItems_Review");

            migrationBuilder.DropTable(
                name: "Restaurant");

            migrationBuilder.DropTable(
                name: "Restaurant_Review");

            migrationBuilder.DropTable(
                name: "SuperOffer");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Visit");

            migrationBuilder.DropTable(
                name: "Visitor_Recommendation");

            migrationBuilder.DropTable(
                name: "DiscountType");

            migrationBuilder.DropTable(
                name: "RestaurantMenu_Item");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "ItemCategory");

            migrationBuilder.DropTable(
                name: "Quantity");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "ItemType");
        }
    }
}
