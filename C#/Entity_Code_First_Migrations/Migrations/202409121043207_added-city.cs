namespace Entity_Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "city", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "city");
        }
    }
}
