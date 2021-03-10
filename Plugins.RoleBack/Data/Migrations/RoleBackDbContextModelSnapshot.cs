// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Elvet.RoleBack.Data.Migrations
{
    [DbContext(typeof(RoleBackDbContext))]
    internal partial class RoleBackDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.1.21102.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Elvet.RoleBack.Data.UserGuildRoles", b =>
            {
                b.Property<decimal>("User")
                    .HasColumnType("decimal(20,0)")
                    .HasColumnName("peepee");

                b.Property<decimal>("Guild")
                    .HasColumnType("decimal(20,0)");

                b.Property<DateTime>("LeftUtc")
                    .HasColumnType("datetime2");

                b.Property<string>("Roles")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("User", "Guild")
                    .IsClustered();

                b.ToTable("UserGuildRoles");
            });
#pragma warning restore 612, 618
        }
    }
}