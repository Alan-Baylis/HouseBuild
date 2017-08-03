using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuild
{
    public interface IWorker
    {
        string name { get; set; }
        string position { get; set; }

        void toDoWork(ref List<PartBuilding> listOfWork);
    }
}
