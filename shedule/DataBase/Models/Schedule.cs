using System.Data.Linq.Mapping;

namespace schedule.DataBase.Models
{
    [Table(Name = "Schedule")]
    class Schedule
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column]
        public string DataText { get; set; }

        [Column]
        public string ControlName { get; set; }

        [Column]
        public string RoomName { get; set; }

        [Column]
        public string QueueName { get; set; }

        [Column]
        public string GroupName { get; set; }
    }
}
