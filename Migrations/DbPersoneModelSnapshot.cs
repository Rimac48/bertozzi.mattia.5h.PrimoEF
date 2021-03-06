// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bertozzi.mattia._5H.PrimoEF.Models;

namespace bertozzi.mattia._5H.PrimoEF.Migrations
{
    [DbContext(typeof(DbPersone))]
    partial class DbPersoneModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("bertozzi.mattia._5H.PrimoEF.Models.Persona", b =>
                {
                    b.Property<int>("idPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cognome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("idPersona");

                    b.ToTable("Persone");
                });
#pragma warning restore 612, 618
        }
    }
}
