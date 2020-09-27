using schedule.DataBase.Models;
using System.Data.Linq;

namespace schedule.Core.Interfaces
{
    /// <summary>
    /// Базовый интерфейс который должен реализовывать любое расписание
    /// Для создания нового типа расписания
    /// необходимо реализовать пару интерфейсов:
    /// ISchedule(этот) - для типа расписания. IScheduler - для составления расписания
    /// </summary>
    interface ISchedule 
    {
        /// <summary>
        /// Таблица Entitycontrol
        /// </summary>
        Table<EntityControl> EntityControl { get; set; }
        /// <summary>
        /// Таблица Data
        /// </summary>
        Table<Data> Data { get; set; }
        /// <summary>
        /// Таблица Group
        /// </summary>
        Table<PeopleGroup> Group { get; set; }
        /// <summary>
        /// Таблица Room
        /// </summary>
        Table<Room> Room { get; set; }
        /// <summary>
        /// Таблица Schedule
        /// </summary>
        Table<Queue> Queue { get; set; }

        /// <summary>
        /// Возвращает массив объектов
        /// </summary>
        /// <returns>Массив объектов</returns>
        object[] ReturnItems();
        object[] ReturnSchedule(Table<Schedule> Schedule);
    }
}
