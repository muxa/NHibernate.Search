using NHibernate.Search.Store;

namespace NHibernate.Search.Fluent.Cfg
{
	public class FluentSearchDirectoryProviderConfiguration
	{
		private readonly FluentSearchConfiguration cfg;

		internal FluentSearchDirectoryProviderConfiguration(FluentSearchConfiguration cfg)
		{
			this.cfg = cfg;
		}

		public FluentSearchConfiguration Custom<TDirectoryProvider>() where TDirectoryProvider : IDirectoryProvider
		{
			(cfg as IFluentSearchConfiguration).Configuration.Properties.Add("hibernate.search.default.directory_provider", typeof(TDirectoryProvider).AssemblyQualifiedName);
			return cfg;
		}

		/// <summary>
		/// Sets the directory provider to an FSDirectory
		/// </summary>
		/// <returns></returns>
		public FluentSearchConfiguration FSDirectory()
		{
			return Custom<FSDirectoryProvider>();
		}

		/// <summary>
		/// Sets the directory provider to a RAMDirectory
		/// </summary>
		/// <returns></returns>
		public FluentSearchConfiguration RAMDirectory()
		{
			return Custom<RAMDirectoryProvider>();
		}
	}
}