﻿// <auto-generated />
using DentistBookingSystem.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DentistBookingSystem.DataAccess.Migrations
{
    [DbContext(typeof(AppointmentStorageContext))]
    partial class AppointmentStorageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppointmentUser", b =>
                {
                    b.Property<int>("AppointmentsId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("AppointmentUser");
                });

            modelBuilder.Entity("DentistBookingSystem.DataAccess.Entities.Alert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Alerts");
                });

            modelBuilder.Entity("DentistBookingSystem.DataAccess.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("DentistBookingSystem.DataAccess.Entities.EmergencyList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlertId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlertId");

                    b.HasIndex("UserId");

                    b.ToTable("EmergencyLists");
                });

            modelBuilder.Entity("DentistBookingSystem.DataAccess.Entities.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("DentistBookingSystem.DataAccess.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AppointmentUser", b =>
                {
                    b.HasOne("DentistBookingSystem.DataAccess.Entities.Appointment", null)
                        .WithMany()
                        .HasForeignKey("AppointmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DentistBookingSystem.DataAccess.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DentistBookingSystem.DataAccess.Entities.EmergencyList", b =>
                {
                    b.HasOne("DentistBookingSystem.DataAccess.Entities.Alert", "Alert")
                        .WithMany("EmergencyLists")
                        .HasForeignKey("AlertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DentistBookingSystem.DataAccess.Entities.User", "User")
                        .WithMany("EmergencyLists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alert");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DentistBookingSystem.DataAccess.Entities.Transaction", b =>
                {
                    b.HasOne("DentistBookingSystem.DataAccess.Entities.User", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DentistBookingSystem.DataAccess.Entities.Alert", b =>
                {
                    b.Navigation("EmergencyLists");
                });

            modelBuilder.Entity("DentistBookingSystem.DataAccess.Entities.User", b =>
                {
                    b.Navigation("EmergencyLists");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
