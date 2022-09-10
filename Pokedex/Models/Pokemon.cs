using System;
using System.Text.Json.Serialization;

namespace Pokedex.Models
{
	public class Pokemon
	{
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("height")]
        public long Height { get; set; }

        [JsonPropertyName("base_experience")]
        public long BaseExperience { get; set; }

        [JsonPropertyName("weight")]
        public long Weight { get; set; }
    }
}
