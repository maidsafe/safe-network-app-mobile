using System.Reflection;
using System.Runtime.Serialization.Json;

namespace MobileSnapp.Helpers
{
    public class ContentHelpers
    {
        private const string jsonFileAssemblyLocation = "MobileSnapp.Data.";

        public static T PopulateData<T>(string fileName)
        {
            var file = jsonFileAssemblyLocation + fileName;
            var assembly = typeof(App).GetTypeInfo().Assembly;
            T obj;
            using (var stream = assembly.GetManifestResourceStream(file))
            {
                var serializer = new DataContractJsonSerializer(typeof(T));
                obj = (T)serializer.ReadObject(stream);
            }
            return obj;
        }
    }
}
