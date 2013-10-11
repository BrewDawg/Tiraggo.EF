//=======================================================
// Copyright © Mike Griffin 2013
//=======================================================

using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace TiraggoEdmx_v3
{
	public partial class tgMapping
	{
		public static tgMapping DeserializeFrom(Stream stream)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(tgMapping));
			return (tgMapping)serializer.Deserialize(stream);
		}

		public static tgMapping DeserializeFrom(TextReader reader)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(tgMapping));
			return (tgMapping)serializer.Deserialize(reader);
		}

		public static tgMapping DeserializeFrom(XmlReader reader)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(tgMapping));
			return (tgMapping)serializer.Deserialize(reader);
		}

		public void SerializeTo(Stream stream)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(tgMapping));
			serializer.Serialize(stream, this);
		}

		public void SerializeTo(TextWriter writer)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(tgMapping));
			serializer.Serialize(writer, this);
		}

		public void SerializeTo(XmlWriter writer)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(tgMapping));
			serializer.Serialize(writer, this);
		}
	}
}
