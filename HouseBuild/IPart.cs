using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuild
{
    public interface IPart
    {
        bool isDone { get; set; }
        DateTime startDate { get; set; }
        DateTime endDate { get; set; }
        string partName { get; set; }
    }
}
