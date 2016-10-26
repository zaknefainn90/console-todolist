using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo1
{
    abstract class TaskService
    {
        protected string taskName;
        public void printMessage(string text)
        {
            Console.Clear();
            Console.WriteLine(text + "\n");
        }

        public void CommandConditionInputs(Func<bool> myMethodName, string startMessage, string errorMessage)
        {
            Console.WriteLine(startMessage);

            taskName = Console.ReadLine();

            if (taskName != "" & taskName.Equals("exit") == false & taskName.Equals("help") == false)
            {
                myMethodName();
            }
            else if (taskName.Equals("exit"))
            {
                Console.Clear();
                return;
            }
            else if (taskName.Equals("help"))
            {
                Console.Clear();
                Console.WriteLine("\n" + Program.help + "\n");
                return;
            }
            else
            {
                printMessage(errorMessage);
                CommandConditionInputs(myMethodName, startMessage, errorMessage);
            }
        }
    }
}
