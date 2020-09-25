using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shedule.Core.Interfaces
{
    /// <summary>
    /// Базовый интерфейс который должен реализовывать любое расписание
    /// Для создания нового типа расписания
    /// необходимо реализовать пару интерфейсов:
    /// IScheduler(этот) - для составления расписания. ISchedule - для типа расписания
    /// </summary>
    interface IScheduler
    {
        
        ISchedule CreateSchedule(string entity, string peopleGroup, string Room);
    }
}
