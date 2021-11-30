using System;

namespace Wescale.DevTestCommon {

    /// <summary>
    /// Basis-Entität
    /// </summary>
    [Serializable]
    public abstract class Entity {

        /// <summary>
        /// Erzeugt eine neue Instanz der Basis-Entität.
        /// </summary>
        public Entity() {
            CreatedOnUtc = DateTime.UtcNow;
        }

        /// <summary>
        /// Generierte ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Version der Entität.
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// Erstelldatum der Entität.
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// Modifikationsdatum der Entität.
        /// </summary>
        public DateTime? ModifiedOnUtc { get; set; }

    }
}