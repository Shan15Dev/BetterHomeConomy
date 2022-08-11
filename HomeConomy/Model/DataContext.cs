using Microsoft.EntityFrameworkCore;

namespace HomeConomy.Model;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<CategoryModel> Categories { get; set; }
    public DbSet<ExpenseModel> Expenses { get; set; }
    public DbSet<RoleModel> Roles { get; set; }
    public DbSet<UserModel> Users { get; set; }
}