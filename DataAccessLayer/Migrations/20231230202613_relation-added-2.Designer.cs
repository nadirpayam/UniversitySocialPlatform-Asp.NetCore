﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231230202613_relation-added-2")]
    partial class relationadded2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("AboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutDetails1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutDetails2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutImage1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutImage2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutMapLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AboutStatus")
                        .HasColumnType("bit");

                    b.HasKey("AboutID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentAnonymousName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CommentCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("CommentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("CommentTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostID")
                        .HasColumnType("int");

                    b.HasKey("CommentID");

                    b.HasIndex("PostID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommunicatorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ContactCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContactMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ContactSubject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Learner", b =>
                {
                    b.Property<int>("LearnerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LearnerAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearnerImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearnerMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearnerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearnerPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LearnerStatus")
                        .HasColumnType("bit");

                    b.Property<string>("LearnerSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LearnerTypeID")
                        .HasColumnType("int");

                    b.HasKey("LearnerID");

                    b.HasIndex("LearnerTypeID");

                    b.ToTable("Learners");
                });

            modelBuilder.Entity("EntityLayer.Concrete.LearnerType", b =>
                {
                    b.Property<int>("LearnerTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LearnerTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LearnerTypeStatus")
                        .HasColumnType("bit");

                    b.HasKey("LearnerTypeID");

                    b.ToTable("LearnerTypes");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Post", b =>
                {
                    b.Property<int>("PostID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LearnerID")
                        .HasColumnType("int");

                    b.Property<string>("PostContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PostStatus")
                        .HasColumnType("bit");

                    b.Property<string>("PostThumbnailImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SectionID")
                        .HasColumnType("int");

                    b.HasKey("PostID");

                    b.HasIndex("LearnerID");

                    b.HasIndex("SectionID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Section", b =>
                {
                    b.Property<int>("SectionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SectionDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SectionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SectionStatus")
                        .HasColumnType("bit");

                    b.HasKey("SectionID");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Learner", b =>
                {
                    b.HasOne("EntityLayer.Concrete.LearnerType", "LearnerType")
                        .WithMany("Learners")
                        .HasForeignKey("LearnerTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LearnerType");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Post", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Learner", "Learner")
                        .WithMany("Posts")
                        .HasForeignKey("LearnerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Section", "Section")
                        .WithMany("Posts")
                        .HasForeignKey("SectionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Learner");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Learner", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.LearnerType", b =>
                {
                    b.Navigation("Learners");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Post", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Section", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
