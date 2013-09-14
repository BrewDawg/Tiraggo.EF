using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiraggoEdmx_v3;

namespace TiraggoEdmx
{
    public partial class TiraggoEntityInfo_v3
    {
        private Edmx edmx;

        public TiraggoEntityInfo_v3(Edmx edm, string fullName)
        {
            edmx = edm;

            Mapping = edmx.Runtime.Mappings.Mapping.EntityContainerMapping.EntitySetMapping
                .Where(m => m.EntityTypeMapping.TypeName == fullName).Select(m => m).Single();

            string conceptualName = Mapping.EntityTypeMapping.TypeName.Replace(edm.Runtime.ConceptualModels.Schema.Namespace + ".", "");

            StorageInfo = edmx.Runtime.StorageModels.Schema.EntityContainer.EntitySet
                .Where(s => s.Name == Mapping.EntityTypeMapping.MappingFragment.StoreEntitySet).Single();

            ConceptualModel = edmx.Runtime.ConceptualModels.Schema.Items
                .Where(c => c is ConceptualModel).Select(c => c as ConceptualModel).ToList<ConceptualModel>()
                .Where(c => c.Name == conceptualName).Single();

            ColumnMappings = Mapping.EntityTypeMapping.MappingFragment.ScalarProperty.ToDictionary(p => p.Name, p => p.ColumnName);

            ColumnCLR = ConceptualModel.Property.ToDictionary(p => p.Name, p => p);

            SchemaEntityType sql = edm.Runtime.StorageModels.Schema.EntityType.Where(e => e.Name == Mapping.EntityTypeMapping.MappingFragment.StoreEntitySet).Single();

            ColumnSQL = sql.Property.ToDictionary(e => e.Name, e => e);

            PrimaryKeys = new Dictionary<string, string>();
            foreach (KeyColumn key in ConceptualModel.Key)
            {
                PrimaryKeys[key.Name] = key.Name;
            }
        }

        public ColumnMapping Mapping { get; internal set; }

        public StorageInfo StorageInfo { get; internal set; }

        public ConceptualModel ConceptualModel { get; internal set; }

        public bool IsInPrimaryKey(string property)
        {
            return PrimaryKeys.ContainsKey(property);
        }

        public Dictionary<string, string> ColumnMappings { get; internal set; }

        public Dictionary<string, ColumnCLR> ColumnCLR { get; internal set; }

        public Dictionary<string, ColumnSQL> ColumnSQL { get; internal set; }

        public Dictionary<string, string> PrimaryKeys { get; internal set; }
    }
}