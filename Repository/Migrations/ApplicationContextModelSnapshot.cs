﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace Repository.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Guardian", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("PatientID");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("Relation")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("PatientID")
                        .IsUnique();

                    b.ToTable("Guardian");
                });

            modelBuilder.Entity("Domain.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("AddressLine1")
                        .IsRequired();

                    b.Property<string>("AddressLine2")
                        .IsRequired();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("EmiratesID")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("HasGaurdian");

                    b.Property<string>("HomePhone")
                        .IsRequired();

                    b.Property<string>("InsuranceCoverage")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("MailAddress");

                    b.Property<string>("MartialStatus");

                    b.Property<string>("MidName");

                    b.Property<string>("MobilePhone")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Nationality")
                        .IsRequired();

                    b.Property<string>("POBox");

                    b.Property<string>("PassportNumber")
                        .IsRequired();

                    b.Property<string>("Sex")
                        .IsRequired();

                    b.Property<string>("Suffix");

                    b.Property<string>("WorkPhone");

                    b.Property<string>("WorkTitle");

                    b.HasKey("Id");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("Domain.Guardian", b =>
                {
                    b.HasOne("Domain.Patient", "Patient")
                        .WithOne("Guardian")
                        .HasForeignKey("Domain.Guardian", "PatientID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
