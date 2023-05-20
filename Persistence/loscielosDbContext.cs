using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class loscielosDbContext : DbContext
    {
        public loscielosDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cabin> Cabins { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<Media> Medias { get; set; }        
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleByUser> Roles_by_users { get; set; }
        public DbSet<User> Users { get; set; }
    }
}