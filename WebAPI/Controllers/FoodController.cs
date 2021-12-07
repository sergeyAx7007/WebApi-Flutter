using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
	/// <summary>
	/// This class is controller manage food.
	/// </summary>
	[Route("[controller]")]
	[ApiController]
	public class FoodController : ControllerBase
	{
		private readonly IFoodFactory _foodFactory;
		/// <summary>
		/// Constructor for getting object FoodFactory
		/// </summary>
		/// <param name="service">Service from IServiceCollection</param>
		public FoodController(IServiceProvider service)
		{
			_foodFactory = service.GetRequiredService<IFoodFactory>();
		}

		/// <summary>
		/// Request all food
		/// </summary>
		/// <returns></returns>
		[HttpGet("")]
		public ActionResult GetAll()
		{
			List<object> allFood=new List<object> ();
			FoodFactory foodFactory =(FoodFactory) _foodFactory;
			foreach(var listFoodType in foodFactory._servicesByType)
			{
				IFood[] arrayFood = (IFood[])GetFood(listFoodType.Value.Type);
				foreach (var food in arrayFood)
				{
					allFood.Add(food);
				}
			}
			return Ok(allFood);
		}

		/// <summary>
		///Request all food from kind.
		/// </summary>
		/// <param name="food">Kind of food</param>
		/// <returns>Array of Food</returns>
		[HttpGet("{food}")]
		public ActionResult GetAll(string food)
		{
			return Ok(GetFood(food));
		}

		/// <summary>
		/// Food request by Id.
		/// </summary>
		/// <param name="food">Kind of food</param>
		/// <param name="id">Id number food to array</param>
		/// <returns>Food by id or null</returns>
		[HttpGet("{food}/{id}")]
		public ActionResult Get(string food, int id)
		{
			return Ok(GetFood(food, id));
		}

		private object GetFood(string food, int index = 0)
		{
			var foodService = _foodFactory.CreateFoodService(food);
			if (foodService != null)
			{
				if (index == 0)
				{
					return foodService.GetAll();
				}

				return foodService.Get(index);
			}

			return NotFound();
		}
	}
}
