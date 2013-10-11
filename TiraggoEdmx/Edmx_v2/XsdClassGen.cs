//=======================================================
// Copyright © Mike Griffin 2013
//=======================================================

using System;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

namespace TiraggoEdmx_v2
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx", IsNullable = false)]
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
        private tgRuntime runtimeField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgDesigner designerField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal versionField;

        /// <remarks/>
        public tgRuntime Runtime
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
        public tgDesigner Designer
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class tgRuntime
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgStorageModels storageModelsField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgConceptualModel conceptualModelsField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgMappings mappingsField;

        /// <remarks/>
        public tgStorageModels StorageModels
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
        public tgConceptualModel ConceptualModels
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
        public tgMappings Mappings
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class tgStorageModels
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgSchema schemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
        public tgSchema Schema
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class tgSchema
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgEntityContainer entityContainerField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgEntityType[] entityTypeField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgAssociation[] associationField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgFunction[] functionField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string namespaceField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string aliasField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string providerField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort providerManifestTokenField;

        /// <remarks/>
        public tgEntityContainer EntityContainer
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
        public tgEntityType[] EntityTypes
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
        public tgAssociation[] Associations
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
        public tgFunction[] Functions
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class tgEntityContainer
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgEntitySet[] entitySetField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgAssociationSet[] associationSetField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntitySet")]
        public tgEntitySet[] EntitySets
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
        public tgAssociationSet[] AssociationSets
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class tgEntitySet
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class tgAssociationSet
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgEnd[] endField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string associationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("End")]
        public tgEnd[] Ends
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class tgEnd
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class tgEntityType
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgPropertyRef[] keyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgProperty[] propertyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PropertyRef", IsNullable = false)]
        public tgPropertyRef[] Key
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
        public tgProperty[] Properties
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class tgKey
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class tgAssociation
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgSchemaAssociationEnd[] endField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgReferentialConstraint referentialConstraintField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("End")]
        public tgSchemaAssociationEnd[] Ends
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
        public tgReferentialConstraint ReferentialConstraint
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class tgSchemaAssociationEnd
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class tgReferentialConstraint
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgPrincipal principalField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgDependent dependentField;

        /// <remarks/>
        public tgPrincipal Principal
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
        public tgDependent Dependent
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class tgPrincipal
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgPropertyRef propertyRefField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string roleField;

        /// <remarks/>
        public tgPropertyRef PropertyRef
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class tgPropertyRef
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class tgDependent
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgPropertyRef propertyRefField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string roleField;

        /// <remarks/>
        public tgPropertyRef PropertyRef
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class tgFunction
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgParameter[] parameterField;

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
        public tgParameter[] Parameters
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class tgParameter
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class tgConceptualModel
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgConceptualSchema schemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
        public tgConceptualSchema Schema
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class tgConceptualSchema
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgConceptualEntityContainer entityContainerField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgConceptualEntityType[] entityTypeField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgAssociation[] associationField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string namespaceField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string aliasField;

        /// <remarks/>
        public tgConceptualEntityContainer EntityContainer
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
        public tgConceptualEntityType[] EntityTypes
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
        public tgAssociation[] Associations
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class tgConceptualEntityContainer
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgConceptualEntitySet[] entitySetField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgConcepturalAssociationSet[] associationSetField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool lazyLoadingEnabledField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntitySet")]
        public tgConceptualEntitySet[] EntitySets
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
        public tgConcepturalAssociationSet[] AssociationSets
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class tgConceptualEntitySet
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class tgConcepturalAssociationSet
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgConceptualAssociationSetEnd[] endField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string associationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("End")]
        public tgConceptualAssociationSetEnd[] Ends
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class tgConceptualAssociationSetEnd
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class tgConceptualEntityType
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgPropertyRef[] keyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgProperty[] propertyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgNavigationProperty[] navigationPropertyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PropertyRef", IsNullable = false)]
        public tgPropertyRef[] Key
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
        public tgProperty[] Properties
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
        public tgNavigationProperty[] NavigationPropertys
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class tgProperty
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class tgNavigationProperty
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class tgMappings
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgMapping mappingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
        public tgMapping Mapping
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class tgMapping
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgEntityContainerMapping entityContainerMappingField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string spaceField;

        /// <remarks/>
        public tgEntityContainerMapping EntityContainerMapping
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class tgEntityContainerMapping
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgEntitySetMapping[] entitySetMappingField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgAssociationSetMapping[] associationSetMappingField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string storageEntityContainerField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string cdmEntityContainerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntitySetMapping")]
        public tgEntitySetMapping[] EntitySetMappings
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
        public tgAssociationSetMapping[] AssociationSetMappings
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class tgEntitySetMapping
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgEntityTypeMapping entityTypeMappingField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        /// <remarks/>
        public tgEntityTypeMapping EntityTypeMapping
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class tgEntityTypeMapping
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgMappingFragment mappingFragmentField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string typeNameField;

        /// <remarks/>
        public tgMappingFragment MappingFragment
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class tgMappingFragment
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgScalarProperty[] scalarPropertyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string storeEntitySetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScalarProperty")]
        public tgScalarProperty[] ScalarProperties
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class tgScalarProperty
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class tgAssociationSetMapping
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgEndProperty[] endPropertyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string typeNameField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string storeEntitySetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EndProperty")]
        public tgEndProperty[] EndProperties
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class tgEndProperty
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgScalarProperty scalarPropertyField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        /// <remarks/>
        public tgScalarProperty ScalarProperty
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class tgDesigner
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgDesignerConnection connectionField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgDesignerOptions optionsField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgDesignerDiagrams diagramsField;

        /// <remarks/>
        public tgDesignerConnection Connection
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
        public tgDesignerOptions Options
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
        public tgDesignerDiagrams Diagrams
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class tgDesignerConnection
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgDesignerInfoPropertySet designerInfoPropertySetField;

        /// <remarks/>
        public tgDesignerInfoPropertySet DesignerInfoPropertySet
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class tgDesignerInfoPropertySet
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgDesignerProperty designerPropertyField;

        /// <remarks/>
        public tgDesignerProperty DesignerProperty
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class tgDesignerProperty
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class tgDesignerOptions
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgDesignerOptionProperty[] designerInfoPropertySetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DesignerProperty", IsNullable = false)]
        public tgDesignerOptionProperty[] DesignerInfoPropertySets
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class tgDesignerOptionProperty
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class tgDesignerDiagrams
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgDesignerDiagram diagramField;

        /// <remarks/>
        public tgDesignerDiagram Diagram
        {
            get
            {
                return this.diagramField;
            }
            set
            {
                this.diagramField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class tgDesignerDiagram
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgDesignerDiagramShape[] entityTypeShapeField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgDesignerDiagramAssociationConnector[] associationConnectorField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntityTypeShape")]
        public tgDesignerDiagramShape[] EntityTypeShapes
        {
            get
            {
                return this.entityTypeShapeField;
            }
            set
            {
                this.entityTypeShapeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssociationConnector")]
        public tgDesignerDiagramAssociationConnector[] AssociationConnectors
        {
            get
            {
                return this.associationConnectorField;
            }
            set
            {
                this.associationConnectorField = value;
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


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class tgDesignerDiagramShape
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string entityTypeField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal widthField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal pointXField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal pointYField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal heightField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool isExpandedField;

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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PointX
        {
            get
            {
                return this.pointXField;
            }
            set
            {
                this.pointXField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PointY
        {
            get
            {
                return this.pointYField;
            }
            set
            {
                this.pointYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsExpanded
        {
            get
            {
                return this.isExpandedField;
            }
            set
            {
                this.isExpandedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class tgDesignerDiagramAssociationConnector
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private tgDesignerDiagramAssociationConnectorPoint[] connectorPointField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string associationField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool manuallyRoutedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConnectorPoint")]
        public tgDesignerDiagramAssociationConnectorPoint[] ConnectorPoints
        {
            get
            {
                return this.connectorPointField;
            }
            set
            {
                this.connectorPointField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ManuallyRouted
        {
            get
            {
                return this.manuallyRoutedField;
            }
            set
            {
                this.manuallyRoutedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18060")]


    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class tgDesignerDiagramAssociationConnectorPoint
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal pointXField;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal pointYField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PointX
        {
            get
            {
                return this.pointXField;
            }
            set
            {
                this.pointXField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PointY
        {
            get
            {
                return this.pointYField;
            }
            set
            {
                this.pointYField = value;
            }
        }
    }
}

