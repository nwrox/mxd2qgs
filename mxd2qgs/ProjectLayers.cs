using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace mxd2qgs
{
    class ProjectLayers
    {
        [XmlAttribute("layercount")]
        public string layercount { get; set; }

        [XmlElement("maplayer")]
        public List<MapLayer> maplayers { get; set; }
    }
}
