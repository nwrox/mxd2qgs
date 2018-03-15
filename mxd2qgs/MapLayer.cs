using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace mxd2qgs
{
    class MapLayer
    {
        internal class TransparencyLevelInt
        {
            [XmlText]
            public string transparency { get; set; }
        }

        [XmlAttribute("minimumScale")]
        public string minimumScale { get; set; }

        [XmlAttribute("maximumScale")]
        public string maximumScale { get; set; }

        [XmlAttribute("minLabelScale")]
        public string minLabelScale { get; set; }

        [XmlAttribute("maxLabelScale")]
        public string maxLabelScale { get; set; }

        [XmlAttribute("geometry")]
        public string geometry { get; set; }

        [XmlAttribute("type")]
        public string type { get; set; }

        [XmlAttribute("hasScaleBasedVisibilityFlag")]
        public string hasScaleBasedVisibilityFlag { get; set; }

        [XmlAttribute("scaleBasedLabelVisibilityFlag")]
        public string scaleBasedLabelVisibilityFlag { get; set; }

        [XmlElement("id")]
        public string id { get; set; }

        [XmlElement("datasource")]
        public string datasource { get; set; }

        [XmlElement("layername")]
        public string layername { get; set; }

        [XmlElement("srs")]
        public string srs { get; set; }

        [XmlElement("spatialrefsys")]
        public SpartialRefSys spatialrefsys { get; set; }

        [XmlElement("transparencyLevelInt")]
        public TransparencyLevelInt transparencyLevelInt { get; set; }

        [XmlElement("customproperties")]
        public string customproperties { get; set; }

        [XmlElement("provider")]
        public Provider provider { get; set; }

        [XmlElement("singlesymbol")]
        public string singlesymbol { get; set; }


    }
}
