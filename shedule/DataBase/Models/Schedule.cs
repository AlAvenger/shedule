using System.Data.Linq.Mapping;

namespace schedule.DataBase.Models
{
    [Table(Name = "Schedule")]
    class Schedule
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column]
        public int? DataId { get; set; }

        [Column]
        public int? ControlId { get; set; }

        [Column]
        public int? RoomId { get; set; }
    }
}
