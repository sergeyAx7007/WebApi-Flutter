using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Services
{
	/// <summary>
	/// Class to manipulation wok.
	/// </summary>
	internal class WokService : IFoodService
	{
		private readonly List<Wok> _woks = new()
		{
			new Wok { Id = 1, Name = "Classic Italian Wok", Price=100, Spice = false },
			new Wok { Id = 2, Name = "Veggie Wok", Price = 110, Spice = true },
			new Wok { Id = 3, Name = "Classic chicken Wok", Price = 130, Spice = false },
			new Wok { Id = 4, Name = "Classic seafood Wok", Price = 140, Spice = false },
			new Wok { Id = 5, Name = "Classic pork wok", Price = 140, Spice = false },
		};

		public string Type => "Wok";

		/// <summary>
		/// Wok request by Id.
		/// </summary>
		/// <param name="id">Id number wok</param>
		/// <returns>Wok by id or null</returns>
		public IFood Get(int id) => _woks.FirstOrDefault(p => p.Id == id);

		/// <summary>
		///Request all wok.
		/// </summary>
		/// <returns>Array of woks</returns>
		public Array GetAll() => _woks.ToArray();
	}
}