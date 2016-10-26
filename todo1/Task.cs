using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo1
{
    class Task
    {
        public int id;
        public string name;
        public DateTime created;
        public bool status;

        public Task(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.created = DateTime.Now;
            this.status = false;
        }

        public string GetName()
        {
            return name;
        }

        public int getId()
        {
            return id;
        }

        public string ShortText()
        {
            return "[ ] " + name;
        }

        public string FullText()
        {
            return "[ ] " + name + " | " + created.ToString() + " | status: " + StatusText() + " | id: " + id;
        }

        private string StatusText()
        {
            if (status)
            {
                return "zakończono";
            }
            else
            {
                return "w toku";
            }
        }
    }
}
