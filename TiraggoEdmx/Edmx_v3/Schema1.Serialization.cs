//=======================================================
// Copyright © Mike Griffin 2013
//=======================================================

using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace TiraggoEdmx_v3
{
	public partial class ConceptualSchema
	{
		public static ConceptualSchema DeserializeFrom(Stream stream)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(ConceptualSchema));
			return (ConceptualSchema)serializer.Deserialize(stream);
		}

		public static ConceptualSchema DeserializeFrom(TextReader reader)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(ConceptualSchema));
			return (ConceptualSchema)serializer.Deserialize(reader);
		}

		public static ConceptualSchema DeserializeFrom(XmlReader reader)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(ConceptualSchema));
			return (ConceptualSchema)serializer.Deserialize(reader);
		}

		public void SerializeTo(Stream stream)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(ConceptualSchema));
			serializer.Serialize(stream, this);
		}

		public void SerializeTo(TextWriter writer)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(ConceptualSchema));
			serializer.Serialize(writer, this);
		}

		public void SerializeTo(XmlWriter writer)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(ConceptualSchema));
			serializer.Serialize(writer, this);
		}
	}
}
