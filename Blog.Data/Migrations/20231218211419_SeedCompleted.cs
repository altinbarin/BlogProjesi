using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class SeedCompleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("010bb85e-9604-4ac8-b164-1d9034757438"), "Admin Test", new DateTime(2023, 12, 19, 0, 14, 19, 499, DateTimeKind.Local).AddTicks(9596), null, null, false, null, null, "ASP.NET Core" },
                    { new Guid("0f7a15a2-876e-4bf6-b052-d1b84df559d6"), "Admin Test", new DateTime(2023, 12, 19, 0, 14, 19, 499, DateTimeKind.Local).AddTicks(9593), null, null, false, null, null, "Visual Studio 2022" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("214bcd11-2794-4a88-96b5-53580337c0ae"), "Admin Test", new DateTime(2023, 12, 19, 0, 14, 19, 499, DateTimeKind.Local).AddTicks(9698), null, null, "images/testimage", "jpg", false, null, null },
                    { new Guid("b92d05d0-af78-4a73-8c12-69560c7a9f3f"), "Admin Test", new DateTime(2023, 12, 19, 0, 14, 19, 499, DateTimeKind.Local).AddTicks(9713), null, null, "images/vstest", "png", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("6628d918-3570-4393-9a77-bae1ebdeb246"), new Guid("010bb85e-9604-4ac8-b164-1d9034757438"), "Asp.Net Core Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Faucibus nisl tincidunt eget nullam non nisi est sit amet. Fermentum posuere urna nec tincidunt praesent. Massa enim nec dui nunc mattis enim ut. Et netus et malesuada fames ac turpis. Aliquam malesuada bibendum arcu vitae elementum. Augue interdum velit euismod in pellentesque massa. Non nisi est sit amet facilisis magna etiam tempor orci. Diam sollicitudin tempor id eu. Dictum at tempor commodo ullamcorper a lacus vestibulum sed. Augue interdum velit euismod in pellentesque massa placerat. Quisque non tellus orci ac. Tortor aliquam nulla facilisi cras fermentum odio eu. Urna nunc id cursus metus aliquam eleifend mi in.\r\n\r\nDuis at consectetur lorem donec. Tortor at risus viverra adipiscing at in. Nisl pretium fusce id velit ut tortor pretium. Cras ornare arcu dui vivamus arcu felis. Sed nisi lacus sed viverra tellus in hac habitasse platea. Vulputate mi sit amet mauris commodo quis imperdiet massa tincidunt. Dui nunc mattis enim ut tellus. Id diam maecenas ultricies mi eget mauris. Velit euismod in pellentesque massa placerat duis ultricies lacus sed. Tincidunt lobortis feugiat vivamus at augue. Ultricies tristique nulla aliquet enim tortor. Ultricies mi quis hendrerit dolor magna eget est. Cras tincidunt lobortis feugiat vivamus at augue eget arcu dictum. Risus commodo viverra maecenas accumsan lacus vel facilisis volutpat est. Elit ut aliquam purus sit amet. Ultricies mi quis hendrerit dolor. Eu tincidunt tortor aliquam nulla facilisi cras fermentum. Ultrices sagittis orci a scelerisque.", "Admin Test", new DateTime(2023, 12, 19, 0, 14, 19, 499, DateTimeKind.Local).AddTicks(9361), null, null, new Guid("214bcd11-2794-4a88-96b5-53580337c0ae"), false, null, null, "Asp.Net Core Deneme Makalesi", 15 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("ac20745f-890f-40fd-a2be-2cfc439af7d0"), new Guid("0f7a15a2-876e-4bf6-b052-d1b84df559d6"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Faucibus nisl tincidunt eget nullam non nisi est sit amet. Fermentum posuere urna nec tincidunt praesent. Massa enim nec dui nunc mattis enim ut. Et netus et malesuada fames ac turpis. Aliquam malesuada bibendum arcu vitae elementum. Augue interdum velit euismod in pellentesque massa. Non nisi est sit amet facilisis magna etiam tempor orci. Diam sollicitudin tempor id eu. Dictum at tempor commodo ullamcorper a lacus vestibulum sed. Augue interdum velit euismod in pellentesque massa placerat. Quisque non tellus orci ac. Tortor aliquam nulla facilisi cras fermentum odio eu. Urna nunc id cursus metus aliquam eleifend mi in.\r\n\r\nDuis at consectetur lorem donec. Tortor at risus viverra adipiscing at in. Nisl pretium fusce id velit ut tortor pretium. Cras ornare arcu dui vivamus arcu felis. Sed nisi lacus sed viverra tellus in hac habitasse platea. Vulputate mi sit amet mauris commodo quis imperdiet massa tincidunt. Dui nunc mattis enim ut tellus. Id diam maecenas ultricies mi eget mauris. Velit euismod in pellentesque massa placerat duis ultricies lacus sed. Tincidunt lobortis feugiat vivamus at augue. Ultricies tristique nulla aliquet enim tortor. Ultricies mi quis hendrerit dolor magna eget est. Cras tincidunt lobortis feugiat vivamus at augue eget arcu dictum. Risus commodo viverra maecenas accumsan lacus vel facilisis volutpat est. Elit ut aliquam purus sit amet. Ultricies mi quis hendrerit dolor. Eu tincidunt tortor aliquam nulla facilisi cras fermentum. Ultrices sagittis orci a scelerisque.", "Admin Test", new DateTime(2023, 12, 19, 0, 14, 19, 499, DateTimeKind.Local).AddTicks(9366), null, null, new Guid("b92d05d0-af78-4a73-8c12-69560c7a9f3f"), false, null, null, "Visual Studio Deneme Makalesi", 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6628d918-3570-4393-9a77-bae1ebdeb246"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ac20745f-890f-40fd-a2be-2cfc439af7d0"));

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

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
