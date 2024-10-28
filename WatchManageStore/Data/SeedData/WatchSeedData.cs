using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WatchManageStore.Models;

namespace WatchManageStore.Data.SeedData
{
    public class WatchSeedData : IEntityTypeConfiguration<Watch>
    {
        public void Configure(EntityTypeBuilder<Watch> builder)
        {
            builder.HasData(
                new Watch
                {
                    WatchId = 1,
                    BrandId = 1,
                    WatchName = "Đồng hồ cao cấp Bovet AS36001SD12",
                    Status = true,
                    Price = 450000000,
                    Description = "",
                    CategoryId = 2,
                    StoreId = 1,
                    Image = "bovet6.jpg"
                },
                        new Watch
                        {
                            WatchId = 2,
                            BrandId = 2,
                            WatchName = "ĐỒNG HỒ PHILIPPE AUGUSTE PA2022",
                            Status = true,
                            Price = 50000000,
                            Description = "",
                            CategoryId = 1,
                            StoreId = 1,
                            CreateOn = new System.DateTime(2021, 12, 11),
                            Image = "dong-ho-nam1.jpg"

                        },
                         new Watch
                         {
                             WatchId = 3,
                             BrandId = 3,
                             WatchName = "Đồng hồ Aries Gold AG-L5033Z G-W",
                             Status = true,
                             Price = 23000000,
                             Description = "",
                             CategoryId = 1,
                             StoreId = 2,
                             CreateOn = new System.DateTime(2021, 02, 10),
                             Image = "dong-ho-nam2.jpg"
                         }
                         ,
                         new Watch
                         {
                             WatchId = 4,
                             BrandId = 4,
                             WatchName = "Đồng Hồ Hublot Classic Fusion Chronograph Titanium Automatic Black Dial Men's Watch",
                             Status = true,
                             Price = 300000000,
                             Description = "",
                             CategoryId = 3,
                             StoreId = 3,
                             CreateOn = new System.DateTime(2021, 10, 03),
                             Image = "dong-ho-nam3.jpg"
                         },
                         new Watch
                         {
                             WatchId = 5,
                             BrandId = 5,
                             WatchName = "Đồng hồ Bruno sohnle 17-13153-241",
                             Status = true,
                             Price = 25000000,
                             Description = "",
                             CategoryId = 1,
                             StoreId = 3,
                             CreateOn = new System.DateTime(2021, 11, 11),
                             Image = "dong-ho-nam4.jpg"
                         },
                         new Watch
                         {
                             WatchId = 6,
                             BrandId = 6,
                             WatchName = "Đồng hồ Q&Q QQ-S278J102Y + QQ-S279J102Y",
                             Status = true,
                             Price = 40000000,
                             Description = "",
                             CategoryId = 3,
                             StoreId = 2,
                             CreateOn = new System.DateTime(2021, 05, 11),
                             Image = "QQdoi.jpg"
                         },
                         new Watch
                         {
                             WatchId = 7,
                             BrandId = 7,
                             WatchName = "ĐỒNG HỒ PHILIPPE AUGUSTE PA-555.2",
                             Status = true,
                             Price = 15000000,
                             Description = "",
                             CategoryId = 1,
                             StoreId = 3,
                             CreateOn = new System.DateTime(2021, 06, 11),
                             Image = "dong-ho-nam5.jpg"
                         },
                         new Watch
                         {
                             WatchId = 8,
                             BrandId = 8,
                             WatchName = "Đồng hồ Jacques Lemans JL - 1 - 1830A",
                             Status = true,
                             Price = 65000000,
                             Description = "",
                             CategoryId = 1,
                             StoreId = 2,
                             CreateOn = new System.DateTime(2021, 01, 01),
                             Image = "dong-ho-nam6.jpg"
                         }

                ); 
        }
    }
}
