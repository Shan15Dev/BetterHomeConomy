using HomeConomy.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeConomy.Controllers;

[ApiController]
[Route("api/Categories")]
public class CategoryController : ControllerBase
{
    private readonly DataContext _dataContext;

    public CategoryController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [HttpGet]
    public async Task<ActionResult<List<CategoryModel>>> GetAllCategories()
    {
        return Ok(await _dataContext.Category.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<List<CategoryModel>>> GetById(int id)
    {
        var result = await _dataContext.Category.FindAsync(id);
        if (result == null)
        {
            return NotFound();
        }

        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<List<CategoryModel>>> CreateCategory(CategoryModel category)
    {
        _dataContext.Category.Add(category);
        await _dataContext.SaveChangesAsync();

        return Ok(await _dataContext.Category.ToListAsync());
    }
    
}