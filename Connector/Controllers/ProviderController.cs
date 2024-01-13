using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Connector.Data;
using Connector.Models.Entities;

namespace Connector.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProviderController : ControllerBase
{
    private readonly ConnectorContext _context;

    public ProviderController(ConnectorContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Provider>>> GetProvider()
    {
        return await _context.Provider.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Provider>> GetProvider(string id)
    {
        var provider = await _context.Provider.FindAsync(id);

        if (provider == null)
        {
            return NotFound();
        }

        return provider;
    }

}
