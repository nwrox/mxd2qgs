using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace mxd2qgs
{
    class MapCanvas
    {
        internal class DestinationSrs {
            [XmlElement("spartialrefsys")]
            public SpartialRefSys spartialrefsys { get; set; }
        }

        internal class Extent
        {
            [XmlElement("xmax")]
            public float xmax { get; set; }

            [XmlElement("ymax")]
            public float ymax { get; set; }

            [XmlElement("xmin")]
            public float xmin { get; set; }

            [XmlElement("ymin")]
            public float ymin { get; set; }
        }

        [XmlElement("units")]
        public string units { get; set; }

        [XmlElement("extent")]
        public Extent extent { get; set; }

        [XmlElement("projections")]
        public string projections { get; set; }

        [XmlElement("destinationsrs")]
        public DestinationSrs destinationsrs { get; set; }
    }
}
