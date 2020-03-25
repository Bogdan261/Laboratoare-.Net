using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Laborator4
{
    public class Class1
    {
    }


    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Stock { get; set; }
        public double Price { get; set; }
        public int Deleted { get; set; }
        public ICollection<OrderDetails> OrderDetails {get; set;}
        public int OrderDetailsID { get; set; }




    }
    public partial class OrderDetails
    {
        public int OrderDetailsId  {get; set;}
        public int ProductId { get; set; }
        public double Qty { get; set; }
        public double Price { get; set; }
        public int Deleted { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }

        protected OrderDetails() { }




    }

    public partial class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public int Payed { get; set; }
        public int ClientId { get; set; }
        public int Deleted { get; set; }
        public Client Client { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }

        protected Order() { }



    }
    public partial class Client 
    {
    public int ClientId { get; set; }
    
    public string Name { get; set; }
   
    public string Email { get; set; }
    // 0 = inregistrare corecta; 1 =inregistrare stearsa//
    public int Deleted { get; set; }
    public ICollection<Order> Orders { get; set; }
     protected Client() { } 
    
    
    }



    internal class ModelContext: DbContext
    {
        public DbSet <Client> Clients { get; set; }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=DESKTOP-BHHLHIS\\SQLEXPRESS;Database=EFCore2020;Trusted_Connection=True");//ChangeTracker.LazyLoadingEnabled = false;
        
        }
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany<Order>(o => o.Orders)
                .WithOne(c => c.Client);
            modelBuilder.Entity<OrderDetails>()
                .HasOne<Order>(od => od.Order)
                .WithMany(o => o.OrderDetails); 
            modelBuilder.Entity<Product>()
                .HasMany<OrderDetails>(p => p.OrderDetails)
                .WithOne(od => od.Product);



        }



    }

}
