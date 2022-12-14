// <auto-generated />
using DailySharePrice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DailySharePrice.Migrations
{
    [DbContext(typeof(SharePriceContext))]
    partial class SharePriceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DailySharePrice.Models.DailyStockDetails", b =>
                {
                    b.Property<int>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StockName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StockValue")
                        .HasColumnType("int");

                    b.HasKey("StockId");

                    b.ToTable("DailyStockDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
