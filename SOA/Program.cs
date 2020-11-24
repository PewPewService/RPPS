using System;
using System.Linq;

namespace SOA
{
    public class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var obj = Console.ReadLine();

            ISerialize serializer;
            if (type.ToLower() == "xml") serializer = new XmlSerialize();
            else serializer = new JsonSerialize();

            var input = serializer.Deserialize<Input>(obj);
            var output = new Output
            {
                SumResult = input.Sums.Sum() * input.K,
                MulResult = input.Muls.Aggregate((a, b) => a * b),
                SortedInputs = input.Sums.Concat(input.Muls.Select(n => (decimal)n)).ToArray()
            };
            Array.Sort(output.SortedInputs);

            Console.WriteLine(serializer.Serialize(output));
        }
    }
}
