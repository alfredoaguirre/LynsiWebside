using System.Text;
using System.IO;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;
using System;

namespace Alfredo
{

    public static class YamlQuery
    {
        public static string Get(this YamlDocument doc, String Key)
        {
            return ""; //((YamlScalarNode)doc.Children[new YamlScalarNode("Divider")]).Value;
        }
    }

}