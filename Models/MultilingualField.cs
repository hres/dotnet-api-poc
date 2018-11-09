using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Oracle.ManagedDataAccess.Client;

namespace LnhpdApi.Models
{
  public class MultilingualField : Dictionary<string, string>, IXmlSerializable
  {

    XmlSchema IXmlSerializable.GetSchema() { return null; }

    void IXmlSerializable.ReadXml(XmlReader reader) { }

    void IXmlSerializable.WriteXml(XmlWriter writer)
    {
      foreach (var key in this.Keys)
      {
        writer.WriteStartElement("Language");
        writer.WriteAttributeString("Title", key.ToString());
        writer.WriteAttributeString("Value", this[key].ToString());
        writer.WriteEndElement();
      }
    }
  }
}