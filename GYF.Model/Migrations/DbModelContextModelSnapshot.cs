// <auto-generated />
using System;
using GYF.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GYF.Model.Migrations
{
    [DbContext(typeof(DbModelContext))]
    partial class DbModelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GYF.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CUIL")
                        .HasMaxLength(16)
                        .HasColumnType("VARCHAR(16)");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR(64)");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR(64)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("VARCHAR(128)");

                    b.Property<string>("Phone")
                        .HasMaxLength(32)
                        .HasColumnType("VARCHAR(32)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR(64)");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CUIL = "12345678910",
                            Created = new DateTime(2022, 11, 1, 1, 35, 24, 276, DateTimeKind.Local).AddTicks(3922),
                            GenderId = 1,
                            Name = "Juana Maria Perez",
                            Phone = "364412345678"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CUIL = "12345678910",
                            Created = new DateTime(2022, 11, 1, 1, 35, 24, 277, DateTimeKind.Local).AddTicks(2037),
                            GenderId = 2,
                            Name = "Carlos Canto",
                            Phone = "364412345678"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CUIL = "12345678910",
                            Created = new DateTime(2022, 11, 1, 1, 35, 24, 277, DateTimeKind.Local).AddTicks(2056),
                            GenderId = 3,
                            Name = "Manuel Sosa",
                            Phone = "364412345678"
                        });
                });

            modelBuilder.Entity("GYF.Model.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR(64)");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR(64)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("VARCHAR(128)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR(64)");

                    b.HasKey("Id");

                    b.ToTable("Gender");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2022, 11, 1, 1, 35, 24, 278, DateTimeKind.Local).AddTicks(2866),
                            Name = "Femenino"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2022, 11, 1, 1, 35, 24, 278, DateTimeKind.Local).AddTicks(2880),
                            Name = "Masculino"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2022, 11, 1, 1, 35, 24, 278, DateTimeKind.Local).AddTicks(2881),
                            Name = "Otro"
                        });
                });

            modelBuilder.Entity("GYF.Model.Model.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR(64)");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR(64)");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR(64)");

                    b.Property<string>("Password")
                        .HasMaxLength(128)
                        .HasColumnType("VARCHAR(128)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR(64)");

                    b.HasKey("Id");

                    b.ToTable("AppUser");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "admin",
                            Password = "admin"
                        });
                });

            modelBuilder.Entity("GYF.Model.Customer", b =>
                {
                    b.HasOne("GYF.Model.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Gender");
                });
#pragma warning restore 612, 618
        }
    }
}
