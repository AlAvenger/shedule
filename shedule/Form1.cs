using shedule.DataBase;
using System;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
namespace shedule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dc = new DataContext(ConnString.ConnStr);

            var l = dc.GetTable<Lessons>();
            var c = dc.GetTable<Classes>();
            var cr = dc.GetTable<Classrooms>();
            var t = dc.GetTable<Teachers>();

            var list = l.Join(t, table => table.Id, table2 => table2.Id, (q, qq) => new { q, qq })
                        .Join(c, table => table.q.ClassId, table2 => table2.Id, (a, aa) => new { a, aa })
                  
                        .Select(x => x.a.q.LessonName + ", " + x.a.qq.FullName);
                
                        
            comboBox1.Items.AddRange(list.ToArray());

        }
    }
}
