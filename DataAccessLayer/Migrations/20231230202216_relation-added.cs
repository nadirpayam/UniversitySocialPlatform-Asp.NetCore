using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class relationadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LearnerID",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SectionID",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LearnerTypeID",
                table: "Learners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_LearnerID",
                table: "Posts",
                column: "LearnerID");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_SectionID",
                table: "Posts",
                column: "SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Learners_LearnerTypeID",
                table: "Learners",
                column: "LearnerTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Learners_LearnerTypes_LearnerTypeID",
                table: "Learners",
                column: "LearnerTypeID",
                principalTable: "LearnerTypes",
                principalColumn: "LearnerTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Learners_LearnerID",
                table: "Posts",
                column: "LearnerID",
                principalTable: "Learners",
                principalColumn: "LearnerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Sections_SectionID",
                table: "Posts",
                column: "SectionID",
                principalTable: "Sections",
                principalColumn: "SectionID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Learners_LearnerTypes_LearnerTypeID",
                table: "Learners");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Learners_LearnerID",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Sections_SectionID",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_LearnerID",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_SectionID",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Learners_LearnerTypeID",
                table: "Learners");

            migrationBuilder.DropColumn(
                name: "LearnerID",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "SectionID",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "LearnerTypeID",
                table: "Learners");
        }
    }
}
