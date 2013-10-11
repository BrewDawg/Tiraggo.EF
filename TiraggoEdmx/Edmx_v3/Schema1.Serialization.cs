//=======================================================
// Copyright © Mike Griffin 2013
//=======================================================

using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace TiraggoEdmx_v3
{
	public partial class tgConceptualSchema
	{
		public static tgConceptualSchema DeserializeFrom(Stream stream)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(tgConceptualSchema));
			return (tgConceptualSchema)serializer.Deserialize(stream);
		}

		public static tgConceptualSchema DeserializeFrom(TextReader reader)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(tgConceptualSchema));
			return (tgConceptualSchema)serializer.Deserialize(reader);
		}

		public static tgConceptualSchema DeserializeFrom(XmlReader reader)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(tgConceptualSchema));
			return (tgConceptualSchema)serializer.Deserialize(reader);
		}

		public void SerializeTo(Stream stream)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(tgConceptualSchema));
			serializer.Serialize(stream, this);
		}

		public void SerializeTo(TextWriter writer)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(tgConceptualSchema));
			serializer.Serialize(writer, this);
		}

		public void SerializeTo(XmlWriter writer)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(tgConceptualSchema));
			serializer.Serialize(writer, this);
		}
	}
}
