namespace Entity_Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dep_Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Emp_Name = c.String(maxLength: 20),
                        Gender = c.String(maxLength: 10),
                        Age = c.Int(nullable: false),
                        Salary = c.Double(nullable: false),
                        Dep_Id_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Dep_Id_Id)
                .Index(t => t.Dep_Id_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Dep_Id_Id", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Dep_Id_Id" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
