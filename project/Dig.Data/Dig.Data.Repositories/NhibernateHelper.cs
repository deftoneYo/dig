using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;

using Dig.Data.Maps;

namespace Dig.Data.Repositories
{
	public class NhibernateHelper
	{
		protected static NHibernate.Cfg.Configuration NhConfiguration;
		protected static ISessionFactory LocalSessionFactory;

		private static ISessionFactory _sessionFactory;

		private static ISessionFactory SessionFactory
		{
			get
			{
				if (_sessionFactory == null)
				{
					var configuration = ConfigureNhibernate();
					var mapping = GetMappings();
					configuration.AddDeserializedMapping(mapping, "NHSchemaTest");
					SchemaMetadataUpdater.QuoteTableAndColumns(configuration);
					_sessionFactory = configuration.BuildSessionFactory();
				}
				return _sessionFactory;
			}
		}

		public static ISession OpenSession()
		{
			return SessionFactory.OpenSession();
		}




		public static void Setup()
		{
			NhConfiguration = ConfigureNhibernate();
			var mapping = GetMappings();
			NhConfiguration.AddDeserializedMapping(mapping, "NHSchemaTest");
			SchemaMetadataUpdater.QuoteTableAndColumns(NhConfiguration);
			LocalSessionFactory = NhConfiguration.BuildSessionFactory();
		}

		public static NHibernate.Cfg.Configuration ConfigureNhibernate()
		{

			var configure = new  NHibernate.Cfg.Configuration();
			configure.SessionFactoryName("BuildIt");

			configure.DataBaseIntegration(db =>
			{
				//*** SQL 2012 Express
				db.Dialect<MsSql2012Dialect>();
				db.Driver<SqlClientDriver>();

				db.ConnectionString = "Data Source=.\\sqlexpress2012;Initial Catalog=Dig;Integrated Security=True;Application Name=DigDb;";
				//db.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["digdb"].ConnectionString;

				db.Timeout = 10;

				//*** Testing Settings
				db.LogFormattedSql = true;
				db.LogSqlInConsole = true;
				db.AutoCommentSql = true;
			});
			return configure;
		}

		protected static HbmMapping GetMappings()
		{
			var mapper = new ModelMapper();

			mapper.AddMapping<LocationMap>();
			mapper.AddMapping<AddressMap>();
			mapper.AddMapping<UserMap>();


			mapper.CompileMappingForEachExplicitlyAddedEntity().WriteAllXmlMapping();
			var mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();

			return mapping;
		}





		public static void CreateDatabaseSchema()
		{
			var configuration = ConfigureNhibernate();
			var mapping = GetMappings();
			configuration.AddDeserializedMapping(mapping, "NHSchemaTest");
			SchemaMetadataUpdater.QuoteTableAndColumns(configuration);

			//*** TODO: This code DROPS and recreates database.
			new SchemaExport(configuration).Drop(false, true);
			new SchemaExport(configuration).Create(false, true);

		}
	}
}
