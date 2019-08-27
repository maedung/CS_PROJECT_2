﻿// <auto-generated />
using BeltTest2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeltTest2.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20190827172408_firstmigration")]
    partial class firstmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BeltTest2.Models.Enthusiast", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("hobbyid");

                    b.Property<int>("userid");

                    b.HasKey("id");

                    b.HasIndex("hobbyid");

                    b.HasIndex("userid");

                    b.ToTable("Enthusiasts");
                });

            modelBuilder.Entity("BeltTest2.Models.Hobby", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("description")
                        .IsRequired();

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<int>("userid");

                    b.HasKey("id");

                    b.HasIndex("userid");

                    b.ToTable("Hobbies");
                });

            modelBuilder.Entity("BeltTest2.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("firstname")
                        .IsRequired();

                    b.Property<string>("lastname")
                        .IsRequired();

                    b.Property<string>("password")
                        .IsRequired();

                    b.Property<string>("username")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BeltTest2.Models.Enthusiast", b =>
                {
                    b.HasOne("BeltTest2.Models.Hobby", "JoinedList")
                        .WithMany("Hobbylist")
                        .HasForeignKey("hobbyid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BeltTest2.Models.User", "User")
                        .WithMany("HobbyList")
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BeltTest2.Models.Hobby", b =>
                {
                    b.HasOne("BeltTest2.Models.User", "Creator")
                        .WithMany("PostedHobbies")
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
