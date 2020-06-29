using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpiritPenguin.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PicklistTypes",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Value" },
                values: new object[] { new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"), new DateTime(2019, 10, 17, 19, 37, 9, 984, DateTimeKind.Local).AddTicks(5903), false, "ExpenseCategory" });

            migrationBuilder.InsertData(
                table: "Picklist",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "PicklistTypeId", "Value" },
                values: new object[] { new Guid("5cf235b2-a803-43d1-824d-38de32c83ccd"), new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(8695), true, false, new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"), "Bills" });

            migrationBuilder.InsertData(
                table: "Picklist",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "PicklistTypeId", "Value" },
                values: new object[] { new Guid("bfe3c2bb-0717-489d-8d6f-12979c61ab25"), new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(9722), true, false, new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"), "Rent" });

            migrationBuilder.InsertData(
                table: "Picklist",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "PicklistTypeId", "Value" },
                values: new object[] { new Guid("8c98085a-a16a-4115-a7d1-12f8a980de67"), new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(9778), true, false, new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"), "Other" });

            migrationBuilder.InsertData(
                table: "Picklist",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "PicklistTypeId", "Value" },
                values: new object[] { new Guid("67918693-1acb-4421-81bb-8be1ece04268"), new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(9804), true, false, new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"), "Entertainment" });

            migrationBuilder.InsertData(
                table: "Picklist",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "PicklistTypeId", "Value" },
                values: new object[] { new Guid("d0c9c322-5b5f-4766-b148-e7501492a954"), new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(9828), true, false, new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"), "Junk Food" });

            migrationBuilder.InsertData(
                table: "Picklist",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "PicklistTypeId", "Value" },
                values: new object[] { new Guid("763c0414-97ba-46cc-8846-2e03babbe0ba"), new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(9857), true, false, new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"), "Necessities" });

            migrationBuilder.InsertData(
                table: "Picklist",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "PicklistTypeId", "Value" },
                values: new object[] { new Guid("43f1b49f-a6a9-4072-b602-794263811372"), new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(9880), true, false, new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"), "Lifestyle" });

            migrationBuilder.InsertData(
                table: "Picklist",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "PicklistTypeId", "Value" },
                values: new object[] { new Guid("883c19f8-e2f2-4141-a96e-43dd5a80b45e"), new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(9902), true, false, new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"), "Developer" });

            migrationBuilder.InsertData(
                table: "Picklist",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "PicklistTypeId", "Value" },
                values: new object[] { new Guid("8574d514-d5a7-496b-a00a-3ac9d00a99f4"), new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(9924), true, false, new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"), "Loan repayment" });

            migrationBuilder.InsertData(
                table: "Picklist",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "PicklistTypeId", "Value" },
                values: new object[] { new Guid("7b3ce76b-4c69-4e94-8c61-a9dc415251cd"), new DateTime(2019, 10, 17, 19, 37, 9, 987, DateTimeKind.Local).AddTicks(9949), true, false, new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"), "Automotive" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Picklist",
                keyColumn: "Id",
                keyValue: new Guid("43f1b49f-a6a9-4072-b602-794263811372"));

            migrationBuilder.DeleteData(
                table: "Picklist",
                keyColumn: "Id",
                keyValue: new Guid("5cf235b2-a803-43d1-824d-38de32c83ccd"));

            migrationBuilder.DeleteData(
                table: "Picklist",
                keyColumn: "Id",
                keyValue: new Guid("67918693-1acb-4421-81bb-8be1ece04268"));

            migrationBuilder.DeleteData(
                table: "Picklist",
                keyColumn: "Id",
                keyValue: new Guid("763c0414-97ba-46cc-8846-2e03babbe0ba"));

            migrationBuilder.DeleteData(
                table: "Picklist",
                keyColumn: "Id",
                keyValue: new Guid("7b3ce76b-4c69-4e94-8c61-a9dc415251cd"));

            migrationBuilder.DeleteData(
                table: "Picklist",
                keyColumn: "Id",
                keyValue: new Guid("8574d514-d5a7-496b-a00a-3ac9d00a99f4"));

            migrationBuilder.DeleteData(
                table: "Picklist",
                keyColumn: "Id",
                keyValue: new Guid("883c19f8-e2f2-4141-a96e-43dd5a80b45e"));

            migrationBuilder.DeleteData(
                table: "Picklist",
                keyColumn: "Id",
                keyValue: new Guid("8c98085a-a16a-4115-a7d1-12f8a980de67"));

            migrationBuilder.DeleteData(
                table: "Picklist",
                keyColumn: "Id",
                keyValue: new Guid("bfe3c2bb-0717-489d-8d6f-12979c61ab25"));

            migrationBuilder.DeleteData(
                table: "Picklist",
                keyColumn: "Id",
                keyValue: new Guid("d0c9c322-5b5f-4766-b148-e7501492a954"));

            migrationBuilder.DeleteData(
                table: "PicklistTypes",
                keyColumn: "Id",
                keyValue: new Guid("b40ee6c6-3dc9-41e7-a2d0-350237306099"));
        }
    }
}
