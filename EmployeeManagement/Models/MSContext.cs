using System.Data.Entity;

namespace EmployeeManagement.Models
{   
    // DbContext負責提供對資料庫作業所需的環境及功能
    public class MSContext:DbContext
    {   
        // MSDbConnection建立的資料庫名稱
        public MSContext() : base("MSDbConnection") { }

        // DbSet用來查詢和儲存Entity資料集合,EF的CRUD作業對象
        public DbSet<Employee> Employees { get; set;}
        public DbSet<Register> Registers { get; set;}
    }
}