﻿// <auto-generated />
using System;
using ListaDeTarefasCT.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ListaDeTarefasCT.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240902082910_CriandoBanco")]
    partial class CriandoBanco
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("ListaDeTarefasCT.Models.Categoria", b =>
                {
                    b.Property<string>("CategoriaId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            CategoriaId = "trabalho",
                            Nome = "Trabalho"
                        },
                        new
                        {
                            CategoriaId = "casa",
                            Nome = "Casa"
                        },
                        new
                        {
                            CategoriaId = "faculdade",
                            Nome = "Faculdade"
                        },
                        new
                        {
                            CategoriaId = "compras",
                            Nome = "Compras"
                        },
                        new
                        {
                            CategoriaId = "academia",
                            Nome = "Academia"
                        });
                });

            modelBuilder.Entity("ListaDeTarefasCT.Models.Status", b =>
                {
                    b.Property<string>("StatusId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            StatusId = "aberto",
                            Nome = "Aberto"
                        },
                        new
                        {
                            StatusId = "completo",
                            Nome = "Completo"
                        });
                });

            modelBuilder.Entity("ListaDeTarefasCT.Models.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoriaId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataVencimento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StatusId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("StatusId");

                    b.ToTable("Tarefas");
                });

            modelBuilder.Entity("ListaDeTarefasCT.Models.Tarefa", b =>
                {
                    b.HasOne("ListaDeTarefasCT.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ListaDeTarefasCT.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Status");
                });
#pragma warning restore 612, 618
        }
    }
}
