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
        string Entity { get; }
        string EntityControl { get; }
        string Info { get; }
        void Set();
    }
}
