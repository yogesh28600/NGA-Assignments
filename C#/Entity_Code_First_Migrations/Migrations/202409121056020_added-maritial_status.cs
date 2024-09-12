namespace Entity_Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedmaritial_status : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "maritial_status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "maritial_status");
        }
    }
}
