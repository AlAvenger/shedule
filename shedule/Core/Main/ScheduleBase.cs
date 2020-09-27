using schedule.Core.Interfaces;
using schedule.DataBase.Models;
using System.Data.Linq;

namespace schedule.Core.Main
{
    /// <summary>
    /// Необязательный абстрактный класс, помогающий сократить количество кода
    /// за счет того, что в нём будут реализованы свойства от интерфейса,
    /// а так же сделан конструктор.
    /// 
    /// Достаточно реализации интерфейса ISchedule
    /// </summary>
    abstract class ScheduleBase : ISchedule
    {
        
        public Table<EntityControl> EntityControl { get; set; }
        public Table<Data> Data { get; set; }
        public Table<PeopleGroup> Group { get; set; }
        public Table<Room> Room { get; set; }
        public Table<Schedule> Schedule { get; set; }
        public ScheduleBase(Table<EntityControl> EntityControl, Table<Data> Data, Table<PeopleGroup> Group, Table<Room> Room, Table<Schedule> Schedule)
        {
            this.EntityControl = EntityControl;
            this.Data = Data;
            this.Group = Group;
            this.Room = Room;
            this.Schedule = Schedule;
        }

        public abstract object[] ReturnSchedule();
    }
}
