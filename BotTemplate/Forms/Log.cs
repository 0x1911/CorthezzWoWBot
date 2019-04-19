using System;
using System.Collections.Generic;

namespace BotTemplate.Forms
{
    internal static class Log
    {
        private static bool clear = false;
        private static List<string> messages = new List<string>();

        internal static void Add(string parMessage)
        {
            if (clear)
            {
                messages = new List<string>();
                clear = false;
            }
            messages.Add(DateTime.Now.ToString("HH:mm:ss") + " -> " + parMessage + Environment.NewLine);

        }
        
        internal static void CleanUp()
        {
            messages = new List<string>();
            clear = true;
        }

        internal static List<string> get
        {
            get
            {
                if (!clear)
                {
                    clear = true;
                    
                    return messages;
                }

                return messages;
            }
        }
    }
}
