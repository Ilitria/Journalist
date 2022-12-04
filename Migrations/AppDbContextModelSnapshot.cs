﻿// <auto-generated />
using Journalist.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Journalist.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Journalist.Models.Domain.Mark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EntryId")
                        .HasColumnType("int");

                    b.Property<double>("MarkValue")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("EntryId");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("Journalist.Models.Entry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Annotation")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Authors")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Path2Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Post")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ThemeOfWork")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Type")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("WorkHeader")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("WorkPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Entries");
                });

            modelBuilder.Entity("Journalist.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AcessLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("EmailVerefied")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Journalist.Models.Domain.Mark", b =>
                {
                    b.HasOne("Journalist.Models.Entry", "Entry")
                        .WithMany("Marks")
                        .HasForeignKey("EntryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entry");
                });

            modelBuilder.Entity("Journalist.Models.Entry", b =>
                {
                    b.HasOne("Journalist.Models.User", "User")
                        .WithOne("Entry")
                        .HasForeignKey("Journalist.Models.Entry", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Journalist.Models.Entry", b =>
                {
                    b.Navigation("Marks");
                });

            modelBuilder.Entity("Journalist.Models.User", b =>
                {
                    b.Navigation("Entry")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}