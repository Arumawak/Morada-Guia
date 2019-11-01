﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoradaGuia.API.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MoradaGuia.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191031190535_newdb2")]
    partial class newdb2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MoradaGuia.API.Models.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<string>("Email_FK");

                    b.Property<int>("Id_FK");

                    b.HasKey("Id");

                    b.HasIndex("Email_FK");

                    b.HasIndex("Id_FK");

                    b.ToTable("Comentario");
                });

            modelBuilder.Entity("MoradaGuia.API.Models.Imovel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<DateTime>("Data");

                    b.Property<int>("Garagem");

                    b.Property<int>("Numero");

                    b.Property<int>("Qtd_Banheiro");

                    b.Property<int>("Qtd_Quarto");

                    b.Property<string>("Rua");

                    b.Property<string>("Tipo");

                    b.Property<int>("UserId");

                    b.Property<float>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Imovel");
                });

            modelBuilder.Entity("MoradaGuia.API.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ImovelId");

                    b.Property<bool>("Principal");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("ImovelId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("MoradaGuia.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Criado");

                    b.Property<string>("Email");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<DateTime>("UltimoLogin");

                    b.Property<string>("Username");

                    b.Property<string>("telefone");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MoradaGuia.API.Models.Usuario", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(30);

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("sobrenome")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("telefone")
                        .HasMaxLength(15);

                    b.HasKey("Email");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("MoradaGuia.API.Models.Comentario", b =>
                {
                    b.HasOne("MoradaGuia.API.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("Email_FK");

                    b.HasOne("MoradaGuia.API.Models.Imovel", "Imovel")
                        .WithMany()
                        .HasForeignKey("Id_FK")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MoradaGuia.API.Models.Imovel", b =>
                {
                    b.HasOne("MoradaGuia.API.Models.User", "User")
                        .WithMany("Imovels")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MoradaGuia.API.Models.Photo", b =>
                {
                    b.HasOne("MoradaGuia.API.Models.Imovel", "Imovel")
                        .WithMany("Fotos")
                        .HasForeignKey("ImovelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}