using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuild
{
    public class Worker : IWorker
    {
        public enum positionList { Boss, Worker }
        public string name { get; set; }
        public string position { get; set; }

        public Worker(string name) : this(name, positionList.Worker) { }
        public Worker(string name, positionList position)
        {
            this.name = name;
            this.position = position.ToString();
        }

        public void toDoWork(ref List<PartBuilding> tasks)
        {
            DateTime lastFisnishDate = DateTime.Now;

            if (tasks.Any(w => w.isDone))
                lastFisnishDate = tasks.Where(w => w.isDone).Max(m=>m.endDate);

            PartBuilding task = tasks.Where(w => !w.isDone).OrderBy(o => o.priority).Take(1).FirstOrDefault();
            task.startDate = lastFisnishDate.AddDays(1);

            Console.WriteLine(String.Format("Начал работу {0} ({1}) по строительству {2}", lastFisnishDate, name, task.partName));

            PartBuilding basem = new PartBuilding();
            basem.startBuilding(ref task);

        }
    }
}
