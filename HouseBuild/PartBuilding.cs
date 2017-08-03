using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseBuild
{
    public class PartBuilding : Building, IPart
    {
        private Random rand = new   Random();

        public string partName { get; set; }
        public int priority { get; set; }

        public DateTime startDate
        { get; set; }
        public DateTime endDate
        { get; set; }
        public bool isDone { get; set; }
        //{
        //    get
        //    {
        //        if (eDate!=null && eDate!=DateTime.MinValue)
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }
           
        //}

        public override void startBuilding(ref PartBuilding task)
        {
            var countDay = rand.Next(1, 10);
            for (int i = 0; i < countDay; i++)
            {
                //Console.Write(" . ");              
                Thread.Sleep(1000);
            }
           

            task.endDate = DateTime.Now.Date.AddDays(countDay);
            task.isDone = true;

            Console.WriteLine("");
            Console.WriteLine("Завершил работу "+ task.endDate);
            Console.WriteLine("");
            Console.WriteLine("");

        }
    }
}
