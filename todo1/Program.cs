using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo1
{
    class Program
    {
        private static string name;
        public static string commands = "Komendy listy TODO \n 1. 'lista' - wyswietl wszystkie zadania \n 2. 'dodaj' - dodaj nowe zadanie \n 3. 'usuń - usuń zadanie z listy \n 4. 'save' - zapisz zadania do pliku json";
        public static string help = "POMOC \n Lista poleceń oraz argumentów \n 1. 'lista' - wyswietl wszystkie zadania \n    'lista -a' - wyświetl wszystkie zadanie z szczegułami";

        private static AddNewTask add;
        private static RemoveTask removeTask;

        private static void Hello()
        {
            Console.WriteLine("Podaj swoję imię: ");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Witaj " + name);
            Console.WriteLine(" ");
            Console.WriteLine(commands);
        }

        private static void getInputsCommand(string input)
        {
            Console.Clear();
            switch (input)
            {
                case "1":
                case "lista":
                    Console.WriteLine("\nLista twoich zadań: \n");
                    Service.SimplePrintConsoleTaskList(Service.tasks);
                    break;
                case "1 -a":
                case "1 -all":
                case "lista -a":
                case "lista -all":
                    Console.WriteLine("\nLista twoich zadań: \n");
                    Service.FullPrintConsoleTaskList(Service.tasks);
                    break;
                case "1 -d":
                case "1 -del":
                case "lista -d":
                case "lista -del":
                    Console.WriteLine("\nLista zadań usuniętych: \n");
                    Service.FullPrintConsoleTaskList(Service.delated);
                    break;
                case "1 -e":
                case "1 -end":
                case "lista -e":
                case "lista -end":
                    Console.WriteLine("\nLista zadań zakończonych: \n");
                    Service.FullPrintConsoleTaskList(Service.ended);
                    break;
                case "2":
                case "dodaj":
                    add = new AddNewTask();
                    add.addSimpleTask();
                    break;
                case "3":
                case "usuń":
                    removeTask = new RemoveTask();
                    removeTask.removeTask();
                    break;
                case "3 -id":
                case "usuń -id":
                    removeTask.removeTaskByID();
                    break;
                case "help":
                case "h":
                    Console.WriteLine(help + "\n");
                    break;
                case "4":
                case "save":
                    SaveData.saveToRootFile();
                    break;
                default:
                    Console.WriteLine("polecenie nieznane");
                    break;
            }
            Console.WriteLine(commands);
        }

        static void Main(string[] args)
        {
            Service.tasks.Add(new Task(1, "Pierwsze zadanie testowe"));
            
            Console.Clear();
            string input;
            Hello();
            do
            {
                input = Console.ReadLine();
                getInputsCommand(input);
            } while (input != null);

            //while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

    }
}
