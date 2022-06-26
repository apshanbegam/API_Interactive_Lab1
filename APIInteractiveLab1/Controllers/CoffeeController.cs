using System;
using Microsoft.AspNetCore.Mvc;
using APIInteractiveLab1.Models;

namespace APIInteractiveLab1.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CoffeeController : ControllerBase
	
	{
		[HttpGet("{name}")]
		public Coffee Get(string? name)
		{
			return new Coffee
			{
				Id = (name != null ? 7 : -1),

				Name = name ?? "latte"
			};
		}

		[HttpGet("lover")]
		public string GetCoffeeLover()
		{
			return "I like coffee!";
		}
	}
}

