using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tiraggo.DynamicQuery
{
    public class tgMetadata
    {
        public tgTypeMap GetTypeMap(string columnName)
        {
            if (Types.ContainsKey(columnName))
                return Types[columnName];
            else
                return null;
        }

        public Guid DataID = Guid.NewGuid();
        public tgColumnMetadataCollection Columns = new tgColumnMetadataCollection();
        public Dictionary<string, tgTypeMap> Types = new Dictionary<string, tgTypeMap>();
        public string Source;
        public string Destination;
        public string Schema;
        public string Catalog;
    }
}
