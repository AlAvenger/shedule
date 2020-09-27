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
        public Table<Queue> Queue { get; set; }

      
        public ScheduleBase(Table<EntityControl> EntityControl, Table<Data> Data, Table<PeopleGroup> Group, Table<Room> Room, Table<Queue> Queue)
        {
            this.EntityControl = EntityControl;
            this.Data = Data;
            this.Group = Group;
            this.Room = Room;
            this.Queue = Queue;
        }

        public abstract object[] ReturnItems();
        public abstract object[] ReturnSchedule(Table<Schedule> Schedule);
    }
}
