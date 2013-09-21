//=======================================================
// Copyright © Mike Griffin 2013
//=======================================================

using System;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

namespace TiraggoEdmx_v3
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edmx")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2009/11/edmx", IsNullable = false)]
    public partial class Edmx
    {
        static public Edmx Load(string fullPathToEdmx)
        {
            Edmx edm = null;

            using (TextReader rdr = new StreamReader(fullPathToEdmx))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Edmx));
                edm = (Edmx)serializer.Deserialize(rdr);
                rdr.Close();
            }

            return edm;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Runtime runtimeField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Designer designerField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal versionField;

        /// <remarks/>
        public Runtime Runtime
        {
            get
            {
                return this.runtimeField;
            }
            set
            {
                this.runtimeField = value;
            }
        }

        /// <remarks/>
        public Designer Designer
        {
            get
            {
                return this.designerField;
            }
            set
            {
                this.designerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edmx")]
    public partial class Runtime
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private StorageModels storageModelsField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ConceptualModel conceptualModelsField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Mappings mappingsField;

        /// <remarks/>
        public StorageModels StorageModels
        {
            get
            {
                return this.storageModelsField;
            }
            set
            {
                this.storageModelsField = value;
            }
        }

        /// <remarks/>
        public ConceptualModel ConceptualModels
        {
            get
            {
                return this.conceptualModelsField;
            }
            set
            {
                this.conceptualModelsField = value;
            }
        }

        /// <remarks/>
        public Mappings Mappings
        {
            get
            {
                return this.mappingsField;
            }
            set
            {
                this.mappingsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edmx")]
    public partial class StorageModels
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Schema schemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2009/11/edm/ssdl")]
        public Schema Schema
        {
            get
            {
                return this.schemaField;
            }
            set
            {
                this.schemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm/ssdl")]
    public partial class Schema
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private EntityContainer entityContainerField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private EntityType[] entityTypeField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Association[] associationField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Function[] functionField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string namespaceField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string aliasField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string providerField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort providerManifestTokenField;

        /// <remarks/>
        public EntityContainer EntityContainer
        {
            get
            {
                return this.entityContainerField;
            }
            set
            {
                this.entityContainerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntityType")]
        public EntityType[] EntityTypes
        {
            get
            {
                return this.entityTypeField;
            }
            set
            {
                this.entityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Association")]
        public Association[] Associations
        {
            get
            {
                return this.associationField;
            }
            set
            {
                this.associationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function")]
        public Function[] Functions
        {
            get
            {
                return this.functionField;
            }
            set
            {
                this.functionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Namespace
        {
            get
            {
                return this.namespaceField;
            }
            set
            {
                this.namespaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Provider
        {
            get
            {
                return this.providerField;
            }
            set
            {
                this.providerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ProviderManifestToken
        {
            get
            {
                return this.providerManifestTokenField;
            }
            set
            {
                this.providerManifestTokenField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm/ssdl")]
    public partial class EntityContainer
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private EntitySet[] entitySetField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AssociationSet[] associationSetField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntitySet")]
        public EntitySet[] EntitySets
        {
            get
            {
                return this.entitySetField;
            }
            set
            {
                this.entitySetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssociationSet")]
        public AssociationSet[] AssociationSets
        {
            get
            {
                return this.associationSetField;
            }
            set
            {
                this.associationSetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm/ssdl")]
    public partial class EntitySet
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string definingQueryField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string entityTypeField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string typeField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string schemaField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string schema1Field;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string name1Field;

        /// <remarks/>
        public string DefiningQuery
        {
            get
            {
                return this.definingQueryField;
            }
            set
            {
                this.definingQueryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EntityType
        {
            get
            {
                return this.entityTypeField;
            }
            set
            {
                this.entityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/12/edm/EntityStoreSchemaGenerator")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Schema
        {
            get
            {
                return this.schemaField;
            }
            set
            {
                this.schemaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("Schema", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/12/edm/EntityStoreSchemaGenerator")]
        public string Schema1
        {
            get
            {
                return this.schema1Field;
            }
            set
            {
                this.schema1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("Name", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/12/edm/EntityStoreSchemaGenerator")]
        public string Name1
        {
            get
            {
                return this.name1Field;
            }
            set
            {
                this.name1Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm/ssdl")]
    public partial class AssociationSet
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private End[] endField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string associationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("End")]
        public End[] Ends
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Association
        {
            get
            {
                return this.associationField;
            }
            set
            {
                this.associationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm/ssdl")]
    public partial class End
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string roleField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string entitySetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EntitySet
        {
            get
            {
                return this.entitySetField;
            }
            set
            {
                this.entitySetField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm/ssdl")]
    public partial class EntityType
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PropertyRef[] keyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Property[] propertyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PropertyRef", IsNullable = false)]
        public PropertyRef[] Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public Property[] Properties
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm/ssdl")]
    public partial class Key
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm/ssdl")]
    public partial class Property
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string typeField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool nullableField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool nullableFieldSpecified;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string storeGeneratedPatternField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string maxLengthField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool maxLengthFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                if (this.typeField == "Binary")
                {
                    this.typeField = "int";

                    try
                    {
                        if (!String.IsNullOrWhiteSpace(this.MaxLength) && ulong.Parse(this.MaxLength) > 1)
                        {
                            this.typeField += "[]";
                        }
                    }
                    catch
                    {
                        return "FAILED";
                    }
                }

                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Nullable
        {
            get
            {
                return this.nullableField;
            }
            set
            {
                this.nullableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NullableSpecified
        {
            get
            {
                return this.nullableFieldSpecified;
            }
            set
            {
                this.nullableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StoreGeneratedPattern
        {
            get
            {
                return this.storeGeneratedPatternField;
            }
            set
            {
                this.storeGeneratedPatternField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MaxLength
        {
            get
            {
                if (!String.IsNullOrWhiteSpace(this.maxLengthField) && this.maxLengthField.ToLower() == "max")
                {
                    return "2147483647";
                }

                return this.maxLengthField;
            }
            set
            {
                this.maxLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxLengthSpecified
        {
            get
            {
                return this.maxLengthFieldSpecified;
            }
            set
            {
                this.maxLengthFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm/ssdl")]
    public partial class Association
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SchemaAssociationEnd[] endField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ReferentialConstraint referentialConstraintField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("End")]
        public SchemaAssociationEnd[] Ends
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        public ReferentialConstraint ReferentialConstraint
        {
            get
            {
                return this.referentialConstraintField;
            }
            set
            {
                this.referentialConstraintField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm/ssdl")]
    public partial class SchemaAssociationEnd
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string roleField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string typeField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string multiplicityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Multiplicity
        {
            get
            {
                return this.multiplicityField;
            }
            set
            {
                this.multiplicityField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm/ssdl")]
    public partial class ReferentialConstraint
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Principal principalField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dependent dependentField;

        /// <remarks/>
        public Principal Principal
        {
            get
            {
                return this.principalField;
            }
            set
            {
                this.principalField = value;
            }
        }

        /// <remarks/>
        public Dependent Dependent
        {
            get
            {
                return this.dependentField;
            }
            set
            {
                this.dependentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm/ssdl")]
    public partial class Principal
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PropertyRef propertyRefField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string roleField;

        /// <remarks/>
        public PropertyRef PropertyRef
        {
            get
            {
                return this.propertyRefField;
            }
            set
            {
                this.propertyRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm/ssdl")]
    public partial class PropertyRef
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm/ssdl")]
    public partial class Dependent
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PropertyRef propertyRefField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string roleField;

        /// <remarks/>
        public PropertyRef PropertyRef
        {
            get
            {
                return this.propertyRefField;
            }
            set
            {
                this.propertyRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm/ssdl")]
    public partial class Function
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Parameter[] parameterField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool aggregateField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool builtInField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool niladicFunctionField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool isComposableField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string parameterTypeSemanticsField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string schemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public Parameter[] Parameters
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Aggregate
        {
            get
            {
                return this.aggregateField;
            }
            set
            {
                this.aggregateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool BuiltIn
        {
            get
            {
                return this.builtInField;
            }
            set
            {
                this.builtInField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NiladicFunction
        {
            get
            {
                return this.niladicFunctionField;
            }
            set
            {
                this.niladicFunctionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsComposable
        {
            get
            {
                return this.isComposableField;
            }
            set
            {
                this.isComposableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParameterTypeSemantics
        {
            get
            {
                return this.parameterTypeSemanticsField;
            }
            set
            {
                this.parameterTypeSemanticsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Schema
        {
            get
            {
                return this.schemaField;
            }
            set
            {
                this.schemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm/ssdl")]
    public partial class Parameter
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string typeField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string modeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edmx")]
    public partial class ConceptualModel
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ConceptualSchema schemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2009/11/edm")]
        public ConceptualSchema Schema
        {
            get
            {
                return this.schemaField;
            }
            set
            {
                this.schemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm")]
    public partial class ConceptualSchema
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ConceptualEntityContainer entityContainerField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ConceptualEntityType[] entityTypeField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Association[] associationField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SchemaComplexType[] complexTypeField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string namespaceField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string aliasField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool useStrongSpatialTypesField;

        /// <remarks/>
        public ConceptualEntityContainer EntityContainer
        {
            get
            {
                return this.entityContainerField;
            }
            set
            {
                this.entityContainerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntityType")]
        public ConceptualEntityType[] EntityTypes
        {
            get
            {
                return this.entityTypeField;
            }
            set
            {
                this.entityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Association")]
        public Association[] Associations
        {
            get
            {
                return this.associationField;
            }
            set
            {
                this.associationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ComplexType")]
        public SchemaComplexType[] ComplexTypes
        {
            get
            {
                return this.complexTypeField;
            }
            set
            {
                this.complexTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Namespace
        {
            get
            {
                return this.namespaceField;
            }
            set
            {
                this.namespaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/annotation")]
        public bool UseStrongSpatialTypes
        {
            get
            {
                return this.useStrongSpatialTypesField;
            }
            set
            {
                this.useStrongSpatialTypesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm")]
    public partial class ConceptualEntityContainer
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ConceptualEntitySet[] entitySetField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ConcepturalAssociationSet[] associationSetField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FunctionImport[] functionImportField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool lazyLoadingEnabledField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntitySet")]
        public ConceptualEntitySet[] EntitySets
        {
            get
            {
                return this.entitySetField;
            }
            set
            {
                this.entitySetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssociationSet")]
        public ConcepturalAssociationSet[] AssociationSets
        {
            get
            {
                return this.associationSetField;
            }
            set
            {
                this.associationSetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FunctionImport")]
        public FunctionImport[] FunctionImports
        {
            get
            {
                return this.functionImportField;
            }
            set
            {
                this.functionImportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/annotation")]
        public bool LazyLoadingEnabled
        {
            get
            {
                return this.lazyLoadingEnabledField;
            }
            set
            {
                this.lazyLoadingEnabledField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm")]
    public partial class ConceptualEntitySet
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string entityTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EntityType
        {
            get
            {
                return this.entityTypeField;
            }
            set
            {
                this.entityTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm")]
    public partial class ConcepturalAssociationSet
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ConceptualAssociationSetEnd[] endField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string associationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("End")]
        public ConceptualAssociationSetEnd[] Ends
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Association
        {
            get
            {
                return this.associationField;
            }
            set
            {
                this.associationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm")]
    public partial class ConceptualAssociationSetEnd
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string roleField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string entitySetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EntitySet
        {
            get
            {
                return this.entitySetField;
            }
            set
            {
                this.entitySetField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm")]
    public partial class FunctionImport
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Parameter[] parameterField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string returnTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public Parameter[] Parameters
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReturnType
        {
            get
            {
                return this.returnTypeField;
            }
            set
            {
                this.returnTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm")]
    public partial class ConceptualEntityType
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PropertyRef[] keyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ColumnCLR[] propertyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private NavigationProperty[] navigationPropertyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PropertyRef", IsNullable = false)]
        public PropertyRef[] Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public ColumnCLR[] Properties
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NavigationProperty")]
        public NavigationProperty[] NavigationProperties
        {
            get
            {
                return this.navigationPropertyField;
            }
            set
            {
                this.navigationPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm")]
    public partial class ColumnCLR
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string typeField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool nullableField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool nullableFieldSpecified;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string storeGeneratedPatternField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string maxLengthField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool unicodeField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool unicodeFieldSpecified;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool fixedLengthField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool fixedLengthFieldSpecified;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int precisionField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool precisionFieldSpecified;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int scaleField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool scaleFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                if (this.typeField == "Binary")
                {
                    this.typeField = "int";

                    try
                    {
                        if (!String.IsNullOrWhiteSpace(this.MaxLength) && ulong.Parse(this.MaxLength) > 1)
                        {
                            this.typeField += "[]";
                        }
                    }
                    catch
                    {
                        return "FAILED";
                    }
                }

                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Nullable
        {
            get
            {
                return this.nullableField;
            }
            set
            {
                this.nullableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NullableSpecified
        {
            get
            {
                return this.nullableFieldSpecified;
            }
            set
            {
                this.nullableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/annotation")]
        public string StoreGeneratedPattern
        {
            get
            {
                return this.storeGeneratedPatternField;
            }
            set
            {
                this.storeGeneratedPatternField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MaxLength
        {
            get
            {
                if (!String.IsNullOrWhiteSpace(this.maxLengthField) && this.maxLengthField.ToLower() == "max")
                {
                    return "2147483647";
                }

                return this.maxLengthField;
            }
            set
            {
                this.maxLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Unicode
        {
            get
            {
                return this.unicodeField;
            }
            set
            {
                this.unicodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnicodeSpecified
        {
            get
            {
                return this.unicodeFieldSpecified;
            }
            set
            {
                this.unicodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FixedLength
        {
            get
            {
                return this.fixedLengthField;
            }
            set
            {
                this.fixedLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FixedLengthSpecified
        {
            get
            {
                return this.fixedLengthFieldSpecified;
            }
            set
            {
                this.fixedLengthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Precision
        {
            get
            {
                return this.precisionField;
            }
            set
            {
                this.precisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrecisionSpecified
        {
            get
            {
                return this.precisionFieldSpecified;
            }
            set
            {
                this.precisionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Scale
        {
            get
            {
                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScaleSpecified
        {
            get
            {
                return this.scaleFieldSpecified;
            }
            set
            {
                this.scaleFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm")]
    public partial class NavigationProperty
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string relationshipField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string fromRoleField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string toRoleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Relationship
        {
            get
            {
                return this.relationshipField;
            }
            set
            {
                this.relationshipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FromRole
        {
            get
            {
                return this.fromRoleField;
            }
            set
            {
                this.fromRoleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ToRole
        {
            get
            {
                return this.toRoleField;
            }
            set
            {
                this.toRoleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edm")]
    public partial class SchemaComplexType
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Property[] propertyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public Property[] Properties
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edmx")]
    public partial class Mappings
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Mapping mappingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2009/11/mapping/cs")]
        public Mapping Mapping
        {
            get
            {
                return this.mappingField;
            }
            set
            {
                this.mappingField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/mapping/cs")]
    public partial class Mapping
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private EntityContainerMapping entityContainerMappingField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string spaceField;

        /// <remarks/>
        public EntityContainerMapping EntityContainerMapping
        {
            get
            {
                return this.entityContainerMappingField;
            }
            set
            {
                this.entityContainerMappingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Space
        {
            get
            {
                return this.spaceField;
            }
            set
            {
                this.spaceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/mapping/cs")]
    public partial class EntityContainerMapping
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private EntitySetMapping[] entitySetMappingField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AssociationSetMapping[] associationSetMappingField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FunctionImportMapping[] functionImportMappingField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string storageEntityContainerField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string cdmEntityContainerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntitySetMapping")]
        public EntitySetMapping[] EntitySetMappings
        {
            get
            {
                return this.entitySetMappingField;
            }
            set
            {
                this.entitySetMappingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssociationSetMapping")]
        public AssociationSetMapping[] AssociationSetMappings
        {
            get
            {
                return this.associationSetMappingField;
            }
            set
            {
                this.associationSetMappingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FunctionImportMapping")]
        public FunctionImportMapping[] FunctionImportMappings
        {
            get
            {
                return this.functionImportMappingField;
            }
            set
            {
                this.functionImportMappingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StorageEntityContainer
        {
            get
            {
                return this.storageEntityContainerField;
            }
            set
            {
                this.storageEntityContainerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CdmEntityContainer
        {
            get
            {
                return this.cdmEntityContainerField;
            }
            set
            {
                this.cdmEntityContainerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/mapping/cs")]
    public partial class EntitySetMapping
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private EntityTypeMapping entityTypeMappingField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        /// <remarks/>
        public EntityTypeMapping EntityTypeMapping
        {
            get
            {
                return this.entityTypeMappingField;
            }
            set
            {
                this.entityTypeMappingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/mapping/cs")]
    public partial class EntityTypeMapping
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MappingFragment mappingFragmentField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string typeNameField;

        /// <remarks/>
        public MappingFragment MappingFragment
        {
            get
            {
                return this.mappingFragmentField;
            }
            set
            {
                this.mappingFragmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TypeName
        {
            get
            {
                return this.typeNameField;
            }
            set
            {
                this.typeNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/mapping/cs")]
    public partial class MappingFragment
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ScalarProperty[] scalarPropertyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string storeEntitySetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScalarProperty")]
        public ScalarProperty[] ScalarProperties
        {
            get
            {
                return this.scalarPropertyField;
            }
            set
            {
                this.scalarPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StoreEntitySet
        {
            get
            {
                return this.storeEntitySetField;
            }
            set
            {
                this.storeEntitySetField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/mapping/cs")]
    public partial class ScalarProperty
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string columnNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ColumnName
        {
            get
            {
                return this.columnNameField;
            }
            set
            {
                this.columnNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/mapping/cs")]
    public partial class AssociationSetMapping
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private EndProperty[] endPropertyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string typeNameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string storeEntitySetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EndProperty")]
        public EndProperty[] EndProperties
        {
            get
            {
                return this.endPropertyField;
            }
            set
            {
                this.endPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TypeName
        {
            get
            {
                return this.typeNameField;
            }
            set
            {
                this.typeNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StoreEntitySet
        {
            get
            {
                return this.storeEntitySetField;
            }
            set
            {
                this.storeEntitySetField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/mapping/cs")]
    public partial class EndProperty
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ScalarProperty scalarPropertyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        /// <remarks/>
        public ScalarProperty ScalarProperty
        {
            get
            {
                return this.scalarPropertyField;
            }
            set
            {
                this.scalarPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/mapping/cs")]
    public partial class FunctionImportMapping
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ResultMapping resultMappingField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string functionImportNameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string functionNameField;

        /// <remarks/>
        public ResultMapping ResultMapping
        {
            get
            {
                return this.resultMappingField;
            }
            set
            {
                this.resultMappingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FunctionImportName
        {
            get
            {
                return this.functionImportNameField;
            }
            set
            {
                this.functionImportNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FunctionName
        {
            get
            {
                return this.functionNameField;
            }
            set
            {
                this.functionNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/mapping/cs")]
    public partial class ResultMapping
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComplexTypeMapping complexTypeMappingField;

        /// <remarks/>
        public ComplexTypeMapping ComplexTypeMapping
        {
            get
            {
                return this.complexTypeMappingField;
            }
            set
            {
                this.complexTypeMappingField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/mapping/cs")]
    public partial class ComplexTypeMapping
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ScalarProperty[] scalarPropertyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string typeNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScalarProperty")]
        public ScalarProperty[] ScalarProperties
        {
            get
            {
                return this.scalarPropertyField;
            }
            set
            {
                this.scalarPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TypeName
        {
            get
            {
                return this.typeNameField;
            }
            set
            {
                this.typeNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edmx")]
    public partial class Designer
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DesignerConnection connectionField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DesignerOptions optionsField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private object diagramsField;

        /// <remarks/>
        public DesignerConnection Connection
        {
            get
            {
                return this.connectionField;
            }
            set
            {
                this.connectionField = value;
            }
        }

        /// <remarks/>
        public DesignerOptions Options
        {
            get
            {
                return this.optionsField;
            }
            set
            {
                this.optionsField = value;
            }
        }

        /// <remarks/>
        public object Diagrams
        {
            get
            {
                return this.diagramsField;
            }
            set
            {
                this.diagramsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edmx")]
    public partial class DesignerConnection
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DesignerInfoPropertySet designerInfoPropertySetField;

        /// <remarks/>
        public DesignerInfoPropertySet DesignerInfoPropertySet
        {
            get
            {
                return this.designerInfoPropertySetField;
            }
            set
            {
                this.designerInfoPropertySetField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edmx")]
    public partial class DesignerInfoPropertySet
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DesignerProperty designerPropertyField;

        /// <remarks/>
        public DesignerProperty DesignerProperty
        {
            get
            {
                return this.designerPropertyField;
            }
            set
            {
                this.designerPropertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edmx")]
    public partial class DesignerProperty
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/11/edmx")]
    public partial class DesignerOptions
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Property[] designerInfoPropertySetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DesignerProperty", IsNullable = false)]
        public Property[] Properties
        {
            get
            {
                return this.designerInfoPropertySetField;
            }
            set
            {
                this.designerInfoPropertySetField = value;
            }
        }
    }
}

