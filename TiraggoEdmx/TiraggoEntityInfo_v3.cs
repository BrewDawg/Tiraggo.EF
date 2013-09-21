//=======================================================
// Copyright © Mike Griffin 2013
//=======================================================

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiraggoEdmx_v3;

namespace TiraggoEdmx_v3
{
    public partial class TiraggoEntityInfo
    {
        private Edmx edmx;

        public TiraggoEntityInfo(Edmx edm, string fullName)
        {
            edmx = edm;

            Mapping = edmx.Runtime.Mappings.Mapping.EntityContainerMapping.EntitySetMappings
                .Where(m => m.EntityTypeMapping.TypeName == fullName).Select(m => m).Single();

            string conceptualName = Mapping.EntityTypeMapping.TypeName.Replace(edm.Runtime.ConceptualModels.Schema.Namespace + ".", "");

            StorageInfo = edmx.Runtime.StorageModels.Schema.EntityContainer.EntitySets
                .Where(s => s.Name == Mapping.EntityTypeMapping.MappingFragment.StoreEntitySet).Single();

            ConceptualModel = edmx.Runtime.ConceptualModels.Schema.EntityTypes
                .Where(c => c is ConceptualEntityType).Select(c => c as ConceptualEntityType).ToList<ConceptualEntityType>()
                .Where(c => c.Name == conceptualName).Single();

            ColumnMappings = Mapping.EntityTypeMapping.MappingFragment.ScalarProperties.ToDictionary(p => p.Name, p => p.ColumnName);

            ColumnCLR = ConceptualModel.Properties.ToDictionary(p => p.Name, p => p);

            EntityType sql = edm.Runtime.StorageModels.Schema.EntityTypes.Where(e => e.Name == Mapping.EntityTypeMapping.MappingFragment.StoreEntitySet).Single();

            ColumnSQL = sql.Properties.ToDictionary(e => e.Name, e => e);

            PrimaryKeys = new Dictionary<string, string>();
            foreach (PropertyRef key in ConceptualModel.Key)
            {
                PrimaryKeys[key.Name] = key.Name;
            }
        }

        public EntitySetMapping Mapping { get; internal set; }

        public EntitySet StorageInfo { get; internal set; }

        public ConceptualEntityType ConceptualModel { get; internal set; }

        public bool IsInPrimaryKey(string property)
        {
            return PrimaryKeys.ContainsKey(property);
        }

        public Dictionary<string, string> ColumnMappings { get; internal set; }

        public Dictionary<string, ColumnCLR> ColumnCLR { get; internal set; }

        public Dictionary<string, Property> ColumnSQL { get; internal set; }

        public Dictionary<string, string> PrimaryKeys { get; internal set; }
    }
}