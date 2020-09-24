using System.Data.Linq.Mapping;

namespace shedule.DataBase
{
    [Table(Name = "Lessons")]
    public class Lessons
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        //имя предмета
        [Column(Name = "Name")]
        public string LessonName { get; set; }

        //группа школоты
        [Column(Name = "ClassId")]
        public int ClassId { get; set; }

        //кабинет
        [Column(Name = "ClassroomsId")]
        public int ClassroomsId { get; set; }
    
        //блядуха-обучалка
        [Column(Name = "TeacherId")]
        public int TeacherId { get; set; }
    }
}
