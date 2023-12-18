using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class DALExtensions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6628d918-3570-4393-9a77-bae1ebdeb246"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ac20745f-890f-40fd-a2be-2cfc439af7d0"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("9978d48a-75bc-443d-b80e-a56dde1048b4"), new Guid("010bb85e-9604-4ac8-b164-1d9034757438"), "Asp.Net Core Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Faucibus nisl tincidunt eget nullam non nisi est sit amet. Fermentum posuere urna nec tincidunt praesent. Massa enim nec dui nunc mattis enim ut. Et netus et malesuada fames ac turpis. Aliquam malesuada bibendum arcu vitae elementum. Augue interdum velit euismod in pellentesque massa. Non nisi est sit amet facilisis magna etiam tempor orci. Diam sollicitudin tempor id eu. Dictum at tempor commodo ullamcorper a lacus vestibulum sed. Augue interdum velit euismod in pellentesque massa placerat. Quisque non tellus orci ac. Tortor aliquam nulla facilisi cras fermentum odio eu. Urna nunc id cursus metus aliquam eleifend mi in.\r\n\r\nDuis at consectetur lorem donec. Tortor at risus viverra adipiscing at in. Nisl pretium fusce id velit ut tortor pretium. Cras ornare arcu dui vivamus arcu felis. Sed nisi lacus sed viverra tellus in hac habitasse platea. Vulputate mi sit amet mauris commodo quis imperdiet massa tincidunt. Dui nunc mattis enim ut tellus. Id diam maecenas ultricies mi eget mauris. Velit euismod in pellentesque massa placerat duis ultricies lacus sed. Tincidunt lobortis feugiat vivamus at augue. Ultricies tristique nulla aliquet enim tortor. Ultricies mi quis hendrerit dolor magna eget est. Cras tincidunt lobortis feugiat vivamus at augue eget arcu dictum. Risus commodo viverra maecenas accumsan lacus vel facilisis volutpat est. Elit ut aliquam purus sit amet. Ultricies mi quis hendrerit dolor. Eu tincidunt tortor aliquam nulla facilisi cras fermentum. Ultrices sagittis orci a scelerisque.", "Admin Test", new DateTime(2023, 12, 19, 2, 34, 24, 256, DateTimeKind.Local).AddTicks(5974), null, null, new Guid("214bcd11-2794-4a88-96b5-53580337c0ae"), false, null, null, "Asp.Net Core Deneme Makalesi", 15 },
                    { new Guid("cc7ef75d-2ddb-4f47-83f6-9ec798c3a416"), new Guid("0f7a15a2-876e-4bf6-b052-d1b84df559d6"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Faucibus nisl tincidunt eget nullam non nisi est sit amet. Fermentum posuere urna nec tincidunt praesent. Massa enim nec dui nunc mattis enim ut. Et netus et malesuada fames ac turpis. Aliquam malesuada bibendum arcu vitae elementum. Augue interdum velit euismod in pellentesque massa. Non nisi est sit amet facilisis magna etiam tempor orci. Diam sollicitudin tempor id eu. Dictum at tempor commodo ullamcorper a lacus vestibulum sed. Augue interdum velit euismod in pellentesque massa placerat. Quisque non tellus orci ac. Tortor aliquam nulla facilisi cras fermentum odio eu. Urna nunc id cursus metus aliquam eleifend mi in.\r\n\r\nDuis at consectetur lorem donec. Tortor at risus viverra adipiscing at in. Nisl pretium fusce id velit ut tortor pretium. Cras ornare arcu dui vivamus arcu felis. Sed nisi lacus sed viverra tellus in hac habitasse platea. Vulputate mi sit amet mauris commodo quis imperdiet massa tincidunt. Dui nunc mattis enim ut tellus. Id diam maecenas ultricies mi eget mauris. Velit euismod in pellentesque massa placerat duis ultricies lacus sed. Tincidunt lobortis feugiat vivamus at augue. Ultricies tristique nulla aliquet enim tortor. Ultricies mi quis hendrerit dolor magna eget est. Cras tincidunt lobortis feugiat vivamus at augue eget arcu dictum. Risus commodo viverra maecenas accumsan lacus vel facilisis volutpat est. Elit ut aliquam purus sit amet. Ultricies mi quis hendrerit dolor. Eu tincidunt tortor aliquam nulla facilisi cras fermentum. Ultrices sagittis orci a scelerisque.", "Admin Test", new DateTime(2023, 12, 19, 2, 34, 24, 256, DateTimeKind.Local).AddTicks(5979), null, null, new Guid("b92d05d0-af78-4a73-8c12-69560c7a9f3f"), false, null, null, "Visual Studio Deneme Makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("010bb85e-9604-4ac8-b164-1d9034757438"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 2, 34, 24, 256, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f7a15a2-876e-4bf6-b052-d1b84df559d6"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 2, 34, 24, 256, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("214bcd11-2794-4a88-96b5-53580337c0ae"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 2, 34, 24, 256, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b92d05d0-af78-4a73-8c12-69560c7a9f3f"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 2, 34, 24, 256, DateTimeKind.Local).AddTicks(6352));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9978d48a-75bc-443d-b80e-a56dde1048b4"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("cc7ef75d-2ddb-4f47-83f6-9ec798c3a416"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("6628d918-3570-4393-9a77-bae1ebdeb246"), new Guid("010bb85e-9604-4ac8-b164-1d9034757438"), "Asp.Net Core Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Faucibus nisl tincidunt eget nullam non nisi est sit amet. Fermentum posuere urna nec tincidunt praesent. Massa enim nec dui nunc mattis enim ut. Et netus et malesuada fames ac turpis. Aliquam malesuada bibendum arcu vitae elementum. Augue interdum velit euismod in pellentesque massa. Non nisi est sit amet facilisis magna etiam tempor orci. Diam sollicitudin tempor id eu. Dictum at tempor commodo ullamcorper a lacus vestibulum sed. Augue interdum velit euismod in pellentesque massa placerat. Quisque non tellus orci ac. Tortor aliquam nulla facilisi cras fermentum odio eu. Urna nunc id cursus metus aliquam eleifend mi in.\r\n\r\nDuis at consectetur lorem donec. Tortor at risus viverra adipiscing at in. Nisl pretium fusce id velit ut tortor pretium. Cras ornare arcu dui vivamus arcu felis. Sed nisi lacus sed viverra tellus in hac habitasse platea. Vulputate mi sit amet mauris commodo quis imperdiet massa tincidunt. Dui nunc mattis enim ut tellus. Id diam maecenas ultricies mi eget mauris. Velit euismod in pellentesque massa placerat duis ultricies lacus sed. Tincidunt lobortis feugiat vivamus at augue. Ultricies tristique nulla aliquet enim tortor. Ultricies mi quis hendrerit dolor magna eget est. Cras tincidunt lobortis feugiat vivamus at augue eget arcu dictum. Risus commodo viverra maecenas accumsan lacus vel facilisis volutpat est. Elit ut aliquam purus sit amet. Ultricies mi quis hendrerit dolor. Eu tincidunt tortor aliquam nulla facilisi cras fermentum. Ultrices sagittis orci a scelerisque.", "Admin Test", new DateTime(2023, 12, 19, 0, 14, 19, 499, DateTimeKind.Local).AddTicks(9361), null, null, new Guid("214bcd11-2794-4a88-96b5-53580337c0ae"), false, null, null, "Asp.Net Core Deneme Makalesi", 15 },
                    { new Guid("ac20745f-890f-40fd-a2be-2cfc439af7d0"), new Guid("0f7a15a2-876e-4bf6-b052-d1b84df559d6"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Faucibus nisl tincidunt eget nullam non nisi est sit amet. Fermentum posuere urna nec tincidunt praesent. Massa enim nec dui nunc mattis enim ut. Et netus et malesuada fames ac turpis. Aliquam malesuada bibendum arcu vitae elementum. Augue interdum velit euismod in pellentesque massa. Non nisi est sit amet facilisis magna etiam tempor orci. Diam sollicitudin tempor id eu. Dictum at tempor commodo ullamcorper a lacus vestibulum sed. Augue interdum velit euismod in pellentesque massa placerat. Quisque non tellus orci ac. Tortor aliquam nulla facilisi cras fermentum odio eu. Urna nunc id cursus metus aliquam eleifend mi in.\r\n\r\nDuis at consectetur lorem donec. Tortor at risus viverra adipiscing at in. Nisl pretium fusce id velit ut tortor pretium. Cras ornare arcu dui vivamus arcu felis. Sed nisi lacus sed viverra tellus in hac habitasse platea. Vulputate mi sit amet mauris commodo quis imperdiet massa tincidunt. Dui nunc mattis enim ut tellus. Id diam maecenas ultricies mi eget mauris. Velit euismod in pellentesque massa placerat duis ultricies lacus sed. Tincidunt lobortis feugiat vivamus at augue. Ultricies tristique nulla aliquet enim tortor. Ultricies mi quis hendrerit dolor magna eget est. Cras tincidunt lobortis feugiat vivamus at augue eget arcu dictum. Risus commodo viverra maecenas accumsan lacus vel facilisis volutpat est. Elit ut aliquam purus sit amet. Ultricies mi quis hendrerit dolor. Eu tincidunt tortor aliquam nulla facilisi cras fermentum. Ultrices sagittis orci a scelerisque.", "Admin Test", new DateTime(2023, 12, 19, 0, 14, 19, 499, DateTimeKind.Local).AddTicks(9366), null, null, new Guid("b92d05d0-af78-4a73-8c12-69560c7a9f3f"), false, null, null, "Visual Studio Deneme Makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("010bb85e-9604-4ac8-b164-1d9034757438"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 0, 14, 19, 499, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f7a15a2-876e-4bf6-b052-d1b84df559d6"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 0, 14, 19, 499, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("214bcd11-2794-4a88-96b5-53580337c0ae"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 0, 14, 19, 499, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b92d05d0-af78-4a73-8c12-69560c7a9f3f"),
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 0, 14, 19, 499, DateTimeKind.Local).AddTicks(9713));
        }
    }
}
