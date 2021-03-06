// <auto-generated />
using MAVN.Job.QuorumTransactionWatcher.MsSqlRepositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAVN.Job.QuorumTransactionWatcher.MsSqlRepositories.Migrations
{
    [DbContext(typeof(QtwContext))]
    [Migration("20190613144817_Initialization")]
    partial class Initialization
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("quorum_transaction_watcher")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MAVN.Job.QuorumTransactionWatcher.MsSqlRepositories.Entities.BlockIndexationStateEntity", b =>
                {
                    b.Property<long>("BlockNumber")
                        .HasColumnName("block_number");

                    b.Property<string>("BlockHash")
                        .IsRequired()
                        .HasColumnName("block_hash")
                        .HasColumnType("varchar(66)");

                    b.HasKey("BlockNumber");

                    b.ToTable("block_indexation_states");
                });
#pragma warning restore 612, 618
        }
    }
}
