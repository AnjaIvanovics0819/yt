namespace Gym.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InsertSQL : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Memberships (Type, DateStart, DateEnd) VALUES ( 'd' ,2020-08-08, 2020-08-08)");
            Sql("INSERT INTO Memberships (Type, DateStart, DateEnd) VALUES ('ff', 2020-06-08, 2020-06-08)");
            Sql("INSERT INTO Memberships (Type, DateStart, DateEnd) VALUES ( 'dd',2020-08-08, 2020-08-08)");


            //Sql("INSERT INTO Customers (Name, LastName, DateOfBirth, IdMembership) VALUES ( 'Anja', 'Ivanovic', 2020-08-08)");
        }

        public override void Down()
        {
        }
    }
}
