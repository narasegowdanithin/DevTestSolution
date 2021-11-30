namespace Wescale.DevTestCommon {

    /// <summary>
    /// Interface for simple alive service.
    /// </summary>
    public interface IPingService {

        /// <summary>
        /// Check if remoting server is alive.
        /// </summary>
        /// <returns>Some fancy value.</returns>
        string Ping();

    }
}
