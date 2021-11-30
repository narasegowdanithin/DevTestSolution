using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Wescale.DevTestData {

    /// <summary>
    /// Basis Datanbank-Layer
    /// </summary>
    public abstract class BaseDalc {

        private static ISessionFactory _sessionFactory;

        static BaseDalc() {
            // Initialize NHibernate
            Configuration cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(DevTestCommon.Entity).Assembly);

            SchemaExport schemaExport = new SchemaExport(cfg);
            schemaExport.Execute(false, true, false);

            _sessionFactory = cfg.BuildSessionFactory();
        }

        /// <summary>
        /// Liefert eine konfigurierte <see cref="ISessionFactory"/>
        /// </summary>
        internal static ISessionFactory SessionFactory {
            get => _sessionFactory;
        }

    }
}
