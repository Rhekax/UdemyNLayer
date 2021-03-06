// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UdemyNLayer.Data;

namespace UdemyNLayer.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210809145410_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UdemyNLayer.Core.Entitiy_Model_.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kalemler",
                            isDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            Name = "Defterler",
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("UdemyNLayer.Core.Entitiy_Model_.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("InnerBarcode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal (18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            IsDeleted = false,
                            Name = "Pilot Kalem",
                            Price = 12.50m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            IsDeleted = false,
                            Name = "Kur;un Kalem",
                            Price = 50.50m,
                            Stock = 200
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            IsDeleted = false,
                            Name = "Tukenmez Kalem",
                            Price = 500m,
                            Stock = 400
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            IsDeleted = false,
                            Name = "Kucuk boy defter",
                            Price = 20.50m,
                            Stock = 300
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            IsDeleted = false,
                            Name = "orta boy defter",
                            Price = 30.50m,
                            Stock = 300
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            IsDeleted = false,
                            Name = "buyuk boy defter",
                            Price = 40.50m,
                            Stock = 300
                        });
                });

            modelBuilder.Entity("UdemyNLayer.Core.Entitiy_Model_.Products", b =>
                {
                    b.HasOne("UdemyNLayer.Core.Entitiy_Model_.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("UdemyNLayer.Core.Entitiy_Model_.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
