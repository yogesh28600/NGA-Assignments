namespace Entity_Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedphone : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "phone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "phone");
        }
    }
}
