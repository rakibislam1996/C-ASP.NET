using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDemo
{
    [Serializable]
    public class Customer
    {
        // During deserialization the property name as declared in json string will be matched (Equal())
        // If the name matches with the model class property name (case of character doesn't matter) then no need for [JsonProperty("id")]

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }
    }
}
