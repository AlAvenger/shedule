using schedule.Core.Interfaces;
using schedule.DataBase.Models;
using shedule.DataBase.String;
using System.Data.Linq;

namespace schedule.Core.Main.Concrete.School
{
    class SchoolScheduler : SchedulerBase
    {
        public SchoolScheduler(Table<Entity> Entity, Table<Schedule> Schedule) : base(Entity, Schedule)
        {
        }

        public override ISchedule CreateSchedule(Table<EntityControl> entityControl, Table<Data> data, Table<PeopleGroup> group, Table<Room> room, Table<Queue> Queue)
        {
            ISchedule schedule = new SсhoolSchedule(entityControl, data, group, room, Queue);
            return schedule;
        }
    }
}
