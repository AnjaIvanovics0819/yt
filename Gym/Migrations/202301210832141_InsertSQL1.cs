namespace Gym.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InsertSQL1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, LastName, DateOfBirth,IdMembership) VALUES ( 'Aoo' , 'aaa', 2020-08-08, 1)");
            Sql("INSERT INTO Customers (Name, LastName, DateOfBirth,IdMembership) VALUES ( 'Aoo' , 'aaa', 2020-08-08, 2)");
            Sql("INSERT INTO Customers (Name, LastName, DateOfBirth,IdMembership) VALUES ( 'Aoo' , 'aaa', 2020-08-08, 3)");
            Sql("INSERT INTO Customers (Name, LastName, DateOfBirth,IdMembership) VALUES ( 'Aoo' , 'aaa', 2020-08-08, 4)");
            Sql("INSERT INTO Customers (Name, LastName, DateOfBirth,IdMembership) VALUES ('Aoo' , 'aaa', 2020-08-08, 1)");
        }

        public override void Down()
        {
        }
    }
}
