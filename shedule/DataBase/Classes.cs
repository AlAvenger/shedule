using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shedule.DataBase
{
    [Table(Name = "Classes")]
    class Classes
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column(Name = "Code")]
        public string Code { get; set; }

        //[Column(Name = "LessonToday")]
        //public int? LessonToday { get; set; }

    }
}
