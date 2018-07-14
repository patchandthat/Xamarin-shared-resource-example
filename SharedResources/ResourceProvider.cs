using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace SharedResources
{
    public class ResourceProvider
    {
        public Stream GetResource()
        {
            // Dont forget to set build action to Embedded Resource in the properties window

            var assembly = Assembly.GetAssembly(this.GetType());

            Debug.WriteLine("Available resources...");
            foreach (string resourceName in assembly.GetManifestResourceNames())
            {
                Debug.WriteLine(resourceName);
       
            }

            return assembly
                .GetManifestResourceStream(
                    assembly.GetManifestResourceNames().First()); // Get the stream to the embedded resource
        }
    }
}
