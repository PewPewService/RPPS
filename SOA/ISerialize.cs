namespace SOA
{
    public interface ISerialize
    {
        string Serialize<T>(T obj);
        T Deserialize<T>(string str);
    }
}