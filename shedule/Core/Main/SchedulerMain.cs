using shedule.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shedule.Core.Main
{
    abstract class SchedulerMain : Form1, IScheduler
    {

        public abstract ISchedule CreateSchedule(string entity, string peopleGroup, string Room);
    }
}
