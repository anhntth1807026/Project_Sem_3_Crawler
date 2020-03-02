namespace Project_Sem_3_Crawl.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MyConnection : DbContext
    {
        // Your context has been configured to use a 'MyConnection' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Project_Sem_3_Crawl.Models.MyConnection' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MyConnection' 
        // connection string in the application configuration file.
        public MyConnection()
            : base("name=MyConnection")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Source> Sources { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}