using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace mxd2qgs
{
    [XmlRoot("qgis")]
    class Qgis
    {
        [XmlAttribute("projectname")]
        public string name { get; set; }

        [XmlAttribute("version")]
        public string version { get; set; }

        [XmlElement("title")]
        public string title { get; set; }

        [XmlElement("mapcanvas")]
        public MapCanvas mapcanvas { get; set; }

        [XmlElement("projectlayers")]
        public ProjectLayers projectlayers { get; set; }
    }
}
