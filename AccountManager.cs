﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ArghOS.Accounts;
using ArghOS.Programs;
using ArghOS.Utils;

namespace ArghOS.Accounts
{
	public class AccountManager
	{
        public static string GetPassword(string name, bool decrypt = false)
        {
            string accountPath = Reference.RootPath + @"Accounts\" + name + ".txt";

            string password = string.Empty;

            if (!Directory.Exists(Reference.RootPath + "Accounts"))
            {
                ColorConsole.WriteLine(ConsoleColor.Red, "This account doesn't exist.");
            }

            if (File.Exists(accountPath))
            {
                password = File.ReadAllText(accountPath).Split(":")[1];
            }
            else
            {
                ColorConsole.WriteLine(ConsoleColor.Red, "This account doesn't exist.");
            }

            if (decrypt)
            {
                password = Encoding.ASCII.GetString(Convert.FromBase64String(password));
            }

            return password;
        }

        public static bool Exist(string name)
        {
            string accountPath = Reference.RootPath + @"Accounts\" + name + ".txt";

            if (!Directory.Exists(Reference.RootPath + "Accounts"))
            {
                ColorConsole.WriteLine(ConsoleColor.Red, "This account doesn't exist");
                return false;
            }

            if (!File.Exists(accountPath))
            {
                ColorConsole.WriteLine(ConsoleColor.Red, "This account doesn't exist");
                return false;
            }

            return true;
        }
    }
}
