using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class lastMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("58d4d4b8-5af4-4c12-bfae-69aad3b52701"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b36a1f01-c903-4465-8cd5-17da945e4e6f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5aea0c71-6328-4219-909e-eac98c5f7fd7"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("36d41f1d-aa2f-44f1-99cc-3f59bfec10f3"), new Guid("372f18fe-fe3f-4826-a47e-8e77260f684b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5a3993bb-7489-46ba-ab9d-812360c815ba"), new Guid("4a0f8924-5b95-427e-8e19-c19225c1b880") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("36d41f1d-aa2f-44f1-99cc-3f59bfec10f3"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5a3993bb-7489-46ba-ab9d-812360c815ba"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("372f18fe-fe3f-4826-a47e-8e77260f684b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4a0f8924-5b95-427e-8e19-c19225c1b880"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("010bb85e-9604-4ac8-b164-1d9034757438"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f7a15a2-876e-4bf6-b052-d1b84df559d6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("214bcd11-2794-4a88-96b5-53580337c0ae"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b92d05d0-af78-4a73-8c12-69560c7a9f3f"));

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleVisitors",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleVisitors", x => new { x.ArticleId, x.VisitorId });
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"), "f5fa23f1-9d9b-41ec-8533-4cd4fbc82bb6", "Superadmin", "SUPERADMIN" },
                    { new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"), "a0880fc2-992d-4e9d-b76e-a7b41286b3bc", "Admin", "ADMIN" },
                    { new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"), "2b50a09c-27f6-498d-82f5-ab16ade6b499", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Admin Test", new DateTime(2023, 12, 23, 2, 37, 36, 84, DateTimeKind.Local).AddTicks(3048), null, null, false, null, null, "ASP.NET Core" },
                    { new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Admin Test", new DateTime(2023, 12, 23, 2, 37, 36, 84, DateTimeKind.Local).AddTicks(3063), null, null, false, null, null, "Visual Studio 2022" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), "Admin Test", new DateTime(2023, 12, 23, 2, 37, 36, 84, DateTimeKind.Local).AddTicks(3206), null, null, "images/vstest", "png", false, null, null },
                    { new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), "Admin Test", new DateTime(2023, 12, 23, 2, 37, 36, 84, DateTimeKind.Local).AddTicks(3203), null, null, "images/testimage", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 0, "d83b4096-008d-4cd4-8d87-aa5524aa8a59", "admin@gmail.com", false, "Admin", new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAENlWrAfMP9DDpygU1Y58/OYV7CYtL5+ziQgv0z0CE+G8Y9djQQ65/0f5PcKQDjv/hw==", "+905439999988", false, "a87b5f1e-c18e-4009-83bd-abd4667e54d0", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 0, "74ca9f4a-b574-45a0-b928-f39663397588", "superadmin@gmail.com", true, "Cem", new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), "Keskin", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEK8DmVhwXYzbr4+SwSVI93A2RQdkAkcC7V6zq6ZYv+iDVqk/3FxdMK1Rptb7DSmbRA==", "+905439999999", true, "5ccc70ff-6181-4d8a-9711-ab94b27b1606", false, "superadmin@gmail.com" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("13311922-3a31-467f-929b-296df0a5c024"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 12, 23, 2, 37, 36, 84, DateTimeKind.Local).AddTicks(1720), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("2504bf66-17de-4194-8fab-5a602c24a453"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 12, 23, 2, 37, 36, 84, DateTimeKind.Local).AddTicks(1710), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"), new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleVisitors_VisitorId",
                table: "ArticleVisitors",
                column: "VisitorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleVisitors");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("13311922-3a31-467f-929b-296df0a5c024"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2504bf66-17de-4194-8fab-5a602c24a453"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"), new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("36d41f1d-aa2f-44f1-99cc-3f59bfec10f3"), "b0d63de1-c508-4d51-9e4d-85feb682f190", "Superadmin", "SUPERADMIN" },
                    { new Guid("5a3993bb-7489-46ba-ab9d-812360c815ba"), "6c44d137-db06-4c57-b6ce-b46bc4054400", "Admin", "ADMIN" },
                    { new Guid("5aea0c71-6328-4219-909e-eac98c5f7fd7"), "e2a52546-a24e-4c36-8243-708c583e8862", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("010bb85e-9604-4ac8-b164-1d9034757438"), "Admin Test", new DateTime(2023, 12, 20, 19, 35, 58, 462, DateTimeKind.Local).AddTicks(1633), null, null, false, null, null, "ASP.NET Core" },
                    { new Guid("0f7a15a2-876e-4bf6-b052-d1b84df559d6"), "Admin Test", new DateTime(2023, 12, 20, 19, 35, 58, 462, DateTimeKind.Local).AddTicks(1630), null, null, false, null, null, "Visual Studio 2022" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("214bcd11-2794-4a88-96b5-53580337c0ae"), "Admin Test", new DateTime(2023, 12, 20, 19, 35, 58, 462, DateTimeKind.Local).AddTicks(1801), null, null, "images/testimage", "jpg", false, null, null },
                    { new Guid("b92d05d0-af78-4a73-8c12-69560c7a9f3f"), "Admin Test", new DateTime(2023, 12, 20, 19, 35, 58, 462, DateTimeKind.Local).AddTicks(1804), null, null, "images/vstest", "png", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("372f18fe-fe3f-4826-a47e-8e77260f684b"), 0, "b017d5fb-4ff8-4f28-99c7-b74f57f78a06", "superadmin@gmail.com", true, "Can", new Guid("214bcd11-2794-4a88-96b5-53580337c0ae"), "Keskin", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEJOZqTS4cZqg38hRcalD7dFahumwkZ6mk4rINxiUkW6MsnvvwltVymgOPcwJsyRohA==", "+095439999999", true, "f0ee9304-31ed-4f17-8b3b-4018535ddd79", false, "superadmin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("4a0f8924-5b95-427e-8e19-c19225c1b880"), 0, "0d716f03-01fb-4087-a34f-8e88e7e6e0ad", "admin@gmail.com", false, "Furkan", new Guid("b92d05d0-af78-4a73-8c12-69560c7a9f3f"), "Altınbarın", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", null, "+095439999988", false, "17cd6c06-c001-49df-8885-113d9672a34c", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("58d4d4b8-5af4-4c12-bfae-69aad3b52701"), new Guid("010bb85e-9604-4ac8-b164-1d9034757438"), "Asp.Net Core Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Faucibus nisl tincidunt eget nullam non nisi est sit amet. Fermentum posuere urna nec tincidunt praesent. Massa enim nec dui nunc mattis enim ut. Et netus et malesuada fames ac turpis. Aliquam malesuada bibendum arcu vitae elementum. Augue interdum velit euismod in pellentesque massa. Non nisi est sit amet facilisis magna etiam tempor orci. Diam sollicitudin tempor id eu. Dictum at tempor commodo ullamcorper a lacus vestibulum sed. Augue interdum velit euismod in pellentesque massa placerat. Quisque non tellus orci ac. Tortor aliquam nulla facilisi cras fermentum odio eu. Urna nunc id cursus metus aliquam eleifend mi in.\r\n\r\nDuis at consectetur lorem donec. Tortor at risus viverra adipiscing at in. Nisl pretium fusce id velit ut tortor pretium. Cras ornare arcu dui vivamus arcu felis. Sed nisi lacus sed viverra tellus in hac habitasse platea. Vulputate mi sit amet mauris commodo quis imperdiet massa tincidunt. Dui nunc mattis enim ut tellus. Id diam maecenas ultricies mi eget mauris. Velit euismod in pellentesque massa placerat duis ultricies lacus sed. Tincidunt lobortis feugiat vivamus at augue. Ultricies tristique nulla aliquet enim tortor. Ultricies mi quis hendrerit dolor magna eget est. Cras tincidunt lobortis feugiat vivamus at augue eget arcu dictum. Risus commodo viverra maecenas accumsan lacus vel facilisis volutpat est. Elit ut aliquam purus sit amet. Ultricies mi quis hendrerit dolor. Eu tincidunt tortor aliquam nulla facilisi cras fermentum. Ultrices sagittis orci a scelerisque.", "Admin Test", new DateTime(2023, 12, 20, 19, 35, 58, 462, DateTimeKind.Local).AddTicks(1429), null, null, new Guid("214bcd11-2794-4a88-96b5-53580337c0ae"), false, null, null, "Asp.Net Core Deneme Makalesi", new Guid("372f18fe-fe3f-4826-a47e-8e77260f684b"), 15 },
                    { new Guid("b36a1f01-c903-4465-8cd5-17da945e4e6f"), new Guid("0f7a15a2-876e-4bf6-b052-d1b84df559d6"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Faucibus nisl tincidunt eget nullam non nisi est sit amet. Fermentum posuere urna nec tincidunt praesent. Massa enim nec dui nunc mattis enim ut. Et netus et malesuada fames ac turpis. Aliquam malesuada bibendum arcu vitae elementum. Augue interdum velit euismod in pellentesque massa. Non nisi est sit amet facilisis magna etiam tempor orci. Diam sollicitudin tempor id eu. Dictum at tempor commodo ullamcorper a lacus vestibulum sed. Augue interdum velit euismod in pellentesque massa placerat. Quisque non tellus orci ac. Tortor aliquam nulla facilisi cras fermentum odio eu. Urna nunc id cursus metus aliquam eleifend mi in.\r\n\r\nDuis at consectetur lorem donec. Tortor at risus viverra adipiscing at in. Nisl pretium fusce id velit ut tortor pretium. Cras ornare arcu dui vivamus arcu felis. Sed nisi lacus sed viverra tellus in hac habitasse platea. Vulputate mi sit amet mauris commodo quis imperdiet massa tincidunt. Dui nunc mattis enim ut tellus. Id diam maecenas ultricies mi eget mauris. Velit euismod in pellentesque massa placerat duis ultricies lacus sed. Tincidunt lobortis feugiat vivamus at augue. Ultricies tristique nulla aliquet enim tortor. Ultricies mi quis hendrerit dolor magna eget est. Cras tincidunt lobortis feugiat vivamus at augue eget arcu dictum. Risus commodo viverra maecenas accumsan lacus vel facilisis volutpat est. Elit ut aliquam purus sit amet. Ultricies mi quis hendrerit dolor. Eu tincidunt tortor aliquam nulla facilisi cras fermentum. Ultrices sagittis orci a scelerisque.", "Admin Test", new DateTime(2023, 12, 20, 19, 35, 58, 462, DateTimeKind.Local).AddTicks(1436), null, null, new Guid("b92d05d0-af78-4a73-8c12-69560c7a9f3f"), false, null, null, "Visual Studio Deneme Makalesi", new Guid("4a0f8924-5b95-427e-8e19-c19225c1b880"), 15 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("36d41f1d-aa2f-44f1-99cc-3f59bfec10f3"), new Guid("372f18fe-fe3f-4826-a47e-8e77260f684b") },
                    { new Guid("5a3993bb-7489-46ba-ab9d-812360c815ba"), new Guid("4a0f8924-5b95-427e-8e19-c19225c1b880") }
                });
        }
    }
}
