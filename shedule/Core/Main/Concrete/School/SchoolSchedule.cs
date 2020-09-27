using schedule.DataBase.Models;
using shedule.DataBase.String;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedule.Core.Main.Concrete.School
{
    class SсhoolSchedule : ScheduleBase
    {
        public SсhoolSchedule(Table<EntityControl> entityControl, Table<Data> data, Table<PeopleGroup> peopleGroup, Table<Room> room, Table<Queue> Queue) : base(entityControl, data, peopleGroup, room, Queue)
        {
        }
        public override object[] ReturnItems()
        {
            var dc = new DataContext(ConnectionString.ConnectionStr);
            var control = EntityControl;
            var data = Data;
            var room = Room;

            var query = control.Join(data, table1 => table1.ControlId, table2 => table2.ControlId,
                                                                    (con, dat) => new {con, dat})
                .Select(x => x.con.ControlName + "," + x.dat.Text);

            return query.ToArray();
        }
        public override object[] ReturnSchedule(Table<Schedule> Schedule)
        {
            var dc = new DataContext(ConnectionString.ConnectionStr);
            var control = EntityControl;
            var data = Data;
            var room = Room;

            return Schedule.Select(x => x).ToArray();
                


        }
    }
}
