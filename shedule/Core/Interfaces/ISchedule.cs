using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shedule.Core
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
        /// Сущность расписания, для кого его составляем
        /// </summary>
        string Entity { get; set; }

        /// <summary>
        /// Сущность тех, кто будет пользоваться этим расписанием
        /// </summary>
        string PeopleGroup { get; set; }

        /// <summary>
        /// Место определения Entity и Group
        /// </summary>
        string Room { get; set; }

        //TODO: Заменить таблицы на Entity, PeopleGroup, Room. Добавить таблицу Union для соединения Id трёх таблиц
        void Set();
    }
}
