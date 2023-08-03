namespace EmployeeManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserDataAnnotations : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Employees", newName: "CompanyEmployee");
            RenameColumn(table: "dbo.CompanyEmployee", name: "Id", newName: "EmployeeId");
            RenameColumn(table: "dbo.CompanyEmployee", name: "Email", newName: "PersonalEmail");
            AlterColumn("dbo.CompanyEmployee", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.CompanyEmployee", "Mobile", c => c.String(maxLength: 15));
            AlterColumn("dbo.CompanyEmployee", "PersonalEmail", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CompanyEmployee", "PersonalEmail", c => c.String());
            AlterColumn("dbo.CompanyEmployee", "Mobile", c => c.String());
            AlterColumn("dbo.CompanyEmployee", "Name", c => c.String());
            RenameColumn(table: "dbo.CompanyEmployee", name: "PersonalEmail", newName: "Email");
            RenameColumn(table: "dbo.CompanyEmployee", name: "EmployeeId", newName: "Id");
            RenameTable(name: "dbo.CompanyEmployee", newName: "Employees");
        }
    }
}
