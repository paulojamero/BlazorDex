namespace BlazorDex.Pages
{
	public static class PokeUtil
	{
		public const string Pokeball = "https://img.icons8.com/fluency/48/pokeball.png";
		public const string Superball = "https://img.icons8.com/color/48/superball.png"; 
		public const string Megaball = "https://img.icons8.com/color/48/mega-ball.png";


		public static string GetRandomBall()
		{
			var pokeBallArray = new string[] { Pokeball, Superball, Megaball };

			var rand = new Random();
			string randomBall = pokeBallArray[rand.Next(pokeBallArray.Length)];

			return randomBall;
		}

		public static double GetPokemonHeightInMeters(int height)
		{
			return Convert.ToDouble(height) / 10;
		}

		public static double GetPokemonwWeightInKilograms(int weight)
		{
			return Convert.ToDouble(weight) / 10;
		}
	}
}
