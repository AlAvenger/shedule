using schedule.Core.Interfaces;
using schedule.DataBase.Models;
using System.Data.Linq;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace schedule.Core.Main
{
    /// <summary>
    /// Необязательный абстрактный класс, помогающий сократить количество кода
    /// за счет того, что в нём будут реализованы свойства от интерфейса,
    /// а так же сделан конструктор.
    /// 
    /// Достаточно реализации интерфейса IScheduler
    /// </summary>
    abstract class SchedulerBase : IScheduler
    {
        public Table<Entity> Entity { get; set; }
        public Table<Schedule> Schedule { get; set; }
        public SchedulerBase(Table<Entity> Entity, Table<Schedule> Schedule)
        {
            if (Entity == null)
            {
                MessageBox.Show("Поле не может быть пустым");
            }
            else
            {
                this.Entity = Entity;
                this.Schedule = Schedule;
            }
        }
        public abstract ISchedule CreateSchedule(Table<EntityControl> entityControl, Table<Data> data, Table<PeopleGroup> group, Table<Room> room, Table<Queue> Queue);
    }
}
