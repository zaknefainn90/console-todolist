using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo1
{
    class RemoveTask: TaskService
    {
        public void removeTask()
        {
            CommandConditionInputs(deleteTasksFromList, "\nWprowadz nazwę zadania do ununięcia", "BŁĄD !!! --> Proszę wpisać nazwę lub numer zadania");
        }

        private bool deleteTasksFromList()
        {
            int numericIndex;
            bool isNuneric = int.TryParse(taskName, out numericIndex);

            if (numericIndex < Service.tasks.Count)
            {
                if (isNuneric)
                {
                    Service.tasks.RemoveAt(numericIndex);
                    printMessage("Zadanie usunięto");
                    return true;
                }
                else
                {
                    IfDeletedCommandIsString();
                    return true;
                }
            }
            else
            {
                printMessage("BŁĄD !!! --> Wprowadzony indeks przekracza wielkość listy z zadaniami");
                removeTask();
                return false;
            }
        }

        private void IfDeletedCommandIsString()
        {
            int counter = 0;
            bool isRecurent = true;

            for (int i = 0; i < Service.tasks.Count; i++)
            {
                if (Service.tasks[i].GetName().Equals(taskName))
                {
                    Service.delated.Add(Service.tasks[i]);
                    Service.tasks.RemoveAt(counter);
                    isRecurent = false;

                    printMessage("Zadanie usunięto ");
                    return;
                }
            }

            if (isRecurent)
            {
                printMessage("BŁĄD !!! --> Wprowadzona nazwa zadania nie istnieje");
                removeTask();
            }
        }

        public void removeTaskByID()
        {
            CommandConditionInputs(deleteTaskFromListByID, "\nWprowadz index zadania do ununięcia", "BŁĄD !!! --> Proszę wpisać index zadania");
        }

        private bool deleteTaskFromListByID()
        {
            int numericIndex;
            bool isNuneric = int.TryParse(taskName, out numericIndex);

            if (isNuneric)
            {
                for (int i = 0; i < Service.tasks.Count; i++)
                {
                    if (Service.tasks[i].getId() == numericIndex)
                    {
                        Service.delated.Add(Service.tasks[i]);
                        Service.tasks.RemoveAt(i);
                    }
                }
            }
            else
            {
                printMessage("BŁĄD !!! --> Wprowadzony indekx musi być liczbą");
                removeTaskByID();
                return false;
            }

            return true;
        }
    }
}
