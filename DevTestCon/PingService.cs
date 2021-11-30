using System;
using Wescale.DevTestCommon;

namespace Wescale.DevTestCon {

    /// <summary>
    /// Simple alive service.
    /// </summary>
    public class PingService : MarshalByRefObject, IPingService {

        /// <summary>
        /// Check if remoting server is alive.
        /// </summary>
        /// <returns>Some fancy value.</returns>
        public string Ping() {
            return "pong - " + DateTime.Now.ToString();
        }

    }
}
