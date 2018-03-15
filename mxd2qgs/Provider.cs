using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace mxd2qgs
{
    class Provider
    {
        [XmlAttribute("encoding")]
        public string encoding { get; set; }

        [XmlText]
        public string ogr { get; set; }
}
}
