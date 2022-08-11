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
        return Ok(await _dataContext.Categories.ToListAsync());
    }

}