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
                    nbBeds=4,
                    PictureUrl="assets/cabins/pict/4beds.jpg",
                    Available=true,
                    DateRecorded=""
                },
                new Cabin{
                    Name="Vicente Guerrero",
                    nbBeds=2,
                    PictureUrl="assets/cabins/pict/2beds.jpg",
                    Available=true,
                    DateRecorded=""
                },
                new Cabin{
                    Name="Juarez",
                    nbBeds=1,
                    PictureUrl="assets/cabins/pict/1beds.jpg",
                    Available=true,
                    DateRecorded=""
                },
            };

            await context.Cabins.AddRangeAsync(cabins);
            await context.SaveChangesAsync();
        }

    }
}
