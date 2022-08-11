using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeConomy.Model;

public class ExpenseModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required] public decimal Price { get; set; }
    [Required] public DateOnly Date { get; set; }
    [Required] public string Title { get; set; }
    public string? Description { get; set; }
    
    [Required] public int User_id { get; set; }
    [Required] public virtual UserModel User { get; set; }
    
    [Required] public int Category_id { get; set; }
    [Required] public virtual CategoryModel Category { get; set; }
    
}