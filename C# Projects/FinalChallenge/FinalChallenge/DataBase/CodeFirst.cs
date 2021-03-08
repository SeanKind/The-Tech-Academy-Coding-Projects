namespace FinalChallenge
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class CodeFirst : DbContext
    {
        // Your context has been configured to use a 'CodeFirst' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'FinalChallenge.CodeFirst' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CodeFirst' 
        // connection string in the application configuration file.
        public CodeFirst()
            : base("name=CodeFirst")
        {
        }
        public virtual DbSet<WaterBottle> WaterBottles { get; set; }
    }

    public class WaterBottle
    {
        [Key]
        public int Id { get; set; }
        public int Oz { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}