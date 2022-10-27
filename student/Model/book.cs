using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace student.Model
{
    public class book
    {
        [JsonPropertyName("id")]
        public string book_image { get; set; }
        [JsonPropertyName("name")]
        public string book_name { get; set; }
        [JsonPropertyName("image")]
        public string book_id { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize<book>(this);
        }
    }
}
