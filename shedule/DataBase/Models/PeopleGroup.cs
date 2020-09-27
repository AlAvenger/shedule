using System.Data.Linq.Mapping;

namespace schedule.DataBase.Models
{
    [Table(Name = "PeopleGroup")]
    class PeopleGroup
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int GroupId { get; set; }

        [Column]
        public string GroupName { get; set; }

        [Column]
        public int? ControlId { get; set; }
    }
}
