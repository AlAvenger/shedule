using schedule.Core.Interfaces;
using schedule.DataBase.Models;
using System.Data.Linq;

namespace schedule.Core.Main.Concrete.School
{
    class SchoolScheduler : SchedulerBase
    {
        public SchoolScheduler(Table<Entity> Entity) : base(Entity)
        {
        }

        public override ISchedule CreateSchedule(Table<EntityControl> entityControl, Table<Data> data, Table<PeopleGroup> group, Table<Room> room, Table<Schedule> Schedule)
        {
            ISchedule schedule = new SсhoolSchedule(entityControl, data, group, room, Schedule);
            return schedule;
        }
    }
}
