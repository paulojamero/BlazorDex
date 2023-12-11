using BlazorDex.Models;
using System.Text.Json;

namespace BlazorDex.Utils
{
	public class PokeClient
	{
		private readonly HttpClient client; //inject the http client to Pokemon client

		public PokeClient(HttpClient client) //create consutrctor
		{
			this.client = client; 
		}

		//fetch api
		public async Task<Pokemon> GetPokemon(string id)
		{
			var response = await this.client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");
			var content = await response.Content.ReadAsStringAsync(); //get the response

			return JsonSerializer.Deserialize<Pokemon>(content); //return the content
		}
    }
}
