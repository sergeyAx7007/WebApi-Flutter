using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Services
{
	/// <summary>
	/// Class to manipulation pizza.
	/// </summary>
	internal class PizzaService : IFoodService
	{
		private readonly List<Pizza> _pizzas = new()
		{
			new Pizza { Id = 1, Name = "Classic Italian Pizza", Price = 100, Round = 10 },
			new Pizza { Id = 2, Name = "Veggie Pizza", Price = 110, Round = 20 },
			new Pizza { Id = 3, Name = "Tomato Pizza", Price = 200, Round = 10 },
			new Pizza { Id = 4, Name = "MamaMia Pizza", Price = 300, Round = 10 },
			new Pizza { Id = 5, Name = "Tashir Pizza", Price = 150, Round = 10 },
			new Pizza { Id = 6, Name = "Pepperoni Pizza", Price = 130, Round = 10 },
			new Pizza { Id = 7, Name = "Four cheese Pizza", Price = 120, Round = 10 },
		};

		public string Type => "Pizza";

		/// <summary>
		/// Pizza request by Id.
		/// </summary>
		/// <param name="id">Id number pizza to list</param>
		/// <returns>Pizza by id or null</returns>
		public IFood Get(int id) => _pizzas.FirstOrDefault(p => p.Id == id);

		/// <summary>
		/// List of Pizza
		/// </summary>
		/// <returns>Array of Pizza</returns>
		public Array GetAll() => _pizzas.ToArray();
	}
}