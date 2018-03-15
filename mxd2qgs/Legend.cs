using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace mxd2qgs
{
    class Legend
    {
        internal class FileGroup {
            [XmlAttribute("hidden")]
            public string hidden { get; set; }

            [XmlAttribute("open")]
            public string open { get; set; }

            [XmlElement("legendlayerfile")]
            public LegendLayerFile legendlayerfile { get; set; }
        }

        internal class LegendLayer
        {
            [XmlAttribute("open")]
            public string open { get; set; }

            [XmlAttribute("checked")]
            public string qtchecked { get; set; }

            [XmlElement("filegroup")]
            public FileGroup filegroup { get; set; }

            [XmlAttribute("name")]
            public string name { get; set; }
        }

        internal class LegendLayerFile {
            [XmlAttribute("isInOverview")]
            public string isInOverview { get; set; }

            [XmlAttribute("layerid")]
            public string layerid { get; set; }

            [XmlAttribute("visible")]
            public string visible { get; set; }
        }
    }
}
