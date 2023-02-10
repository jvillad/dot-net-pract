using System.Text.Json;
using System.Text.Json.Serialization;

namespace DotNetTest.Models
{
    public class Product
    {
        public string? Id { get; set; }
        public int? Maker { get; set; }

        // mapping img from json to int Image
        [JsonPropertyName("img")]
        public int Image { get; set; }
        public int? Url { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int[]? Ratings { get; set; }

        // taking all object information and converting it back json 
        public override string ToString() => JsonSerializer.Serialize<Product>(this);



    }
}
