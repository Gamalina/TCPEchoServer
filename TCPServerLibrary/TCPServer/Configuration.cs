using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPServerLibrary
{
    public class Configuration
    {
        public int ServerPort { get; set; }
        public int ShutdownPort { get; set; }
        public string ServerName { get; set; }
        public SourceLevels DebugLevel { get; set; }
        public string LogFilePath { get; set; }

        public Configuration()
        {
            ServerPort = 7007;
            ShutdownPort = ServerPort + 1;
            ServerName = "";
            DebugLevel = SourceLevels.Information;
            LogFilePath = ".";

        }
    }
}
