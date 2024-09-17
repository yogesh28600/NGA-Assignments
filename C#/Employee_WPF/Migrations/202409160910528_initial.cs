namespace WpfApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        first_name = c.String(nullable: false),
                        middle_name = c.String(nullable: false),
                        last_name = c.String(nullable: false),
                        gender = c.String(nullable: false),
                        country = c.String(nullable: false),
                        dob = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
