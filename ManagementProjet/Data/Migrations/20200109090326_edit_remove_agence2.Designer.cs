﻿// <auto-generated />
using ManagementProjet.Data;
using ManagementProjet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ManagementProjet.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200109090326_edit_remove_agence2")]
    partial class edit_remove_agence2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ManagementProjet.Models.Agence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float?>("AccidentTravail");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("AdrsUrl");

                    b.Property<string>("Cnss");

                    b.Property<float?>("CnssEmployeur");

                    b.Property<string>("Contact")
                        .HasMaxLength(20);

                    b.Property<string>("Fax");

                    b.Property<float?>("Fiprolos");

                    b.Property<string>("GsmContact");

                    b.Property<string>("MatCNSS");

                    b.Property<string>("MatFiscale")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Smigar")
                        .HasMaxLength(20);

                    b.Property<string>("Tel")
                        .IsRequired();

                    b.Property<string>("TelContact");

                    b.Property<string>("Telecopie");

                    b.Property<float?>("Tfp");

                    b.Property<decimal?>("capital");

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<string>("libelle")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("proprietaire")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Agence");
                });

            modelBuilder.Entity("ManagementProjet.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Poste")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ManagementProjet.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<bool>("Douleurs");

                    b.Property<string>("EmailCon")
                        .IsRequired();

                    b.Property<string>("Fax")
                        .IsRequired();

                    b.Property<string>("FaxContact")
                        .IsRequired();

                    b.Property<string>("FoncContact")
                        .IsRequired();

                    b.Property<string>("GsmContact")
                        .IsRequired();

                    b.Property<string>("Libelle")
                        .IsRequired();

                    b.Property<string>("MatFisc")
                        .IsRequired();

                    b.Property<string>("NomContact")
                        .IsRequired();

                    b.Property<string>("Remarque");

                    b.Property<string>("Siteweb");

                    b.Property<int>("TauxTva");

                    b.Property<string>("Tel")
                        .IsRequired();

                    b.Property<string>("TelContact")
                        .IsRequired();

                    b.Property<int>("TypeClt");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("ManagementProjet.Models.OrdreMission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CIN");

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<int>("CompteurFinal");

                    b.Property<int>("CompteurInit");

                    b.Property<string>("Conducteur")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("DateDepart");

                    b.Property<DateTime>("DateMission");

                    b.Property<DateTime>("DateRetour");

                    b.Property<string>("Destinations")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("DetailsMission")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<float?>("FraisMission1");

                    b.Property<float?>("FraisMission2");

                    b.Property<float?>("FraisMission3");

                    b.Property<string>("LibelleMission1")
                        .IsRequired();

                    b.Property<string>("LibelleMission2");

                    b.Property<string>("LibelleMission3");

                    b.Property<string>("NumPermis")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<float?>("Total");

                    b.Property<int>("VehiculeId");

                    b.Property<string>("matricule");

                    b.HasKey("Id");

                    b.HasIndex("VehiculeId");

                    b.ToTable("OrdreMission");
                });

            modelBuilder.Entity("ManagementProjet.Models.Personnel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<string>("Comment");

                    b.Property<int>("Contrat");

                    b.Property<DateTime>("DateNais");

                    b.Property<DateTime>("DateSortie");

                    b.Property<DateTime>("DebutC");

                    b.Property<string>("Echelle")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Echelon")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("FinC");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("LieuNais");

                    b.Property<string>("MatCnss");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("NumCI");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<decimal>("PrimeCA");

                    b.Property<decimal>("Salaire");

                    b.Property<string>("Tache")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Personnel");
                });

            modelBuilder.Entity("ManagementProjet.Models.Vehicule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ARD");

                    b.Property<string>("ARG");

                    b.Property<string>("AVD");

                    b.Property<string>("AVG");

                    b.Property<bool?>("Abs");

                    b.Property<string>("Accessoire");

                    b.Property<bool?>("Actif");

                    b.Property<bool?>("Airbag");

                    b.Property<bool?>("Alarme");

                    b.Property<int?>("Amortis");

                    b.Property<string>("Assise");

                    b.Property<string>("Categorie")
                        .IsRequired();

                    b.Property<int>("Code");

                    b.Property<bool?>("Commandeadistance");

                    b.Property<string>("Couleur");

                    b.Property<int?>("Cylindree");

                    b.Property<DateTime?>("DateAcqui");

                    b.Property<DateTime?>("DateFinG");

                    b.Property<DateTime?>("DatePMC");

                    b.Property<string>("Debout");

                    b.Property<bool?>("DemarrageCode");

                    b.Property<bool?>("Demarrageadistance");

                    b.Property<bool?>("DirectionAssiste");

                    b.Property<int>("Energie");

                    b.Property<int>("Etat");

                    b.Property<bool?>("FermetureCentrale");

                    b.Property<string>("Fourn");

                    b.Property<int?>("IndKilimetre");

                    b.Property<bool?>("JanteAllu");

                    b.Property<string>("Libelle")
                        .IsRequired();

                    b.Property<decimal?>("MantAcqui");

                    b.Property<string>("Marque")
                        .IsRequired();

                    b.Property<string>("Modele")
                        .IsRequired();

                    b.Property<string>("NMoteur");

                    b.Property<string>("Nchassis");

                    b.Property<string>("Observation")
                        .HasMaxLength(1000);

                    b.Property<float?>("PoidsUtile");

                    b.Property<float?>("PoidsVide");

                    b.Property<decimal?>("Pratique");

                    b.Property<bool?>("Radio");

                    b.Property<bool?>("RadioCD");

                    b.Property<decimal?>("Restant");

                    b.Property<bool?>("Saloncuir");

                    b.Property<string>("Secour");

                    b.Property<bool?>("SiegePilote");

                    b.Property<decimal?>("Taxe");

                    b.Property<bool?>("Vendue");

                    b.Property<bool?>("climatise");

                    b.Property<string>("immatricule")
                        .IsRequired();

                    b.Property<string>("puissance");

                    b.Property<decimal?>("theorique");

                    b.HasKey("Id");

                    b.ToTable("Vehicule");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ManagementProjet.Models.OrdreMission", b =>
                {
                    b.HasOne("ManagementProjet.Models.Vehicule", "Vehicule")
                        .WithMany("OrdreMissions")
                        .HasForeignKey("VehiculeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ManagementProjet.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ManagementProjet.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ManagementProjet.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ManagementProjet.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
