using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(loscielosDbContext context)
        {
            if (context.Cabins.Any()) return;

            var cabins = new List<Cabin>
            {
                new Cabin{
                    Name="Jose Maria Morelos Pavon",
                    Nb_Bed=4,
                    Total_Occupancy=8,
                    PictureUrl="assets/cabins/pict/4beds.jpg",
                    Available=true,
                    Created_at="",
                    Adress="Los Cielos Boca del Cielo 30513 Chiapas Mexico https://goo.gl/maps/g17CdcX635LQC8pA6",
                    Longitude=15.845768,
                    Latitude=93.668882

                    
                },
                new Cabin{
                    Name="Vicente Guerrero",
                    Nb_Bed=2,
                    Total_Occupancy=4,
                    PictureUrl="assets/cabins/pict/2beds.jpg",
                    Available=true,
                    Created_at=""
                },
                new Cabin{
                    Name="Juarez",
                    Nb_Bed=1,
                    Total_Occupancy=3,
                    PictureUrl="assets/cabins/pict/1beds.jpg",
                    Available=true,
                    Created_at=""
                },
            };

            await context.Cabins.AddRangeAsync(cabins);
            await context.SaveChangesAsync();
        }

    }
}
