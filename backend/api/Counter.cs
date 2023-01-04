using Newtonsoft.Json;

namespace Company.Function
{
    public class Counter
    {
        [JsonProperty(PropertyName ="id")]
        public string Id {get;set;}
        
        [JsonProperty(PropertyName ="count")]
        public int Count {get;set;}

        public Microsoft.Azure.Documents.PartitionKey PartitionKey { get; set; }
    }
}