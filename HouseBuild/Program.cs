using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuild
{
    class Program
    {
        static void Main(string[] args)
        {

            //Basement basem = new Basement();
            //basem.startBuilding(DateTime.Now);


            //Worker kalib = new Worker("Калибшут");
            //kalib.toDoWork();
            List<IPart> listOfWork = new List<IPart>();
            listOfWork.Add(new Basement());
            listOfWork.Add(new Walls());
            listOfWork.Add(new Window());
            listOfWork.Add(new Door());
            listOfWork.Add(new Roof());
            for (int i = 1; i < 10; i++)
            {
                Team.workers.Add(new Worker("Равшан"+i, "Негр"));
            }

            Console.WriteLine(Team.workers[3]);

            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                Team.workers[rand.Next(0, 9)].toDoWork(ref listOfWork);
            }


            
        }
    }
}
