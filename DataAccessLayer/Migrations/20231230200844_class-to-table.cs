using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class classtotable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutDetails1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDetails2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutImage1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutImage2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutMapLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentAnonymousName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommentStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommunicatorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "Learners",
                columns: table => new
                {
                    LearnerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LearnerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LearnerSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LearnerAbout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LearnerImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LearnerMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LearnerPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LearnerStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Learners", x => x.LearnerID);
                });

            migrationBuilder.CreateTable(
                name: "LearnerTypes",
                columns: table => new
                {
                    LearnerTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LearnerTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LearnerTypeStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearnerTypes", x => x.LearnerTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostThumbnailImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostID);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    SectionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectionStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.SectionID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Learners");

            migrationBuilder.DropTable(
                name: "LearnerTypes");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Sections");
        }
    }
}
