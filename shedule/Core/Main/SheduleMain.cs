using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shedule.Core
{
    /// <summary>
    /// Вспомогательный абстрактный класс
    /// который помогает уменьшить количество кода
    /// реализация этого класса необязательна, достаточно реализиации ISchedule.
    /// Но он помогает сократить кол-во дублируемого кода
    /// за счет того, что не нужно объявлять свойства и конструктор
    /// </summary>
    abstract class SheduleMain : ISchedule
    {
        public string Entity { get; set; }
        public string PeopleGroup { get; set; }
        public string Room { get; set; }

        public SheduleMain(string Entity, string PeopleGroup, string Room)
        {
            if(string.IsNullOrWhiteSpace(Entity) || string.IsNullOrWhiteSpace(PeopleGroup) || string.IsNullOrWhiteSpace(Room))
            {
                MessageBox.Show("Поля не могут быть пустыми");
            }

            this.Entity = Entity;
            this.PeopleGroup = PeopleGroup;
            this.Room = Room;
        }
        public abstract void Set();
    }
}
