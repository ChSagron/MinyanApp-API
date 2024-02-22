﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MinyanApp.Data;

#nullable disable

namespace MinyanApp.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MinyanApp.Core.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double?>("Accuracy")
                        .HasColumnType("float");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Distance")
                        .HasColumnType("float");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("MinyanApp.Core.Entities.Minyan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsFixed")
                        .HasColumnType("bit");

                    b.Property<int?>("LoctionId")
                        .HasColumnType("int");

                    b.Property<int?>("Nusach")
                        .HasColumnType("int");

                    b.Property<int>("Prayer")
                        .HasColumnType("int");

                    b.Property<int?>("SynagogueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LoctionId");

                    b.HasIndex("SynagogueId");

                    b.ToTable("Minyans");
                });

            modelBuilder.Entity("MinyanApp.Core.Entities.Synagogue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nusach")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Synagogues");
                });

            modelBuilder.Entity("MinyanApp.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsGabai")
                        .HasColumnType("bit");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SynagogueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SynagogueId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MinyanApp.Core.Entities.Minyan", b =>
                {
                    b.HasOne("MinyanApp.Core.Entities.Location", "Loction")
                        .WithMany()
                        .HasForeignKey("LoctionId");

                    b.HasOne("MinyanApp.Core.Entities.Synagogue", "Synagogue")
                        .WithMany("Minyans")
                        .HasForeignKey("SynagogueId");

                    b.Navigation("Loction");

                    b.Navigation("Synagogue");
                });

            modelBuilder.Entity("MinyanApp.Core.Entities.Synagogue", b =>
                {
                    b.HasOne("MinyanApp.Core.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("MinyanApp.Core.Entities.User", b =>
                {
                    b.HasOne("MinyanApp.Core.Entities.Synagogue", "Synagogue")
                        .WithMany("Users")
                        .HasForeignKey("SynagogueId");

                    b.Navigation("Synagogue");
                });

            modelBuilder.Entity("MinyanApp.Core.Entities.Synagogue", b =>
                {
                    b.Navigation("Minyans");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
