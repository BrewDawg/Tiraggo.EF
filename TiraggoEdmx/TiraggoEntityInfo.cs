using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiraggoEdmx;

namespace TiraggoEdmx
{
    public class TiraggoEntityInfo
    {
        private Edmx edmx;

        public TiraggoEntityInfo(Edmx edm, string fullName)
        {
            edmx = edm;

            Mapping = edmx.Runtime.Mappings.Mapping.EntityContainerMapping.EntitySetMapping
                .Where(m => m.EntityTypeMapping.TypeName == fullName).Select(m => m).Single();

            string conceptualName = Mapping.EntityTypeMapping.TypeName.Replace(edm.Runtime.ConceptualModels.Schema.Namespace + ".", "");

            StorageInfo = edmx.Runtime.StorageModels.Schema.EntityContainer.EntitySet
                .Where(s => s.Name == Mapping.EntityTypeMapping.MappingFragment.StoreEntitySet).Single();

            ConceptualModel = edmx.Runtime.ConceptualModels.Schema.Items
                .Where(c => c is SchemaEntityType2).Select(c => c as SchemaEntityType2).ToList<SchemaEntityType2>()
                .Where(c => c.Name == conceptualName).Single();

            ColumnMappings = Mapping.EntityTypeMapping.MappingFragment.ScalarProperty.ToDictionary(p => p.Name, p => p.ColumnName);

            ColumnCLRMetadata = ConceptualModel.Property.ToDictionary(p => p.Name, p => p);

            SchemaEntityType sql = edm.Runtime.StorageModels.Schema.EntityType.Where(e => e.Name == Mapping.EntityTypeMapping.MappingFragment.StoreEntitySet).Single();

            ColumnSQLMetadata = sql.Property.ToDictionary(e => e.Name, e => e);
        }

        public MappingEntityContainerMappingEntitySetMapping Mapping { get; set; }

        public SchemaEntityContainerEntitySet StorageInfo { get; set; }

        public SchemaEntityType2 ConceptualModel { get; set; }

        public Dictionary<string, string> ColumnMappings { get; set; }

        public Dictionary<string, SchemaEntityTypeProperty1> ColumnCLRMetadata { get; set; }

        public Dictionary<string, SchemaEntityTypeProperty> ColumnSQLMetadata { get; set; }
    }
}