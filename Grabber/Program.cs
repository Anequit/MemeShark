using System;
using System.IO;

namespace Grabber
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            - Attach to browser in config
		    - Manage drivers
		    - Read from the config
		    - Do webscrapping tasks
		    - Write to links.json
            **/

            if (!File.Exists("config.json"))
                Environment.Exit(2);

            Console.ReadLine();
        }
    }
}
