namespace Gym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembership : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IdMembership", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IdMembership");
        }
    }
}
