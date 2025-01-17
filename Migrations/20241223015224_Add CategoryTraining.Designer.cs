﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sportlife.Data;

#nullable disable

namespace Sportlife.Migrations
{
    [DbContext(typeof(DataEFContext))]
    [Migration("20241223015224_Add CategoryTraining")]
    partial class AddCategoryTraining
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Sportlife.Data.Entities.CityEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("tblCities");
                });

            modelBuilder.Entity("Sportlife.Data.Entities.CoachCategoryTrainingEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CoachId")
                        .HasColumnType("int");

                    b.Property<int?>("TrainingCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoachId");

                    b.HasIndex("TrainingCategoryId");

                    b.ToTable("tblCoachCategoriesTraining");
                });

            modelBuilder.Entity("Sportlife.Data.Entities.CoachEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("GymId")
                        .HasColumnType("int");

                    b.Property<string>("MainImage")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quote")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GymId");

                    b.ToTable("tblCoaches");
                });

            modelBuilder.Entity("Sportlife.Data.Entities.GymEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FullAddress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("MainImage")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ShortAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("tblGyms");
                });

            modelBuilder.Entity("Sportlife.Data.Entities.TrainingCategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("TrainingCategoryEntity");
                });

            modelBuilder.Entity("Sportlife.Data.Entities.CoachCategoryTrainingEntity", b =>
                {
                    b.HasOne("Sportlife.Data.Entities.CoachEntity", "Coach")
                        .WithMany("CoachCategoriesTraining")
                        .HasForeignKey("CoachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sportlife.Data.Entities.TrainingCategoryEntity", "TrainingCategory")
                        .WithMany("CoachCategoryTraining")
                        .HasForeignKey("TrainingCategoryId");

                    b.Navigation("Coach");

                    b.Navigation("TrainingCategory");
                });

            modelBuilder.Entity("Sportlife.Data.Entities.CoachEntity", b =>
                {
                    b.HasOne("Sportlife.Data.Entities.GymEntity", "Gym")
                        .WithMany()
                        .HasForeignKey("GymId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gym");
                });

            modelBuilder.Entity("Sportlife.Data.Entities.GymEntity", b =>
                {
                    b.HasOne("Sportlife.Data.Entities.CityEntity", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Sportlife.Data.Entities.CoachEntity", b =>
                {
                    b.Navigation("CoachCategoriesTraining");
                });

            modelBuilder.Entity("Sportlife.Data.Entities.TrainingCategoryEntity", b =>
                {
                    b.Navigation("CoachCategoryTraining");
                });
#pragma warning restore 612, 618
        }
    }
}
