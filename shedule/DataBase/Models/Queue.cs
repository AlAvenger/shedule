using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedule.DataBase.Models
{
    [Table(Name = "Queue")]
    class Queue
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int QueueId { get; set; }

        [Column]
        public string QueueName { get; set; }

    }
}
