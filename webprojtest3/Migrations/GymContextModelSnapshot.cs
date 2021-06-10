﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webprojtest3.Data;

namespace webprojtest3.Migrations
{
    [DbContext(typeof(GymContext))]
    partial class GymContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("webprojtest3.Models.CoursePaper", b =>
                {
                    b.Property<string>("CoursePaperID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CoursePaperID");

                    b.ToTable("CoursePaper");
                });

            modelBuilder.Entity("webprojtest3.Models.User", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

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

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("webprojtest3.Models.Client", b =>
                {
                    b.HasBaseType("webprojtest3.Models.User");

                    b.Property<string>("ClientID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("membership_end_client")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("membership_start_client")
                        .HasColumnType("datetime2");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("webprojtest3.Models.Staff", b =>
                {
                    b.HasBaseType("webprojtest3.Models.User");

                    b.Property<string>("StaffID")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("webprojtest3.Models.Student", b =>
                {
                    b.HasBaseType("webprojtest3.Models.User");

                    b.Property<string>("StudentID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("membership_End")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("membership_Start")
                        .HasColumnType("datetime2");

                    b.Property<bool>("payment")
                        .HasColumnType("bit");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("webprojtest3.Models.Client", b =>
                {
                    b.HasOne("webprojtest3.Models.User", null)
                        .WithOne()
                        .HasForeignKey("webprojtest3.Models.Client", "UserID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webprojtest3.Models.Staff", b =>
                {
                    b.HasOne("webprojtest3.Models.User", null)
                        .WithOne()
                        .HasForeignKey("webprojtest3.Models.Staff", "UserID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webprojtest3.Models.Student", b =>
                {
                    b.HasOne("webprojtest3.Models.User", null)
                        .WithOne()
                        .HasForeignKey("webprojtest3.Models.Student", "UserID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
