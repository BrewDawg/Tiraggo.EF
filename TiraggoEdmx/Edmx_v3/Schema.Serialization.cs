//=======================================================
// Copyright © Mike Griffin 2013
//=======================================================

using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace TiraggoEdmx_v3
{
	public partial class tgSchema
	{
		public static tgSchema DeserializeFrom(Stream stream)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(tgSchema));
			return (tgSchema)serializer.Deserialize(stream);
		}

		public static tgSchema DeserializeFrom(TextReader reader)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(tgSchema));
			return (tgSchema)serializer.Deserialize(reader);
		}

		public static tgSchema DeserializeFrom(XmlReader reader)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(tgSchema));
			return (tgSchema)serializer.Deserialize(reader);
		}

		public void SerializeTo(Stream stream)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(tgSchema));
			serializer.Serialize(stream, this);
		}

		public void SerializeTo(TextWriter writer)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(tgSchema));
			serializer.Serialize(writer, this);
		}

		public void SerializeTo(XmlWriter writer)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(tgSchema));
			serializer.Serialize(writer, this);
		}
	}
}
