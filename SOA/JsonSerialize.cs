using Newtonsoft.Json;

namespace SOA
{
    public class JsonSerialize : ISerialize
    {
        public string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public T Deserialize<T> (string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }
    }
}
