using schedule.DataBase.Models;
using System.Data.Linq;

namespace schedule.Core.Interfaces
{
    /// <summary>
    /// Базовый интерфейс который должен реализовывать любое расписание
    /// Для создания нового типа расписания
    /// необходимо реализовать пару интерфейсов:
    /// IScheduler(этот) - для составления расписания. ISchedule - для типа расписания
    /// </summary>
    interface IScheduler
    {
       
        /// <summary>
        /// Таблица Entity
        /// </summary>
        Table<Entity> Entity { get; set; }
        Table<Schedule> Schedule { get; set; }
        /// <summary>
        /// Создание расписания, формирование в нём таблиц.
        /// </summary>
        /// <param name="entityControl"></param>
        /// <param name="data"></param>
        /// <param name="group"></param>
        /// <param name="room"></param>
        /// <param name="Schedule"></param>
        /// <returns></returns>
        ISchedule CreateSchedule(Table<EntityControl> entityControl, Table<Data> data, Table<PeopleGroup> group, Table<Room> room, Table<Queue> Queue);


    }
}
