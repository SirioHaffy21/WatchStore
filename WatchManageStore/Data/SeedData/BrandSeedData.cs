using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WatchManageStore.Models;

namespace WatchManageStore.Data.SeedData
{
    public class BrandSeedData : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(
                new Brand
                {
                    BrandId = 1,
                    BrandName = "Đồng hồ Philippe Auguste",
                    Image= "thuong-hieu2.png"
                },
                   new Brand
                   {
                       BrandId = 2,
                       BrandName = "Đồng hồ Diamond D",
                       Image = "thuong-hieu3.png"
                   },
                    new Brand
                    {
                        BrandId = 3,
                        BrandName = "Thương hiệu Bovet",
                        Image = "thuong-hieu4.png"
                    },
                    new Brand
                    {
                        BrandId = 4,
                        BrandName = "Thương hiệu Jacques Lemans",
                        Image = "thuong-hieu5.png"
                    },
                    new Brand
                    {
                        BrandId = 5,
                        BrandName = "Thương hiệu Aries Gold",
                        Image = "thuong-hieu6.png"
                    },
                    new Brand
                    {
                        BrandId = 6,
                        BrandName = "Thương hiệu Q&Q",
                        Image = "thuong-hieu6.png"
                    },
                    new Brand
                    {
                        BrandId = 7,
                        BrandName = "Thương hiệu Atlantic Swiss",
                        Image = "thuong-hieu7.png"
                    },
                    new Brand
                    {
                        BrandId = 8,
                        BrandName = "Thương hiệu Hublot",
                        Image = "thuong-hieu8.png"
                    },
                    new Brand
                    {
                        BrandId = 9,
                        BrandName = "Thương hiệu Epos Swiss",
                        Image = "thuong-hieu9.png"
                    },
                    new Brand
                    {
                        BrandId = 10,
                        BrandName = "Thương hiệu Bruno Sohnle Glashutte",
                        Image = "thuong-hieu4.png"
                    }
                ); ;
        }
    }
}

