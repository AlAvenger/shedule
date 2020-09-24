using System.Data.Linq.Mapping;

namespace shedule
{
    [Table(Name = "Teachers")]
    class Teachers
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }
        
        [Column(Name = "FullName")]
        public string FullName { get; set; }
        
        //[Column(Name = "LessonId")]
        //public string LessonId { get; set; }

        public override string ToString()
        {
            return FullName;
        }
    }
}