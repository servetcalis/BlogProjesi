using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject.Migrations
{
    public partial class sdasda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 100, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture = table.Column<string>(maxLength: 250, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blogs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 256, nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "IsDeleted", "Name", "Status" },
                values: new object[,]
                {
                    { 10, new DateTime(2023, 5, 6, 13, 8, 45, 704, DateTimeKind.Local).AddTicks(7106), null, "Ruby programlama dili ile ilgili en güncel bilgiler", false, "Ruby", 1 },
                    { 8, new DateTime(2023, 5, 6, 13, 8, 45, 704, DateTimeKind.Local).AddTicks(7103), null, "Swift programlama dili ile ilgili en güncel bilgiler", false, "Swift", 1 },
                    { 7, new DateTime(2023, 5, 6, 13, 8, 45, 704, DateTimeKind.Local).AddTicks(7101), null, "Kotlin programlama dili ile ilgili en güncel bilgiler", false, "Kotlin", 1 },
                    { 6, new DateTime(2023, 5, 6, 13, 8, 45, 704, DateTimeKind.Local).AddTicks(7099), null, "Pyhton programlama dili ile ilgili en güncel bilgiler", false, "Python", 1 },
                    { 5, new DateTime(2023, 5, 6, 13, 8, 45, 704, DateTimeKind.Local).AddTicks(7095), null, "Java programlama dili ile ilgili en güncel bilgiler", false, "Java", 1 },
                    { 4, new DateTime(2023, 5, 6, 13, 8, 45, 704, DateTimeKind.Local).AddTicks(7093), null, "TypeScript programlama dili ile ilgili en güncel bilgiler", false, "TypeScript", 1 },
                    { 3, new DateTime(2023, 5, 6, 13, 8, 45, 704, DateTimeKind.Local).AddTicks(7090), null, "JavaScript programlama dili ile ilgili en güncel bilgiler", false, "JavaScript", 1 },
                    { 2, new DateTime(2023, 5, 6, 13, 8, 45, 704, DateTimeKind.Local).AddTicks(7044), null, "C++ programlama dili ile ilgili en güncel bilgiler", false, "C++", 1 },
                    { 1, new DateTime(2023, 5, 6, 13, 8, 45, 703, DateTimeKind.Local).AddTicks(4760), null, "C# programlama dili ile ilgili en güncel bilgiler", false, "C#", 1 },
                    { 9, new DateTime(2023, 5, 6, 13, 8, 45, 704, DateTimeKind.Local).AddTicks(7104), null, "Php programlama dili ile ilgili en güncel bilgiler", false, "Php", 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 17, "39142ccf-c93b-4da7-b42d-76c378f5baa7", "AdminArea.Home.Read", "ADMINAREA.HOME.READ" },
                    { 16, "ec7e1d49-62c5-4a97-b55c-97b44abdaae0", "Role.Delete", "ROLE.DELETE" },
                    { 14, "6531bc67-1d80-4dfc-8fd0-8ffc004e52a6", "Role.Read", "ROLE.READ" },
                    { 15, "bdd30b0a-d273-4789-be47-cf8ae0f5f4ff", "Role.Update", "ROLE.UPDATE" },
                    { 12, "c1656c65-c2e5-4c40-8da6-e169192c1c1b", "User.Delete", "USER.DELETE" },
                    { 11, "ebb75e54-f7f2-45f4-b409-f5f1cbac884d", "User.Update", "USER.UPDATE" },
                    { 10, "be16f64d-b501-4762-b7cb-7fda78c063a1", "User.Read", "USER.READ" },
                    { 9, "f7b42149-c3fe-4db1-bf80-05b33a073dad", "User.Create", "USER.CREATE" },
                    { 8, "38bcef27-86fd-4a0d-ac94-cc56fb0ff353", "Blog.Delete", "BLOG.DELETE" },
                    { 7, "be2d6141-7d65-4a4f-9a42-05a3a4bc60fc", "Blog.Update", "BLOG.UPDATE" },
                    { 6, "4ef133e9-566e-4f83-9f51-dd81e779d031", "Blog.Read", "BLOG.READ" },
                    { 5, "bdb1e9f9-2610-4a0e-9ac1-8e85e2b9214d", "Blog.Create", "BLOG.CREATE" },
                    { 4, "babb6f04-ef26-46f8-8568-0878bff24571", "Category.Delete", "CATEGORY.DELETE" },
                    { 3, "b8ea6701-e2d9-47d9-a5b9-e8c4befddd83", "Category.Update", "CATEGORY.UPDATE" },
                    { 2, "61ca7226-3ea3-4463-ac55-0d7faed76fe0", "Category.Read", "CATEGORY.READ" },
                    { 13, "410a8fef-f8db-4824-9c29-63d316108c00", "Role.Create", "ROLE.CREATE" },
                    { 1, "a943331d-bb5b-431d-9c66-cb4c865b7f59", "Category.Create", "CATEGORY.CREATE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "AccessFailedCount", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "Email", "EmailConfirmed", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, "Admin User of ProgrammersBlog", 0, "8007fd30-355b-4aaa-b23a-e628c181e2e3", new DateTime(2023, 5, 6, 13, 8, 45, 738, DateTimeKind.Local).AddTicks(2046), null, "admin@user.com", true, false, "User", false, null, "Admin", "ADMIN@USER.COM", "ADMINUSER", "AQAAAAEAACcQAAAAEKjXAXaokTD/XvAUohFRO1jenEnjIk2VxOnFrLFt7lW8XnWSM/1Yyg/J/m/MH8wUKg==", "+95555555555", true, "/UserImages/defaultUser.png", "347325a8-f418-4fdf-a11c-a9dfd8aa2f0d", 1, false, "adminuser" },
                    { 2, "Editor User of ProgrammersBlog", 0, "e9a640ae-20dc-4823-a0df-5a3d9c15c53c", new DateTime(2023, 5, 6, 13, 8, 45, 753, DateTimeKind.Local).AddTicks(4593), null, "editor@user.com", true, false, "User", false, null, "Editor", "EDITOR@USER.COM", "EDITORUSER", "AQAAAAEAACcQAAAAEL5465P/xVZMI2wf2a9+RuuE0/lQWTEE20u3o0PiK2IDTf5djA+cH8cZS8H+OyneQw==", "+94444444444", true, "/UserImages/defaultUser.png", "66aebbcb-1eaf-40d1-8472-4b4ef8bb8c0d", 1, false, "editoruser" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 7 },
                    { 2, 6 },
                    { 2, 5 },
                    { 2, 4 },
                    { 2, 3 },
                    { 2, 2 },
                    { 2, 1 },
                    { 1, 17 },
                    { 1, 16 },
                    { 1, 15 },
                    { 1, 14 },
                    { 1, 13 },
                    { 1, 12 },
                    { 1, 11 },
                    { 1, 10 },
                    { 1, 9 },
                    { 1, 8 },
                    { 1, 7 },
                    { 1, 6 },
                    { 1, 5 },
                    { 1, 4 },
                    { 1, 3 },
                    { 1, 2 },
                    { 2, 8 },
                    { 2, 17 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryId",
                table: "Blogs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
