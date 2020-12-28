using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using ArghOS.Accounts;
using ArghOS.Programs;
using ArghOS.Utils;

namespace ArghOS.Utils
{
	public class FileSystem
	{
        public static void LoadFileSystem()
        {
            ColorConsole.WriteLine(ConsoleColor.Yellow, "Loading virtual file system...");
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(Reference.FAT);

            if (Reference.FAT.GetVolumes().Count > 0)
            {
                ColorConsole.WriteLine(ConsoleColor.Green, "Sucessfully loaded the virtual file system.");
            }
            else
            {
                ColorConsole.WriteLine(ConsoleColor.Red, "Couldn't load the virtual file system...");
            }

            Console.WriteLine();
        }
    }
}
