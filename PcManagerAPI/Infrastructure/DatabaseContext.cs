using Microsoft.EntityFrameworkCore;
using PcManagerAPI.Models;
using WebApplication2.Models;

namespace WebApplication2.Infrastructure;

public class DatabaseContext(DbContextOptions opt) : DbContext(opt)
{
    public DbSet<PC> PCs { get; set; }

    public DbSet<Component> Components { get; set; }

    public DbSet<ComponentType> ComponentTypes { get; set; }

    public DbSet<ComponentManufacturer> ComponentManufacturers { get; set; }

    public DbSet<PCComponent> PCComponents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // PCs
        modelBuilder.Entity<PC>().HasData([
            new PC
            {
                Id = 1,
                Name = "Gaming Beast X",
                Weight = 12.5,
                Warranty = 36,
                CreatedAt = new DateTime(2026, 5, 8, 9, 0, 0),
                Stock = 5
            },
            new PC
            {
                Id = 2,
                Name = "Office Mini Pro",
                Weight = 4.2,
                Warranty = 24,
                CreatedAt = new DateTime(2026, 4, 15, 13, 30, 0),
                Stock = 12
            },
            new PC
            {
                Id = 3,
                Name = "Workstation Ultra",
                Weight = 9.7,
                Warranty = 48,
                CreatedAt = new DateTime(2026, 3, 20, 8, 15, 0),
                Stock = 3
            }
        ]);

        // Component Types
        modelBuilder.Entity<ComponentType>().HasData([
            new ComponentType
            {
                Id = 1,
                Abbreviation = "GPU",
                Name = "Graphics Card"
            },
            new ComponentType
            {
                Id = 2,
                Abbreviation = "CPU",
                Name = "Processor"
            },
            new ComponentType
            {
                Id = 3,
                Abbreviation = "RAM",
                Name = "Memory"
            }
        ]);

        // Manufacturers
        modelBuilder.Entity<ComponentManufacturer>().HasData([
            new ComponentManufacturer
            {
                Id = 1,
                Abbreviation = "NVIDIA",
                FullName = "NVIDIA Corporation",
                FoundationDate = new DateOnly(1993, 4, 5)
            },
            new ComponentManufacturer
            {
                Id = 2,
                Abbreviation = "AMD",
                FullName = "Advanced Micro Devices",
                FoundationDate = new DateOnly(1969, 5, 1)
            },
            new ComponentManufacturer
            {
                Id = 3,
                Abbreviation = "INTEL",
                FullName = "Intel Corporation",
                FoundationDate = new DateOnly(1968, 7, 18)
            }
        ]);

        // Components
        modelBuilder.Entity<Component>().HasData([
            new Component
            {
                Code = "GPU0000001",
                Name = "RTX 5090",
                Description = "High-end gaming GPU",
                ComponentManufacturersId = 1,
                ComponentTypesId = 1
            },
            new Component
            {
                Code = "CPU0000001",
                Name = "Ryzen 9 9950X",
                Description = "High performance processor",
                ComponentManufacturersId = 2,
                ComponentTypesId = 2
            },
            new Component
            {
                Code = "RAM0000001",
                Name = "Corsair 32GB DDR5",
                Description = "DDR5 RAM memory",
                ComponentManufacturersId = 3,
                ComponentTypesId = 3
            }
        ]);

        // PCComponents
        modelBuilder.Entity<PCComponent>().HasData([
            new PCComponent
            {
                PCId = 1,
                ComponentCode = "GPU0000001",
                Amount = 1
            },
            new PCComponent
            {
                PCId = 1,
                ComponentCode = "CPU0000001",
                Amount = 1
            },
            new PCComponent
            {
                PCId = 1,
                ComponentCode = "RAM0000001",
                Amount = 2
            }
        ]);
    }
}