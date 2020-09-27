using System.Data.Linq.Mapping;

namespace schedule.DataBase.Models
{
    [Table(Name = "EntityControl")]
    class EntityControl
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int? ControlId { get; set; }

        [Column]
        public string ControlName { get; set; }

        [Column]
        public int? EntityId { get; set; }
    }
}
