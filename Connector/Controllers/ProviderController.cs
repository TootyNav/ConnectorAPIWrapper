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
using Connector.Services;

namespace Connector.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProviderController : ControllerBase
{
    private readonly ICqcRepoService _cqcRepoService;
    private readonly ICqcService _CqcService;

    public ProviderController(ICqcRepoService cqcRepoService, ICqcService cqcService)
    {
        _cqcRepoService = cqcRepoService;
        _CqcService = cqcService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Provider>>> GetProvider()
    {
 

        //var fff = await _CqcService.GetProvider("1-345678912");
        var fff = await _CqcService.GetProvider("1-10000227676");

        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Provider>> GetProvider(string id)
    {
        var provider = await _CqcService.GetProvider(id);

        return provider == null ? NotFound() : provider;
    }

}
