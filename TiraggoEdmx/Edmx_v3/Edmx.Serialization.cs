//=======================================================
// Copyright © Mike Griffin 2013
//=======================================================

using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace TiraggoEdmx_v3
{
	public partial class Edmx
	{
		public static Edmx DeserializeFrom(Stream stream)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Edmx));
			return (Edmx)serializer.Deserialize(stream);
		}

		public static Edmx DeserializeFrom(TextReader reader)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Edmx));
			return (Edmx)serializer.Deserialize(reader);
		}

		public static Edmx DeserializeFrom(XmlReader reader)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Edmx));
			return (Edmx)serializer.Deserialize(reader);
		}

		public void SerializeTo(Stream stream)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Edmx));
			serializer.Serialize(stream, this);
		}

		public void SerializeTo(TextWriter writer)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Edmx));
			serializer.Serialize(writer, this);
		}

		public void SerializeTo(XmlWriter writer)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Edmx));
			serializer.Serialize(writer, this);
		}
	}
}
