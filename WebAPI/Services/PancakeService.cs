using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Services
{
	/// <summary>
	/// Class to manipulation pancake.
	/// </summary>
	internal class PancakeService : IFoodService
	{
		private readonly List<Pancake> _pancakes = new()
		{
			new Pancake { Id = 1, Name = "Classic Italian Pancake", Price = 100 },
			new Pancake { Id = 2, Name = "Veggie Pancake", Price = 110 }
		};

		public string Type => "Pancake";

		/// <summary>
		/// Pancake request by Id.
		/// </summary>
		/// <param name="id">Id number pancake</param>
		/// <returns>Pancake by id or null</returns>
		public IFood Get(int id) => _pancakes.FirstOrDefault(p => p.Id == id);

		/// <summary>
		///Request all pancake.
		/// </summary>
		/// <returns>Array of pancake</returns>
		public Array GetAll() => _pancakes.ToArray();
	}
}