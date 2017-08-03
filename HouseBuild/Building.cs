using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseBuild
{
   public class Building
    {
        
        private Random rand = new Random();
        protected DateTime sDate = new DateTime();
        protected DateTime eDate = new DateTime();
        //public DateTime startDate
        //{
        //    get { return sDate; }
        //    set { sDate = value.AddDays(rand.Next(1)); }
        //}
        //public DateTime endDate
        //{
        //    get { return sDate; }
        //    set { eDate = value.AddDays(rand.Next(1, 10)); }
        //}
    

        public virtual void startBuilding(ref PartBuilding task)
        {

            //var countDay = rand.Next(1, 10);
            //int i = 1;
            //while (countDay != i)
            //{
            //    Console.Write(" . ");
            //    i++;
            //    Thread.Sleep(1000);
            //}
            //Console.WriteLine("Finished");
        }

    }
}
