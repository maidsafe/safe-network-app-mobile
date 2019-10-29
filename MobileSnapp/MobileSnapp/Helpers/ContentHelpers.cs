// Copyright 2019 MaidSafe.net limited.
//
// This SAFE Network Software is licensed to you under the MIT license <LICENSE-MIT
// https://opensource.org/licenses/MIT> or the Modified BSD license <LICENSE-BSD
// https://opensource.org/licenses/BSD-3-Clause>, at your option. This file may not be copied,
// modified, or distributed except according to those terms. Please review the Licences for the
// specific language governing permissions and limitations relating to use of the SAFE Network
// Software.

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
