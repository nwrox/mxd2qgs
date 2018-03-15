using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace mxd2qgs
{
    class SingleSymbol
    {
        internal class FillColor {
            [XmlAttribute("red")]
            public string red { get; set; }

            [XmlAttribute("blue")]
            public string blue { get; set; }

            [XmlAttribute("green")]
            public string green { get; set; }
        }

        internal class FillPattern {
            [XmlText]
            public string fill { get; set; }
        }

        internal class OutlineColor {
            [XmlAttribute("red")]
            public string red { get; set; }

            [XmlAttribute("blue")]
            public string blue { get; set; }

            [XmlAttribute("green")]
            public string green { get; set; }
        }

        internal class OutlineStyle {
            [XmlText]
            public string outline { get; set; }
        }

        internal class OutlineWidth
        {
            [XmlText]
            public string width { get; set; }
        }

        internal class TexturePath
        {
            [XmlAttribute("null")]
            public string nul { get; set; }
        }

        internal class Symbol {
            [XmlElement("lowervalue")]
            public string lowervalue { get; set; }

            [XmlElement("uppervalue")]
            public string uppervalue { get; set; }

            [XmlElement("label")]
            public string label { get; set; }

            [XmlElement("rotationclassificationfieldname")]
            public string rotationclassificationfieldname { get; set; }

            [XmlElement("scaleclassificationfieldname")]
            public string scaleclassificationfieldname { get; set; }

            [XmlElement("symbolfieldname")]
            public string symbolfieldname { get; set; }

            [XmlElement("outlinecolor")]
            public OutlineColor outlinecolor { get; set; }

            [XmlElement("outlinestyle")]
            public OutlineStyle outlinestyle { get; set; }

            [XmlElement("outlinewidth")]
            public OutlineWidth outlinewidth { get; set; }

            [XmlElement("fillcolor")]
            public FillColor fillcolor { get; set; }

            [XmlElement("fillpattern")]
            public FillPattern fillpattern { get; set; }

            [XmlElement("texturepath")]
            public TexturePath texturepath { get; set; }
        }

        [XmlElement("symbol")]
        public Symbol symbol { get; set; }
    }
}
