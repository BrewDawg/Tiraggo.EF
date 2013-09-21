//=======================================================
// Copyright © Mike Griffin 2013
//=======================================================

using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace TiraggoEdmx_v2
{
	public partial class Mapping
	{
		public static Mapping DeserializeFrom(Stream stream)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Mapping));
			return (Mapping)serializer.Deserialize(stream);
		}

		public static Mapping DeserializeFrom(TextReader reader)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Mapping));
			return (Mapping)serializer.Deserialize(reader);
		}

		public static Mapping DeserializeFrom(XmlReader reader)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Mapping));
			return (Mapping)serializer.Deserialize(reader);
		}

		public void SerializeTo(Stream stream)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Mapping));
			serializer.Serialize(stream, this);
		}

		public void SerializeTo(TextWriter writer)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Mapping));
			serializer.Serialize(writer, this);
		}

		public void SerializeTo(XmlWriter writer)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Mapping));
			serializer.Serialize(writer, this);
		}
	}
}
