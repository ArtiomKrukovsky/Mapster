using Newtonsoft.Json;
using System;

namespace MapsterApp.Helpers
{
    public static class ObjectHelper
    {
        public static void Dump<T>(this T x)
        {
            var json = JsonConvert.SerializeObject(x, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
