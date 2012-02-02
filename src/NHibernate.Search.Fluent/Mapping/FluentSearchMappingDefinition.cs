using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NHibernate.Search.Engine;
using NHibernate.Search.Fluent.Mapping.Definitions;
using NHibernate.Search.Mapping;
using NHibernate.Search.Mapping.Definition;

namespace NHibernate.Search.Fluent.Mapping
{
	using Type = System.Type;

	public class FluentSearchMappingDefinition : ISearchMappingDefinition
	{
		private readonly IDocumentMap documentMap;

		public FluentSearchMappingDefinition(IDocumentMap documentMap)
		{
			this.documentMap = documentMap;
		}

		public IIndexedDefinition Indexed(Type type)
		{
			return new IndexedDefinition{Index = documentMap.Name};
		}

		public IList<FilterDef> FullTextFilters(Type type)
		{
			return new List<FilterDef>();
		}

		public IList<IClassBridgeDefinition> ClassBridges(Type type)
		{
			return new List<IClassBridgeDefinition>();
		}

		public IFieldBridgeDefinition FieldBridge(MemberInfo member)
		{
			return null;
		}

		public IDocumentIdDefinition DocumentId(MemberInfo member)
		{
			return null;
		}

		public IList<IFieldDefinition> FieldDefinitions(MemberInfo member)
		{
			return new List<IFieldDefinition>();
		}

		public IIndexedEmbeddedDefinition IndexedEmbedded(MemberInfo member)
		{
			return null;
		}

		public bool HasContainedInDefinition(MemberInfo member)
		{
			return false;
		}

		public IDateBridgeDefinition DateBridge(MemberInfo member)
		{
			return null;
		}

		public IEnumerable<IParameterDefinition> BridgeParameters(ICustomAttributeProvider member)
		{
			return Enumerable.Empty<IParameterDefinition>();
		}

		public IAnalyzerDefinition Analyzer(ICustomAttributeProvider member)
		{
			return null;
		}

		public IBoostDefinition Boost(ICustomAttributeProvider member)
		{
			return null;
		}
	}
}