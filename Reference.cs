using System;
using System.Collections.Generic;
using System.Text;

namespace ArghOS.Utils
{
	public class Reference
	{
        public static string OSName = "SuperOS";
        public static string Version = "1.0.0";

        public static string RootPath = @"0:\";
        public static string CurrentDirectory = RootPath;

        public static string DefaultAccessPrefix = "$ ";
        public static string RootAccessPrefix = "# ";

        public static Cosmos.System.FileSystem.CosmosVFS FAT = new Cosmos.System.FileSystem.CosmosVFS();

        public static Accounts.Account UserAccount = null;
    }
}
