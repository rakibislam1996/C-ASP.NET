using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDemo
{
    public class Address
    {
        [JsonProperty("street")]
        public string Street { get; set; }
        
        [JsonProperty("city")]
        public string City { get; set; }
        
        [JsonProperty("zipcode")]
        public string ZipCode { get; set; }
        
        [JsonProperty("geo")]
        public Geo Geo { get; set; }
      
    }
    public class Geo
    {
        [JsonProperty("lat")]
        public decimal Latitude { get; set; }
        [JsonProperty("lng")]
        public decimal Longitude { get; set; }
    }
}
