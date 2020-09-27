using System.Data.Linq.Mapping;

namespace schedule.DataBase.Models
{
    [Table(Name = "Entity")]
    public class Entity
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int EntityId { get; set; }

        [Column]
        public string EntityName { get; set; }
    }
}
