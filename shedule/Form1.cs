using shedule.DataBase;
using System;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
namespace shedule
{
    public partial class Form1 : Form
    {
        DataContext dataContext = new DataContext(ConnString.ConnStr);

     

        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dc = new DataContext(ConnString.ConnStr);
            
            var l = dc.GetTable<Lessons>();
            var c = dc.GetTable<Classes>();
            var t = dc.GetTable<Teachers>();

            var list = l.Join(t, table => table.Id, table2 => table2.Id, (Lesson, Teacher) => new { Lesson, Teacher })
                        .Join(c, table => table.Lesson.ClassId, table2 => table2.Id, (LessonAndTeacher, ClassesParam) => new { LessonAndTeacher, ClassesParam })
                        .Select(x => x.LessonAndTeacher.Lesson.LessonName + ", " + x.LessonAndTeacher.Teacher.FullName);


            comboBox1.Items.AddRange(list.ToArray());

        }
    }
}
