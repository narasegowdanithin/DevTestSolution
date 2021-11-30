using System;

namespace Wescale.DevTestCommon {

    /// <summary>
    /// Benutzer
    /// </summary>
    [Serializable]
    public class User : Entity {

        /// <summary>
        /// Login
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// E-Mail
        /// </summary>
        public string Email { get; set; }

    }
}
