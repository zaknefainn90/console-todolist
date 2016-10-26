using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo1
{
    class AddNewTask: TaskService
    {
        public void addSimpleTask()
        {
           CommandConditionInputs(addNewSimpleTask, "\nWprowadz nazwę nowego zadania do lity ToDo", "BŁĄD !!! --> Proszę podać nazwę zadania nie pusty ciąg znaków");
        }

        private bool addNewSimpleTask()
        {
            int index = Service.tasks.Count;

            Service.tasks.Insert(0, new Task((index + 1), taskName));

            Console.WriteLine("\nDodano nowe zadanie \n");

            return true;
        }

        public void addFullTask()
        {
            CommandConditionInputs(addNewFullTask, "\nWprowadz dane nowego zadania do lity ToDo", "BŁĄD !!! --> Proszę podać dane zadania nie pusty ciąg znaków");
        }

        public bool addNewFullTask()
        {
            //TODO: dodac możliwość wpisywania nowego zadania z wszystkimi jego parametrami
            return true;
        }

    }
}
