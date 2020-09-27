using System.Data.Linq.Mapping;

namespace schedule.DataBase.Models
{
    [Table(Name = "Room")]
    class Room
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int RoomId { get; set; }

        [Column]
        public string RoomName { get; set; }

        [Column]
        public int ControlId { get; set; }
    }
}
