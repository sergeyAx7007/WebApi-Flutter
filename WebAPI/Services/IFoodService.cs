using System;
using WebAPI.Models;

namespace WebAPI.Services
{
	/// <summary>
	/// Method for get information of food.
	/// </summary>
	internal interface IFoodService
	{
		/// <summary>
		/// The type of the service
		/// </summary>
		public string Type { get; }

		/// <summary>
		/// Food request by Id.
		/// </summary>
		/// <param name="id">Id number food</param>
		/// <returns>Food by id or null</returns>
		public IFood Get(int id);

		/// <summary>
		///Request all food.
		/// </summary>
		/// <returns>Array of food</returns>
		public Array GetAll();
	}
}
