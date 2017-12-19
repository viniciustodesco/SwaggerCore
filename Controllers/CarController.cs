using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocApi.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class CarController : Controller
{

    [HttpGet("{Name}")]
    public CarModel Get(string Name)
    {
        return new CarModel
        {
            Name = Name
        };  
    }
}