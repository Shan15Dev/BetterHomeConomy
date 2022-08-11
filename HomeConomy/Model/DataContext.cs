using Microsoft.EntityFrameworkCore;

namespace HomeConomy.Model;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<CategoryModel> Category { get; set; }
    public DbSet<ExpenseModel> Expense { get; set; }
    public DbSet<RoleModel> Role { get; set; }
    public DbSet<UserModel> User { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}