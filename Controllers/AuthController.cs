﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using fin_app_backend.Services.Interfaces;
using fin_app_backend.Models;

namespace fin_app_backend.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class AuthController : ControllerBase
  {
    private readonly finappContext _context;
    private readonly IAuthService _authService;

    public AuthController(finappContext context, IAuthService authService)
    {
      _context = context;
      _authService = authService;
    }

    [HttpPost]
    public async Task<AuthResultModel> Add(RegistrationModel payload)
    {
      var data = await _authService.Register(payload);
      return data;
    }
  }
}
