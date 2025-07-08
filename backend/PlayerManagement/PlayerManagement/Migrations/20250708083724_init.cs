using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlayerManagement.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BloodGroup",
                columns: table => new
                {
                    BloodGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BloodGro__4398C68FDE0DDF3E", x => x.BloodGroupId);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Gender__4E24E9F788C32ACD", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "Religion",
                columns: table => new
                {
                    ReligionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReligionName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Religion__D3ADAB6A825E3C0E", x => x.ReligionId);
                });

            migrationBuilder.CreateTable(
                name: "SportsType",
                columns: table => new
                {
                    SportsTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SportsTy__8F679832FD582307", x => x.SportsTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    TrainingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Training__E8D71D828C6BE2AD", x => x.TrainingId);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime", nullable: true),
                    FathersName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MothersName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MobileNo = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ImageUrl = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NidNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    PlayerWeight = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    LastEducationalQualification = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    SportsTypeId = table.Column<int>(type: "int", nullable: false),
                    BloodGroupId = table.Column<int>(type: "int", nullable: false),
                    ReligionId = table.Column<int>(type: "int", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Player__4A4E74C8446FF317", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK__Player__BloodGro__300424B4",
                        column: x => x.BloodGroupId,
                        principalTable: "BloodGroup",
                        principalColumn: "BloodGroupId");
                    table.ForeignKey(
                        name: "FK__Player__GenderId__2E1BDC42",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "GenderId");
                    table.ForeignKey(
                        name: "FK__Player__Religion__30F848ED",
                        column: x => x.ReligionId,
                        principalTable: "Religion",
                        principalColumn: "ReligionId");
                    table.ForeignKey(
                        name: "FK__Player__SportsTy__2F10007B",
                        column: x => x.SportsTypeId,
                        principalTable: "SportsType",
                        principalColumn: "SportsTypeId");
                });

            migrationBuilder.CreateTable(
                name: "PlayerTrainingAssignment",
                columns: table => new
                {
                    PlayerTrainingAssignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    TrainingId = table.Column<int>(type: "int", nullable: false),
                    TrainingDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Venue = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PlayerTr__055FA1881DFFF5DE", x => x.PlayerTrainingAssignmentId);
                    table.ForeignKey(
                        name: "FK__PlayerTra__Playe__34C8D9D1",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "PlayerId");
                    table.ForeignKey(
                        name: "FK__PlayerTra__Train__35BCFE0A",
                        column: x => x.TrainingId,
                        principalTable: "Training",
                        principalColumn: "TrainingId");
                });

            migrationBuilder.InsertData(
                table: "BloodGroup",
                columns: new[] { "BloodGroupId", "GroupName" },
                values: new object[,]
                {
                    { 1, "A+" },
                    { 2, "A-" },
                    { 3, "B+" },
                    { 4, "B-" }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "GenderId", "GenderName" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" },
                    { 3, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Religion",
                columns: new[] { "ReligionId", "ReligionName" },
                values: new object[,]
                {
                    { 1, "Islam" },
                    { 2, "Hinduism" },
                    { 3, "Christianism" },
                    { 4, "Buddism" }
                });

            migrationBuilder.InsertData(
                table: "SportsType",
                columns: new[] { "SportsTypeId", "TypeName" },
                values: new object[,]
                {
                    { 1, "Cricket" },
                    { 2, "Football" },
                    { 3, "Badminton" },
                    { 4, "Swimming" }
                });

            migrationBuilder.InsertData(
                table: "Training",
                columns: new[] { "TrainingId", "TrainingName" },
                values: new object[,]
                {
                    { 1, "Batting" },
                    { 2, "Bowling" },
                    { 3, "Fielding" },
                    { 4, "Tactical" },
                    { 5, "Strength" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_BloodGroupId",
                table: "Player",
                column: "BloodGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_GenderId",
                table: "Player",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_ReligionId",
                table: "Player",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_SportsTypeId",
                table: "Player",
                column: "SportsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerTrainingAssignment_PlayerId",
                table: "PlayerTrainingAssignment",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerTrainingAssignment_TrainingId",
                table: "PlayerTrainingAssignment",
                column: "TrainingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerTrainingAssignment");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "BloodGroup");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Religion");

            migrationBuilder.DropTable(
                name: "SportsType");
        }
    }
}
