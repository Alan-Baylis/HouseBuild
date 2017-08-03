using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuild
{
    public class Team
    {
       public static List<Worker> workers = new List<Worker>();
        Random rnd = new Random();
        public void StartWork(List<PartBuilding> tasks)
        {
            var t = tasks.Any(w => !w.isDone);

            while (tasks.Any(w=>!w.isDone))
            {
                workers[rnd.Next(0, workers.Count)].toDoWork(ref tasks);

            }
        }
    }
}
