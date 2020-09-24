using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shedule.DataBase
{
    [Table(Name = "Classrooms")]
    class Classrooms
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column]
        public string ClassroomName { get; set; }

        //[Column]
        //public int ClassesId { get; set; }
    }
}
