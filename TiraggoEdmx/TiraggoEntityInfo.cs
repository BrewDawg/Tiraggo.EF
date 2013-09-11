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
                .Where(c => c is ConceptualModel).Select(c => c as ConceptualModel).ToList<ConceptualModel>()
                .Where(c => c.Name == conceptualName).Single();

            ColumnMappings = Mapping.EntityTypeMapping.MappingFragment.ScalarProperty.ToDictionary(p => p.Name, p => p.ColumnName);

            ColumnCLR = ConceptualModel.Property.ToDictionary(p => p.Name, p => p);

            SchemaEntityType sql = edm.Runtime.StorageModels.Schema.EntityType.Where(e => e.Name == Mapping.EntityTypeMapping.MappingFragment.StoreEntitySet).Single();

            ColumnSQL = sql.Property.ToDictionary(e => e.Name, e => e);
        }

        public ColumnMapping Mapping { get; set; }

        public StorageInfo StorageInfo { get; set; }

        public ConceptualModel ConceptualModel { get; set; }

        public Dictionary<string, string> ColumnMappings { get; set; }

        public Dictionary<string, ColumnCLR> ColumnCLR { get; set; }

        public Dictionary<string, ColumnSQL> ColumnSQL { get; set; }
    }
}