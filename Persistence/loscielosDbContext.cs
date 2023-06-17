using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class loscielosDbContext : IdentityDbContext<User>
    {
        public loscielosDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cabin> Cabins { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<Media> Medias { get; set; }        
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<RoleByUsers> RoleByUsers { get; set; }
        public DbSet<Review> Reviews { get; set; }
       protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);
           // Relation between a cabin and a customer(user) 
            builder.Entity<Reservation>(x=>x.HasKey(cc=>new {cc.Cabin_id,cc.Customer_id}));
            builder.Entity<Reservation>()
                        .HasOne(x=>x.Customer)
                        .WithMany(x=>x.Reservations)
                        .HasForeignKey(x=>x.Customer_id);
            builder.Entity<Reservation>()
                        .HasOne(x=>x.Cabin)
                        .WithMany(x=>x.Reservations)
                        .HasForeignKey(x=>x.Cabin_id);
            // Relation between Reservation and Payment
            builder.Entity<Reservation>()
                        .HasOne(x=>x.Payment)
                        .WithMany(x=>x.Reservations)
                        .HasForeignKey(x=>x.Payment_id);

            builder.Entity<RoleByUsers>(x=>x.HasKey(kk=>new{kk.Role_Id,kk.User_Id}));
            builder.Entity<RoleByUsers>()
                        .HasOne(x=>x.User)
                        .WithMany(Xx=>Xx.RoleByUsers)
                        .HasForeignKey(x=>x.User_Id);                        
            builder.Entity<RoleByUsers>()
                        .HasOne(x=>x.Role)
                        .WithMany(Xx=>Xx.RoleByUsers)
                        .HasForeignKey(x=>x.Role_Id);

            //Review by reservation (1 customer do 1 review for 1 reservation)
            //builder.Entity<Reservation>(x=>x.HasKey(cc=>new {cc.Review_Id,cc.Customer_id}));
            builder.Entity<Reservation>()
                        .HasOne<Review>(x=>x.Review)
                        .WithOne(x=>x.Reservation)
                        .HasForeignKey<Reservation>(x=>x.Review_Id);
                        
            // builder.Entity<ReviewByCabin>(x=>x.HasKey(rr=>new{rr.Reservation_Id,rr.Review_Id}));
            // builder.Entity<ReviewByCabin>()
            //             .HasOne(x=>x.Reservation)
            //             .WithMany(c=>c.Review)
            //             .HasForeignKey(c=>c.Cabin_Id);
            // builder.Entity<ReviewByCabin>()
            //             .HasOne(x=>x.Review)
            //             .WithMany(c=>c.ReviewByCabins)
            //             .HasForeignKey(c=>c.Review_Id);
       }
        
    }
}