﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Data;

#nullable disable

namespace api.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230930161456_AddLevelXP")]
    partial class AddLevelXP
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("api.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FitnessLevel")
                        .HasColumnType("int");

                    b.Property<int>("FitnessLevelXP")
                        .HasColumnType("int");

                    b.Property<int>("FitnessXP")
                        .HasColumnType("int");

                    b.Property<int>("HouseworkLevel")
                        .HasColumnType("int");

                    b.Property<int>("HouseworkLevelXP")
                        .HasColumnType("int");

                    b.Property<int>("HouseworkXP")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProgrammingLevel")
                        .HasColumnType("int");

                    b.Property<int>("ProgrammingLevelXP")
                        .HasColumnType("int");

                    b.Property<int>("ProgrammingXP")
                        .HasColumnType("int");

                    b.Property<int>("ReadingLevel")
                        .HasColumnType("int");

                    b.Property<int>("ReadingLevelXP")
                        .HasColumnType("int");

                    b.Property<int>("ReadingXP")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
