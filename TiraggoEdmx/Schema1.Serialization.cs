//------------------------------------------------------------------------------
// <auto-generated>
//     This source code was auto-generated by XsdClassGen.tt.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace TiraggoEdmx
{
	public partial class Schema1
	{
		public static Schema1 DeserializeFrom(Stream stream)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Schema1));
			return (Schema1)serializer.Deserialize(stream);
		}

		public static Schema1 DeserializeFrom(TextReader reader)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Schema1));
			return (Schema1)serializer.Deserialize(reader);
		}

		public static Schema1 DeserializeFrom(XmlReader reader)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Schema1));
			return (Schema1)serializer.Deserialize(reader);
		}

		public void SerializeTo(Stream stream)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Schema1));
			serializer.Serialize(stream, this);
		}

		public void SerializeTo(TextWriter writer)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Schema1));
			serializer.Serialize(writer, this);
		}

		public void SerializeTo(XmlWriter writer)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Schema1));
			serializer.Serialize(writer, this);
		}
	}
}
