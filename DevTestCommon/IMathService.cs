namespace Wescale.DevTestCommon {

    /// <summary>
    /// Interface des Dienstes für mathematische Berechnungen.
    /// </summary>
    public interface IMathService {

        /// <summary>
        /// Addiert zwei ganzzahlige Werte.
        /// </summary>
        /// <param name="a">Erste Zahl</param>
        /// <param name="b">Zweite Zahl</param>
        /// <returns>Ergebnis</returns>
        int Add(int a, int b);

        /// <summary>
        /// Multipliziert zwei ganzzahlige Werte.
        /// </summary>
        /// <param name="a">Erste Zahl</param>
        /// <param name="b">Zweite Zahl</param>
        /// <returns>Ergebnis</returns>
        int Mul(int a, int b);

        /// <summary>
        /// Subtrahiert zwei ganzzahlige Werte.
        /// </summary>
        /// <param name="a">Erste Zahl</param>
        /// <param name="b">Zweite Zahl</param>
        /// <returns>Ergebnis</returns>
        int Sub(int a, int b);

        /// <summary>
        /// Dividiert zwei ganzzahlige Werte.
        /// </summary>
        /// <param name="a">Erste Zahl</param>
        /// <param name="b">Zweite Zahl</param>
        /// <returns>Ergebnis</returns>
        int Div(int a, int b);

        /// <summary>
        /// Modulo-Operation zweier ganzzahlige Werte.
        /// </summary>
        /// <param name="a">Erste Zahl</param>
        /// <param name="b">Zweite Zahl</param>
        /// <returns>Ergebnis</returns>
        int Mod(int a, int b);

    }
}
