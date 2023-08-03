namespace EmployeeManagement.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EmployeeManagement.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeManagement.Models.MSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeManagement.Models.MSContext context)
        {
           // AddOrUpdate()是用來做資料樣本的新增或更新,第一個參數指比對的Key值,第二個參數是新增的Entity資料
            context.Employees.AddOrUpdate(x => x.Id,
                new Employee { Id=1, Name="David",   Mobile="0935-155222", Email="david@gmail.com",  Department="總經理室", Title="總經理" },
                new Employee { Id=2, Name="Mary",    Mobile="0938-456889", Email="mary@gmail.com",   Department="人事部",   Title="管理師" },
                new Employee { Id=3, Name ="Joe",    Mobile="0925-331225", Email="joe@gmail.com",    Department="財務部",   Title="會計" },
                new Employee { Id=4, Name ="Mark",   Mobile="0935-863991", Email="mark@gmail.com",   Department="業務部",   Title="業務" },
                new Employee { Id=5, Name ="Thomas", Mobile="0987-335668", Email="thomas@gmail.com", Department="製造部",   Title="課長" }
            );

            context.Registers.AddOrUpdate(x => x.Id,
                new Register { Id=1, Name="Tom", Gender="men", Nickname="None", Password="password", City="Taipei", Email="tom@gmail.com", Commutermode="motorcycle" }
            );
        }
    }
}
