// <auto-generated />
using Britney.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Britney.API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("Britney.API.Models.ShowModel", b =>
                {
                    b.Property<int>("ShowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataEvento")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagemURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("Local")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lote")
                        .HasColumnType("TEXT");

                    b.Property<int>("QtdPessoas")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tema")
                        .HasColumnType("TEXT");

                    b.HasKey("ShowId");

                    b.ToTable("ShowsDataBase");
                });
#pragma warning restore 612, 618
        }
    }
}
