using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicQueue.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
 

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b2c6ca7-804d-48ee-8fdc-be47c43ab8fe", "e9650293-ad39-4967-a0cf-dd6161f725fe", "Clerk", "CLERK" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2098015f-6a0c-4cac-8f22-fe4442f3855e", "403fcf45-a488-4532-800f-2f98c38b0a37", "Doctor", "DOCTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7f1784a0-fc3f-4db3-98db-84933d4ceaee", "9384739a-92d7-40c6-9ad4-52679f0e40dd", "Admin", "ADMIN" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
 
        }
    }
}
