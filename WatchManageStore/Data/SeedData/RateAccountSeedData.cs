using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WatchManageStore.Models;

namespace WatchManageStore.Data.SeedData
{
    public class RateAccountSeedData : IEntityTypeConfiguration<RateAccount>
    {
        public void Configure(EntityTypeBuilder<RateAccount> builder)
        {
            builder.HasData(
                new RateAccount
                {
                    RateId= 1,
                    Rate=2,
                    StoreId=1,
                    UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                    CreateOn = new System.DateTime(2021, 01, 01)
                }
                ,
                  new RateAccount
                  {
                      RateId = 2,
                      Rate = 5,
                      StoreId = 2,
                      UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                      CreateOn = new System.DateTime(2023, 05, 01)
                  },
                  new RateAccount
                  {
                      RateId = 3,
                      Rate = 3,
                      WatchId = 1,
                      UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                      CreateOn = new System.DateTime(2021, 05, 01)
                  }
                  ,
                  new RateAccount
                  {
                      RateId = 4,
                      Rate = 2,
                      WatchId = 2,
                      UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                      CreateOn = new System.DateTime(2021, 05, 01)
                  }
                     ,
                  new RateAccount
                  {
                      RateId = 5,
                      Rate = 4,
                      WatchId = 3,
                      UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                      CreateOn = new System.DateTime(2021, 05, 01)
                  },
                  new RateAccount
                  {
                      RateId = 6,
                      Rate = 3,
                      PostId = 1,
                      UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                      CreateOn = new System.DateTime(2021, 12, 11)
                  },
                  new RateAccount
                  {
                      RateId = 7,
                      Rate = 2,
                      PostId = 2,
                      UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                      CreateOn = new System.DateTime(2021, 11, 01)
                  }
                  ,
                  new RateAccount
                  {
                      RateId = 8,
                      Rate = 3,
                      PostId = 3,
                      UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                      CreateOn = new System.DateTime(2021, 11, 11)
                  } 
                  ,
                  new RateAccount
                  {
                      RateId = 9,
                      Rate = 3,
                      PostId = 4,
                      UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                      CreateOn = new System.DateTime(2021, 12, 11)
                  }
                     ,
                  new RateAccount
                  {
                      RateId = 10,
                      Rate = 4,
                      WatchId = 4,
                      UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                      CreateOn = new System.DateTime(2021, 05, 01)
                  } ,
                  new RateAccount
                  {
                      RateId = 11,
                      Rate = 4,
                      WatchId = 5,
                      UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                      CreateOn = new System.DateTime(2021, 05, 01)
                  },
                  new RateAccount
                  {
                      RateId = 12,
                      Rate = 2,
                      PostId = 5,
                      UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                      CreateOn = new System.DateTime(2021, 12, 11)
                  }
                ); 
        }
    }
}
