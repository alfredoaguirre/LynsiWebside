using System.Text;
using System.IO;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;
namespace Alfredo
{

    public class extensionMethod
    {
        public static string get(this YamlDocument doc, String Key)
        {
            return ((YamlScalarNode)doc.Children[new YamlScalarNode("Divider")]).Value;
        }
    }

}