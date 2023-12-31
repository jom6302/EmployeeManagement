﻿namespace EmployeeManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSeedData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        Department = c.String(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Registers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Nickname = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Gender = c.String(),
                        City = c.String(),
                        Commutermode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registers");
            DropTable("dbo.Employees");
        }
    }
}
