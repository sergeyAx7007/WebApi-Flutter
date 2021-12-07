namespace WebAPI.Models
{
	/// <summary>
	/// Description and characteristics base food.
	/// </summary>
	internal interface IFood
	{
		/// <summary>
		/// Id number food.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Food name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Food price.
		/// </summary>
		public double Price { get; set; }
	}
}
