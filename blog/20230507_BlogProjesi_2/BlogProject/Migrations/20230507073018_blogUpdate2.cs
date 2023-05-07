using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject.Migrations
{
    public partial class blogUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NVARCHAR(MAX)",
                table: "Blogs",
                newName: "Content");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Blogs",
                type: "NVARCHAR(MAX)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 914, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 914, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 914, DateTimeKind.Local).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 914, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 914, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 914, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 914, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 914, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 914, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 914, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 901, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 903, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 903, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 903, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 903, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 903, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 903, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 903, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 903, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 30, 17, 903, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "5cfed386-e112-45c6-adc8-20dc80f1fb0f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "5e47675f-1458-41ad-86e9-6f92d206e7d3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "5380aa5f-9a35-4580-8229-04ea95840484");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "e28479c5-55d8-495e-a7b6-673a063147ef");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "854543dd-d1e0-4280-b0f0-03cead70f9da");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "70175874-c127-4d2c-9b83-714ffb450438");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "5af3e57d-56d9-4b98-ba0f-0ee8fb02271a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "a70a5c22-530f-496c-8800-22385e00b835");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "13450344-a456-46ac-9e89-7642b2f4805f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "b7259aa6-1463-4481-a0c0-725c34904c72");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "a3f87bd0-a62e-4745-9a03-03f2aa8987b8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "c4e07f0c-e767-4dca-a1e0-266dfb41dc91");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "3b242b11-3c36-49fd-9eab-d6e685b20e52");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "83540db9-6bd5-41d6-aab9-4c5230fb96fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "7e2e0e66-d3ac-407c-9f54-e79f688f7765");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "5bcbc842-e730-4678-811e-4ae532094a94");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "5650c639-c23b-4661-8c10-d76e0b1e0f33");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9921a6c8-adbd-4c16-bd27-178b57573e10", new DateTime(2023, 5, 7, 10, 30, 17, 942, DateTimeKind.Local).AddTicks(8846), "AQAAAAEAACcQAAAAEMiwYrV9PoNMFZa+cPwMw/cS9b72xfM14Adw9c8/2cAKaB5a5HfDI/5rHz21djd1jA==", "276390bc-e641-445d-baa1-38345e2fc1d3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b805571e-efae-4bfd-8496-8bb8974bf3a8", new DateTime(2023, 5, 7, 10, 30, 17, 957, DateTimeKind.Local).AddTicks(7612), "AQAAAAEAACcQAAAAEHLZRSK0gj59KzE7+esbDEAspNok4jaG2FDWxAIrUy3+aX3wWEy20KYT0sl7PTC/RQ==", "c6d26a80-27d8-4eff-912c-7d0d51308ab4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Blogs",
                newName: "NVARCHAR(MAX)");

            migrationBuilder.AlterColumn<string>(
                name: "NVARCHAR(MAX)",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(MAX)");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 515, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 515, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 515, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 515, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 515, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 515, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 515, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 515, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 515, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 515, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 501, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 502, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 502, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 502, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 502, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 502, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 502, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 502, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 502, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 7, 10, 27, 9, 502, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ca0704d9-9b89-4cf8-8e02-31dbd6c26571");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ba20137e-0047-47b4-bf86-bab1145614da");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "1a0425f9-5e12-4e8f-a037-0b2d14a4f846");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "afc31c2d-ef37-4e6d-8bf8-a3d880a65f1d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "c01b96af-c327-4f40-bd75-e4b696b4681e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "f2075cf8-9128-443e-8ed9-d3852bf2f818");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "d742fe7f-b0da-4b73-9528-3bb1bbafb5c8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "a0e207f0-d23f-4493-b32e-89002e40e057");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "a131cc68-97db-4ffa-8e4a-c579c33b65b6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "61b36020-4938-44d7-9cea-0b1e9e9bee44");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "8aaa27c6-d813-48ff-b27e-538b554bec63");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "7923e76c-9aa8-42c3-b291-c8ad803b01f5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "0d45cba5-7c8f-4df7-ab4a-9bba01ce39ec");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "f15a54f5-9142-4ba3-b37a-434f547d8140");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "e15e5162-b071-4b15-a12c-0613224e69ea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "ebbdd2a1-c80b-42f8-a456-3c270a450b09");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "c6629abc-2205-4594-ad05-33309d69e501");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f674881a-168c-47f2-8a40-57b6f2af7e86", new DateTime(2023, 5, 7, 10, 27, 9, 542, DateTimeKind.Local).AddTicks(9540), "AQAAAAEAACcQAAAAEKRvlUaY07TfwR48EmDppJBzDLrCla+13s2ButapbdYrP56iRn5djLMvAea3bAV11w==", "65f0df4b-ca9b-48c8-bf57-d4924d6ddbb5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44a84edb-b5fe-4d24-b5ee-f74b12cb7e33", new DateTime(2023, 5, 7, 10, 27, 9, 557, DateTimeKind.Local).AddTicks(9532), "AQAAAAEAACcQAAAAEJ8ezCsCC018FM0aFJwpcdyRT3CCSUbXTNrbqoCIaVmEMYjAkTi96SbRDXVGAROEbw==", "9d94e762-3567-41ee-82c6-28dbb1635da5" });
        }
    }
}
