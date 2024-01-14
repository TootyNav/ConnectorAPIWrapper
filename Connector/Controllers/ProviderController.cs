using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Connector.Data;
using Connector.Models.Entities;
using Connector.Repo;
using System.Net.Http;
using System.Text.Json;
using Newtonsoft.Json;

namespace Connector.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProviderController : ControllerBase
{
    private readonly ConnectorContext _context;
    private readonly ICqcRepoService _cqcRepoService;

    public ProviderController(ConnectorContext context, ICqcRepoService cqcRepoService)
    {
        _context = context;
        _cqcRepoService = cqcRepoService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Provider>>> GetProvider()
    {
        //var ffff = await _cqcRepoService.GetProvider("1-10000227676");
        //var fddd = await _cqcRepoService.GetProviderFromByte(ffff);


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
