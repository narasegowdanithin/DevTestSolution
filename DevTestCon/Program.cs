using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Remoting;
using Wescale.DevTestCommon;
using Wescale.DevTestData;

namespace Wescale.DevTestCon {

    class Program {

        static void Main(string[] args) {
            RemotingServer();
            InitializeDatabase();

            // laufen lassen bis 'quit' oder 'exit' eingegeben wird.
            while (true) {
                Console.WriteLine();
                string command = Console.ReadLine();

                if (string.Equals(command, "quit", StringComparison.OrdinalIgnoreCase)
                    || string.Equals(command, "exit", StringComparison.OrdinalIgnoreCase)) {
                    break;
                }
            }
        }

        /// <summary>
        /// Remotingserver initialisieren.
        /// </summary>
        private static void RemotingServer() {
            Console.Write("Remoting server starting... ");

            try {
                string filename = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                RemotingConfiguration.Configure(filename, false);

                Console.WriteLine("[OK]");
            } catch (Exception ex) {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                Console.WriteLine("[failed]");
            }
        }

        private static void InitializeDatabase() {
            Console.Write("Database initializing... ");

            try {
                UserDalc userDalc = new UserDalc();
                userDalc.Save(new User() { Login = "gc", Name = "George Clooney", Email = "gc@test.local" });
                userDalc.Save(new User() { Login = "jd", Name = "Johnny Depp", Email = "jd@test.local" });
                userDalc.Save(new User() { Login = "ce", Name = "Clint Eastwood", Email = "ce@test.local" });
                userDalc.Save(new User() { Login = "ah", Name = "Audrey Hepburn", Email = "ah@test.local" });
                userDalc.Save(new User() { Login = "sm", Name = "Sophie Marceau", Email = "sm@test.local" });
                userDalc.Save(new User() { Login = "jn", Name = "Jack Nicholson", Email = "jn@test.local" });
                userDalc.Save(new User() { Login = "gp", Name = "Gwyneth Paltrow", Email = "gp@test.local" });
                userDalc.Save(new User() { Login = "ps", Name = "Patrick Stewart", Email = "ps@test.local" });

                Console.WriteLine("[OK]");
            } catch (Exception ex) {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                Console.WriteLine("[failed]");
            }
        }

    }
}
