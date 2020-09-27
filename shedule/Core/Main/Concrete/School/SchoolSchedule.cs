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
        public SсhoolSchedule(Table<EntityControl> entityControl, Table<Data> data, Table<PeopleGroup> peopleGroup, Table<Room> room, Table<Schedule> Schedule) : base(entityControl, data, peopleGroup, room, Schedule)
        {
        }

        public override object[] ReturnSchedule()
        {
            var dc = new DataContext(ConnectionString.ConnectionStr);
            var control = dc.GetTable<EntityControl>();
            var data = dc.GetTable<Data>();
            var query = control.Join(data, table1 => table1.ControlId, table2 => table2.ControlId, (con, dat) => new {con, dat}).Select(x => x.con.ControlName + "," + x.dat.Text);
            return query.ToArray();
        }
    }
}
