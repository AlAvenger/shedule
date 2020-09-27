using System.Data.Linq.Mapping;

namespace schedule.DataBase.Models
{

    [Table(Name = "Data")]
    class Data
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int DataId { get; set; }

        [Column]
        public string Text { get; set; }

        [Column]
        public int? ControlId { get; set; }
    }
}
