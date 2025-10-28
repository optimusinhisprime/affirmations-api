using AffirmationsAPI.Data;
using AffirmationsAPI.DTOs;
using AffirmationsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AffirmationsAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AffirmationsController : ControllerBase
{
    private readonly ApiDbContext _context;

    public AffirmationsController(ApiDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<Affirmation>> Get()
    {
        return await _context.Affirmations.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Affirmation>> Post([FromBody] CreateAffirmationDto dto)
    {
        var affirmation = new Affirmation
        {
            Title = dto.Title,
            Body = dto.Body,
            Author = dto.Author,
        };

        _context.Affirmations.Add(affirmation);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(Get), new { id = affirmation.Id }, affirmation);
    }
}
