﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webprojtest3.Data;

namespace webprojtest3.Migrations
{
    [DbContext(typeof(GymContext))]
    [Migration("20210609231247_Test")]
    partial class Test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("webprojtest3.Models.Client", b =>
                {
                    b.Property<string>("ClientID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emergency_Contact_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emergency_Contact_No")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("f_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("l_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("login_Time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("membership_end")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("membership_start")
                        .HasColumnType("datetime2");

                    b.Property<string>("phone_No")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("webprojtest3.Models.CoursePaper", b =>
                {
                    b.Property<string>("CoursePaperID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CoursePaperID");

                    b.ToTable("CoursePaper");
                });

            modelBuilder.Entity("webprojtest3.Models.Staff", b =>
                {
                    b.Property<string>("StaffID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emergency_Contact_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emergency_Contact_No")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("f_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("l_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("login_Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("phone_No")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StaffID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("webprojtest3.Models.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emergency_Contact_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emergency_Contact_No")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("f_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("l_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("login_Time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("membership_End")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("membership_Start")
                        .HasColumnType("datetime2");

                    b.Property<bool>("payment")
                        .HasColumnType("bit");

                    b.Property<string>("phone_No")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}