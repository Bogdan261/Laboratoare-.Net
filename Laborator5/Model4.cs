namespace Laborator5
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model4 : DbContext
    {
        // Your context has been configured to use a 'Model4' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Laborator5.Model4' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model4' 
        // connection string in the application configuration file.
        public Model4()
            : base("Server = DESKTOP-BHHLHIS\\SQLEXPRESS;Database=Laborator5; Trusted_Connection=True;  MultipleActiveResultSets=True")
        {
        }
        public DbSet<Business> Businesses {set;get;}

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}