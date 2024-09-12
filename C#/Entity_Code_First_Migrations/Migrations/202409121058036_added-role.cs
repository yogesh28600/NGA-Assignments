namespace Entity_Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedrole : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "role", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "role");
        }
    }
}
