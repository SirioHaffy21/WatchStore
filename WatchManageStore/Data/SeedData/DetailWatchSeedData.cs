using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchManageStore.Models;

namespace WatchManageStore.Data.SeedData
{
    public class DetailWatchSeedData : IEntityTypeConfiguration<DetailWatch>
    {
        public void Configure(EntityTypeBuilder<DetailWatch> builder)
        {
            builder.HasData(
                new DetailWatch
                {
                    Id = 1,
                    WatchID=1,
                    Diameter =36,
                    Waterproof=true,
                    Facematerial= "Sapphire mặt trong đính 4 viên kim cương cọc số",
                    WireMaterial= "Dây da chính hãng kèm 1 dây Silver gold ( vàng trắng )",
                    Style="Đồng hồ nữ"
                },
                   new DetailWatch
                   {
                       Id = 2,
                       WatchID = 2,
                       Diameter =40 ,
                       Waterproof = true,
                       Facematerial = "Sapphire mặt trong đính 4 viên kim cương cọc số",
                       WireMaterial = "Dây da chính hãng kèm 1 dây Silver gold ( vàng trắng )",
                       Style = "Đồng hồ nam"

                   },
                   new DetailWatch
                   {
                       Id = 3,
                       WatchID = 3,
                       Diameter =40 ,
                       Waterproof = true,
                       Facematerial = "Sapphire mặt trong đính 4 viên kim cương cọc số",
                       WireMaterial = "Dây da chính hãng kèm 1 dây Silver gold ( vàng trắng )",
                       Style = "Đồng hồ nam"

                   },
                   new DetailWatch
                   {
                       Id = 4,
                       WatchID = 4,
                       Diameter =40 ,
                       Waterproof = true,
                       Facematerial = "Sapphire mặt trong đính 4 viên kim cương cọc số",
                       WireMaterial = "Dây da chính hãng kèm 1 dây Silver gold ( vàng trắng )",
                       Style = "Đồng hồ nam"

                   },
                   new DetailWatch
                   {
                       Id = 5,
                       WatchID = 5,
                       Diameter =40 ,
                       Waterproof = true,
                       Facematerial = "Sapphire mặt trong đính 4 viên kim cương cọc số",
                       WireMaterial = "Dây da chính hãng kèm 1 dây Silver gold ( vàng trắng )",
                       Style = "Đồng hồ nam"

                   },
                   new DetailWatch
                   {
                       Id = 6,
                       WatchID = 6,
                       Diameter =40 ,
                       Waterproof = true,
                       Facematerial = "Sapphire mặt trong đính 4 viên kim cương cọc số",
                       WireMaterial = "Dây da chính hãng kèm 1 dây Silver gold ( vàng trắng )",
                       Style = "Đồng hồ nam"

                   },
                   new DetailWatch
                   {
                       Id = 7,
                       WatchID = 7,
                       Diameter =40 ,
                       Waterproof = true,
                       Facematerial = "Sapphire mặt trong đính 4 viên kim cương cọc số",
                       WireMaterial = "Dây da chính hãng kèm 1 dây Silver gold ( vàng trắng )",
                       Style = "Đồng hồ nam"

                   },
                   new DetailWatch
                   {
                       Id = 8,
                       WatchID = 8,
                       Diameter =40 ,
                       Waterproof = true,
                       Facematerial = "Sapphire mặt trong đính 4 viên kim cương cọc số",
                       WireMaterial = "Dây da chính hãng kèm 1 dây Silver gold ( vàng trắng )",
                       Style = "Đồng hồ nam"

                   }
                );
            ; 
        }
    }
}
