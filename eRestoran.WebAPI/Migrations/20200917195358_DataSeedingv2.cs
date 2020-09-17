using Microsoft.EntityFrameworkCore.Migrations;

namespace eRestoran.WebAPI.Migrations
{
    public partial class DataSeedingv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Award_User_FK",
                table: "Award");

            migrationBuilder.DropForeignKey(
                name: "DiscountType_Discount_FK",
                table: "Discount");

            migrationBuilder.DropForeignKey(
                name: "User_Discount_FK",
                table: "Discount");

            migrationBuilder.DropForeignKey(
                name: "ItemTypeId_FK",
                table: "ItemCategory");

            migrationBuilder.DropForeignKey(
                name: "RestaurantMenu_ItemId_FK",
                table: "MenuItems_Review");

            migrationBuilder.DropForeignKey(
                name: "UserId_FK",
                table: "MenuItems_Review");

            migrationBuilder.DropForeignKey(
                name: "CityId_Restaurant_FK",
                table: "Restaurant");

            migrationBuilder.DropForeignKey(
                name: "Restaurant_Review_UserId_FK",
                table: "Restaurant_Review");

            migrationBuilder.DropForeignKey(
                name: "ItemCategoryId_FK",
                table: "RestaurantMenu_Item");

            migrationBuilder.DropForeignKey(
                name: "CityId_FK",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "GenderId_FK",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "Role_UserRole_FK",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "User_UserRole_FK",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "Visit_UserId_FK",
                table: "Visit");

            migrationBuilder.DropForeignKey(
                name: "Visitor_Recommendation_UserId_FK",
                table: "Visitor_Recommendation");

            migrationBuilder.CreateTable(
                name: "Key",
                columns: table => new
                {
                    KeyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantId = table.Column<int>(nullable: true),
                    Key = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Key", x => x.KeyId);
                    table.ForeignKey(
                        name: "Restaurant_Key_FK",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Key",
                columns: new[] { "KeyId", "Active", "Key", "RestaurantId" },
                values: new object[,]
                {
                    { 1, true, 123456789, null },
                    { 2, true, 987654321, null },
                    { 3, true, 123789456, null },
                    { 4, true, 789123456, null },
                    { 5, true, 258963147, null },
                    { 6, true, 147258369, null }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "+2OrWzKM6jdDhJdcmQyEnVCKRqM=", "2oOAwKloLKiEkx7Q6ENUEw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "yY86dbw7GrMdklZbw/N+cp3uct8=", "Mdo3C6+SBNC9BWPnn5Z/fA==" });

            migrationBuilder.CreateIndex(
                name: "IX_Key_RestaurantId",
                table: "Key",
                column: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "Award_User_FK",
                table: "Award",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "DiscountType_Discount_FK",
                table: "Discount",
                column: "DiscountTypeId",
                principalTable: "DiscountType",
                principalColumn: "DiscountTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "User_Discount_FK",
                table: "Discount",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "ItemTypeId_FK",
                table: "ItemCategory",
                column: "ItemTypeId",
                principalTable: "ItemType",
                principalColumn: "ItemTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "RestaurantMenu_ItemId_FK",
                table: "MenuItems_Review",
                column: "RestaurantMenu_ItemId",
                principalTable: "RestaurantMenu_Item",
                principalColumn: "RestaurantMenu_ItemId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "UserId_FK",
                table: "MenuItems_Review",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "CityId_Restaurant_FK",
                table: "Restaurant",
                column: "CityId",
                principalTable: "City",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "Restaurant_Review_UserId_FK",
                table: "Restaurant_Review",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "ItemCategoryId_FK",
                table: "RestaurantMenu_Item",
                column: "ItemCategoryId",
                principalTable: "ItemCategory",
                principalColumn: "ItemCategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "CityId_FK",
                table: "User",
                column: "CityId",
                principalTable: "City",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "GenderId_FK",
                table: "User",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "GenderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "Role_UserRole_FK",
                table: "UserRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "User_UserRole_FK",
                table: "UserRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "Visit_UserId_FK",
                table: "Visit",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "Visitor_Recommendation_UserId_FK",
                table: "Visitor_Recommendation",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Award_User_FK",
                table: "Award");

            migrationBuilder.DropForeignKey(
                name: "DiscountType_Discount_FK",
                table: "Discount");

            migrationBuilder.DropForeignKey(
                name: "User_Discount_FK",
                table: "Discount");

            migrationBuilder.DropForeignKey(
                name: "ItemTypeId_FK",
                table: "ItemCategory");

            migrationBuilder.DropForeignKey(
                name: "RestaurantMenu_ItemId_FK",
                table: "MenuItems_Review");

            migrationBuilder.DropForeignKey(
                name: "UserId_FK",
                table: "MenuItems_Review");

            migrationBuilder.DropForeignKey(
                name: "CityId_Restaurant_FK",
                table: "Restaurant");

            migrationBuilder.DropForeignKey(
                name: "Restaurant_Review_UserId_FK",
                table: "Restaurant_Review");

            migrationBuilder.DropForeignKey(
                name: "ItemCategoryId_FK",
                table: "RestaurantMenu_Item");

            migrationBuilder.DropForeignKey(
                name: "CityId_FK",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "GenderId_FK",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "Role_UserRole_FK",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "User_UserRole_FK",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "Visit_UserId_FK",
                table: "Visit");

            migrationBuilder.DropForeignKey(
                name: "Visitor_Recommendation_UserId_FK",
                table: "Visitor_Recommendation");

            migrationBuilder.DropTable(
                name: "Key");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "GEkHTt1FHa3QTszTIygZU0PuYbk=", "X9xHEu1HvJSO6Bqu9rvzNQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "tJSQ00RubHdmugtIJg52fSSzxH4=", "eD/YyQNDwHyYfX7BrxU/zg==" });

            migrationBuilder.AddForeignKey(
                name: "Award_User_FK",
                table: "Award",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "DiscountType_Discount_FK",
                table: "Discount",
                column: "DiscountTypeId",
                principalTable: "DiscountType",
                principalColumn: "DiscountTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "User_Discount_FK",
                table: "Discount",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "ItemTypeId_FK",
                table: "ItemCategory",
                column: "ItemTypeId",
                principalTable: "ItemType",
                principalColumn: "ItemTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "RestaurantMenu_ItemId_FK",
                table: "MenuItems_Review",
                column: "RestaurantMenu_ItemId",
                principalTable: "RestaurantMenu_Item",
                principalColumn: "RestaurantMenu_ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "UserId_FK",
                table: "MenuItems_Review",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "CityId_Restaurant_FK",
                table: "Restaurant",
                column: "CityId",
                principalTable: "City",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "Restaurant_Review_UserId_FK",
                table: "Restaurant_Review",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "ItemCategoryId_FK",
                table: "RestaurantMenu_Item",
                column: "ItemCategoryId",
                principalTable: "ItemCategory",
                principalColumn: "ItemCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "CityId_FK",
                table: "User",
                column: "CityId",
                principalTable: "City",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "GenderId_FK",
                table: "User",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "GenderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "Role_UserRole_FK",
                table: "UserRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "User_UserRole_FK",
                table: "UserRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "Visit_UserId_FK",
                table: "Visit",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "Visitor_Recommendation_UserId_FK",
                table: "Visitor_Recommendation",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
