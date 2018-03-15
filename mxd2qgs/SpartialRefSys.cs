using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace mxd2qgs
{
    class SpartialRefSys
    {
        [XmlElement("proj4")]
        public object proj4 { get; set; }

        [XmlElement("srsid")]
        public object srsid { get; set; }

        [XmlElement("srid")]
        public int srid { get; set; }

        [XmlElement("authid")]
        public string authid { get; set; }

        [XmlElement("description")]
        public string description { get; set; }

        [XmlElement("projectionacronym")]
        public object projectionacronym { get; set; }

        [XmlElement("ellipsoidacronym")]
        public string ellipsoidacronym { get; set; }

        [XmlElement("geographicflag")]
        public string geographicflag { get; set; }
    }
}
