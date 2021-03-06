// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(UserDBContext))]
    [Migration("20210712204605_updateUserEntity")]
    partial class updateUserEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.ChildEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Dateborn")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("UserEntityId")
                        .HasColumnType("int");

                    b.Property<string>("identity")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("tzUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Child");
                });

            modelBuilder.Entity("Entities.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Dateborn")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("HMO")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Identity")
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("Kind")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("NumOfChildren")
                        .HasColumnType("int ");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Entities.ChildEntity", b =>
                {
                    b.HasOne("Entities.UserEntity", null)
                        .WithMany("Children")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("Entities.UserEntity", b =>
                {
                    b.Navigation("Children");
                });
#pragma warning restore 612, 618
        }
    }
}
