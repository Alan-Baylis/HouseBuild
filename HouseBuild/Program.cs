using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuild
{
    class PartInfo
    {
        public int Count { get; set; }
        public string PartName { get; set; }
        public int Priority { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<PartInfo> partInfo = new List<PartInfo>();
            partInfo.Add(new PartInfo() { Count = 1, PartName = "Фундамент", Priority = 1 });
            partInfo.Add(new PartInfo() { Count = 4, PartName = "Стена", Priority = 2 });
            partInfo.Add(new PartInfo() { Count = 4, PartName = "Окно", Priority = 3 });
            partInfo.Add(new PartInfo() { Count = 3, PartName = "Дверь", Priority = 4 });
            partInfo.Add(new PartInfo() { Count = 1, PartName = "Крыша", Priority = 5 });

            List<PartBuilding> tasks = new List<PartBuilding>();
            foreach (var item in partInfo)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    PartBuilding p = new PartBuilding();
                    p.priority = item.Priority;
                    p.partName = item.PartName;
                    p.isDone = false;
                    tasks.Add(p);
                }
            }


            //  Team.workers.Add(new Worker("Stiff", Worker.positionList.Boss));
            Team.workers.Add(new Worker("Ravshan"));
            Team.workers.Add(new Worker("Jamshut"));
            Team.workers.Add(new Worker("Bill"));
            Team.workers.Add(new Worker("Mark"));

            Team t = new Team();
            t.StartWork(tasks);












            //Basement basem = new Basement();
            //basem.startBuilding(DateTime.Now);


            //Worker kalib = new Worker("Калибшут");
            //kalib.toDoWork();
            //List<IPart> listOfWork = new List<IPart>();
            //listOfWork.Add(new PartBuilding());
            //listOfWork.Add(new Walls());
            //listOfWork.Add(new Window());
            //listOfWork.Add(new Door());
            //listOfWork.Add(new Roof());
            //for (int i = 1; i < 10; i++)
            //{
            //    Team.workers.Add(new Worker("Равшан"+i, "Негр"));
            //}

            //Console.WriteLine(Team.workers[3]);

            //Random rand = new Random();
            //for (int i = 0; i < 50; i++)
            //{
            //    Team.workers[rand.Next(0, 9)].toDoWork(ref listOfWork);
            //}



        }
    }
}
