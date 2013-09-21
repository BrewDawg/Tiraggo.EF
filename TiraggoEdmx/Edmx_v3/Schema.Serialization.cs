//=======================================================
// Copyright © Mike Griffin 2013
//=======================================================

using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace TiraggoEdmx_v3
{
	public partial class Schema
	{
		public static Schema DeserializeFrom(Stream stream)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Schema));
			return (Schema)serializer.Deserialize(stream);
		}

		public static Schema DeserializeFrom(TextReader reader)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Schema));
			return (Schema)serializer.Deserialize(reader);
		}

		public static Schema DeserializeFrom(XmlReader reader)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Schema));
			return (Schema)serializer.Deserialize(reader);
		}

		public void SerializeTo(Stream stream)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Schema));
			serializer.Serialize(stream, this);
		}

		public void SerializeTo(TextWriter writer)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Schema));
			serializer.Serialize(writer, this);
		}

		public void SerializeTo(XmlWriter writer)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Schema));
			serializer.Serialize(writer, this);
		}
	}
}
