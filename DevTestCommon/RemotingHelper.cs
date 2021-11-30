using System;
using System.Collections.Generic;
using System.Runtime.Remoting;

namespace Wescale.DevTestCommon {

    /// <summary>
    /// Hilfsklasse zur Instantiierung von Objekten.
    /// </summary>
    public sealed class RemotingHelper {

        static object s_initLock = new object();
        static bool s_initialized;
        static Dictionary<Type, WellKnownClientTypeEntry> s_wellKnownTypes = new Dictionary<Type, WellKnownClientTypeEntry>();

        /// <summary>
        /// Schutz vor Instantiierung.
        /// </summary>
        private RemotingHelper() {
        }

        /// <summary>
        /// Erstellt ein Objekt des angegebenen Typs mittels <b>Activator.GetObject()</b>.
        /// Der Typ des Objekts muss in der Remoting-Konfiguration als
        /// WellknownType registriert sein.
        /// </summary>
        /// <remarks>
        /// Die Methode übergibt auch den aktuellen <see cref="IPrincipal"/>
        /// an den Proxy.
        /// </remarks>
        /// <param name="type">Zu erstellender Typ</param>
        /// <returns>Instanz des Typs <paramref name="type"/></returns>
        /// <exception cref="RemotingException">Typ ist nicht in der
        /// Remoting-Konfiguration registriert</exception>
        public static object GetObject(Type type) {
            if (!s_initialized) {
                lock (s_initLock) {
                    if (!s_initialized) {
                        Initialize();
                        s_initialized = true;
                    }
                }
            }

            WellKnownClientTypeEntry entry = (s_wellKnownTypes.ContainsKey(type) ? s_wellKnownTypes[type] : null);
            if (entry == null) {
                RemotingException ex = new RemotingException("Cannot instantiate remote object of type " + (type));
                throw ex;
            }

            object obj = Activator.GetObject(entry.ObjectType, entry.ObjectUrl);

            return obj;
        }

        /// <summary>
        /// Liest die registrierten Typen aus der Remoting-Konfiguration
        /// und speichert diese für den schnellen Zugriff zwischen.
        /// </summary>
        /// <exception cref="RemotingException">Gefundener Typ nicht gefunden</exception>
        private static void Initialize() {
            s_wellKnownTypes = new Dictionary<Type, WellKnownClientTypeEntry>();
            foreach (WellKnownClientTypeEntry entry in RemotingConfiguration.GetRegisteredWellKnownClientTypes()) {
                if (entry.ObjectType == null) {
                    RemotingException ex = new RemotingException("Object type for type " + ((entry.TypeName != null) ? entry.TypeName : "(null)") + " could not be found. Check spelling in RemotingClient.config.");
                    throw ex;
                }
                s_wellKnownTypes.Add(entry.ObjectType, entry);
            }
        }

        /// <summary>
        /// Liefert die URI einer Komponente auf dem Server.
        /// </summary>
        /// <param name="type">Typ des Interfaces der Komponente.</param>
        /// <returns>Die Remoting-URI der Komponente auf dem Server.</returns>
        /// <exception cref="RemotingException">Der Typ ist nicht bekannt.</exception>
        public static string GetObjectUri(Type type) {
            string componentUri = null;
            if (s_wellKnownTypes.ContainsKey(type)) {
                componentUri = s_wellKnownTypes[type].ObjectUrl;
            } else {
                throw new RemotingException("Component name or URI for type '" + type + "' is unknown.");
            }
            return componentUri;
        }

    }
}