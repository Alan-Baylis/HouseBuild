using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuild
{
    class Worker:IWorker
    {
        public string name { get; set; }
        public string position { get; set; }
        public Worker(string name) : this(name, "Рабочий") { }
        public Worker(string name, string position)
        {
            this.name = name;
            this.position = position;
        }

        public void toDoWork(ref List<IPart> listOfWork)
        {
            foreach (var item in listOfWork.Where(l=>!l.isDone))
            {
                item.startDate = DateTime.Now;
                Console.WriteLine(String.Format("Начал работу: {0} в позиции{1}", name, position));
                Basement basem = new Basement();
                basem.startBuilding();
                break;
            }
           
        }
    }
}
