using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseBuild
{
    class Basement : Building, IPart
    {
        private Random rand = new   Random();
        DateTime sDate = new DateTime();
        DateTime eDate = new DateTime();
        public DateTime startDate
        {
            get { return sDate; }
            set { sDate= value.AddDays(rand.Next(1)); }
        }
        public DateTime endDate
        {
            get { return sDate; }
            set { eDate = value.AddDays(rand.Next(1,10)); }
        }
        public bool isDone
        {
            get
            {
                if (eDate!=null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           
        }

        public override void startBuilding()
        {
           
        }
    }
}
