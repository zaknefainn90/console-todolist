using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo1
{
    class Service
    {
        public static List<Task> tasks = new List<Task> { };
        public static List<Task> ended = new List<Task> { };
        public static List<Task> delated = new List<Task> { };

        public static void SimplePrintConsoleTaskList(List<Task> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(" " + i + " - " + list[i].ShortText() + "\n");
            }
        }

        public static void FullPrintConsoleTaskList(List<Task> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(" " + i + " - " + list[i].FullText() + "\n");
            }
        }
    }
}
