﻿// <auto-generated />
using System;
using Construccion.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Construccion.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240502141959_jelou")]
    partial class jelou
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("construccion.Shared.Entities.AssigmentMats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdMats")
                        .HasColumnType("int");

                    b.Property<int>("IdTasks")
                        .HasColumnType("int");

                    b.Property<int?>("Materialessid")
                        .HasColumnType("int");

                    b.Property<int?>("TareasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Materialessid");

                    b.HasIndex("TareasId");

                    b.ToTable("AssigmentMatss");
                });

            modelBuilder.Entity("construccion.Shared.Entities.AssignmentsTeams", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EquiConssid")
                        .HasColumnType("int");

                    b.Property<int>("IdConstr")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectConstrsid")
                        .HasColumnType("int");

                    b.Property<int>("idTeams")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquiConssid");

                    b.HasIndex("ProjectConstrsid");

                    b.ToTable("AssignmentsTeamss");
                });

            modelBuilder.Entity("construccion.Shared.Entities.EquiCons", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Especialidades")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("Lista_Miembros")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("EquiConss");
                });

            modelBuilder.Entity("construccion.Shared.Entities.Materiales", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaE")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProjectConstrId")
                        .HasColumnType("int");

                    b.Property<string>("Proveedor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.HasIndex("ProjectConstrId");

                    b.ToTable("Materialess");
                });

            modelBuilder.Entity("construccion.Shared.Entities.Presupuesto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<double>("ManoObra")
                        .HasColumnType("float");

                    b.Property<double>("Maquinaria")
                        .HasColumnType("float");

                    b.Property<double>("Material")
                        .HasColumnType("float");

                    b.Property<double>("Otros")
                        .HasColumnType("float");

                    b.Property<int>("ProjectConstrId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("ProjectConstrId");

                    b.ToTable("Presupuestos");
                });

            modelBuilder.Entity("construccion.Shared.Entities.ProjectConstr", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("FechaEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Locate")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.HasIndex("id")
                        .IsUnique();

                    b.ToTable("ProjectConstrs");
                });

            modelBuilder.Entity("construccion.Shared.Entities.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("FechaEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("ProjectConstrId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectConstrId");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("construccion.Shared.Entities.machinery", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("CantReque")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateOnly>("FechaEntrga")
                        .HasColumnType("date");

                    b.Property<int>("ProjectConstrId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectTareas")
                        .HasColumnType("int");

                    b.Property<string>("Proveed")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("tareasId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("ProjectConstrId");

                    b.HasIndex("tareasId");

                    b.ToTable("Machineries");
                });

            modelBuilder.Entity("construccion.Shared.Entities.AssigmentMats", b =>
                {
                    b.HasOne("construccion.Shared.Entities.Materiales", "Materialess")
                        .WithMany("AssigmentMatss")
                        .HasForeignKey("Materialessid");

                    b.HasOne("construccion.Shared.Entities.Tarea", "Tareas")
                        .WithMany("assigmentMatss")
                        .HasForeignKey("TareasId");

                    b.Navigation("Materialess");

                    b.Navigation("Tareas");
                });

            modelBuilder.Entity("construccion.Shared.Entities.AssignmentsTeams", b =>
                {
                    b.HasOne("construccion.Shared.Entities.EquiCons", "EquiConss")
                        .WithMany("AssignmentsTeamss")
                        .HasForeignKey("EquiConssid");

                    b.HasOne("construccion.Shared.Entities.ProjectConstr", "ProjectConstrs")
                        .WithMany("AssignmentsTeamss")
                        .HasForeignKey("ProjectConstrsid");

                    b.Navigation("EquiConss");

                    b.Navigation("ProjectConstrs");
                });

            modelBuilder.Entity("construccion.Shared.Entities.Materiales", b =>
                {
                    b.HasOne("construccion.Shared.Entities.ProjectConstr", "ProjectConstrs")
                        .WithMany()
                        .HasForeignKey("ProjectConstrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectConstrs");
                });

            modelBuilder.Entity("construccion.Shared.Entities.Presupuesto", b =>
                {
                    b.HasOne("construccion.Shared.Entities.ProjectConstr", "ProjectConstrs")
                        .WithMany()
                        .HasForeignKey("ProjectConstrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectConstrs");
                });

            modelBuilder.Entity("construccion.Shared.Entities.Tarea", b =>
                {
                    b.HasOne("construccion.Shared.Entities.ProjectConstr", "ProjectConstrs")
                        .WithMany()
                        .HasForeignKey("ProjectConstrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectConstrs");
                });

            modelBuilder.Entity("construccion.Shared.Entities.machinery", b =>
                {
                    b.HasOne("construccion.Shared.Entities.ProjectConstr", "ProjectConstrs")
                        .WithMany()
                        .HasForeignKey("ProjectConstrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("construccion.Shared.Entities.Tarea", "tareas")
                        .WithMany()
                        .HasForeignKey("tareasId");

                    b.Navigation("ProjectConstrs");

                    b.Navigation("tareas");
                });

            modelBuilder.Entity("construccion.Shared.Entities.EquiCons", b =>
                {
                    b.Navigation("AssignmentsTeamss");
                });

            modelBuilder.Entity("construccion.Shared.Entities.Materiales", b =>
                {
                    b.Navigation("AssigmentMatss");
                });

            modelBuilder.Entity("construccion.Shared.Entities.ProjectConstr", b =>
                {
                    b.Navigation("AssignmentsTeamss");
                });

            modelBuilder.Entity("construccion.Shared.Entities.Tarea", b =>
                {
                    b.Navigation("assigmentMatss");
                });
#pragma warning restore 612, 618
        }
    }
}
