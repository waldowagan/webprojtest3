﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webprojtest3.Data;

namespace webprojtest3.Migrations
{
    [DbContext(typeof(GymContext))]
    [Migration("20210604090038_InitialCreate1")]
    partial class InitialCreate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("webprojtest3.Models.Student", b =>
                {
                    b.Property<string>("StudentID")
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

                    b.Property<string>("phone_No")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
