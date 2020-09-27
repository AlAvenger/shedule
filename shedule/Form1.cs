using schedule.Core.Main.Concrete.School;
using schedule.DataBase.Models;
using shedule.DataBase.String;
using System;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace shedule
{
    public partial class Form1 : Form
    {
        
        DataContext dc;
        SсhoolSchedule Schedule;

        #region Таблицы
        Table<Entity> entityTable;
        Table<EntityControl> entityControlTable;
        Table<Data> lessonTable;
        Table<PeopleGroup> peopleGroupTable;
        Table<Room> classroomTable;
        Table<Queue> queueTable;
        Table<Schedule> scheduleTable;
        #endregion
        public Form1()
        {
            InitializeComponent();

            dc = new DataContext(ConnectionString.ConnectionStr);

            entityTable = dc.GetTable<Entity>();
            entityControlTable = dc.GetTable<EntityControl>();
            lessonTable = dc.GetTable<Data>();
            peopleGroupTable = dc.GetTable<PeopleGroup>();
            classroomTable = dc.GetTable<Room>();
            queueTable = dc.GetTable<Queue>();
            scheduleTable = dc.GetTable<Schedule>();
            Schedule = new SсhoolSchedule(entityControlTable, lessonTable, peopleGroupTable, classroomTable, queueTable);

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            Filling();
        }

        #region Заполнение листбоксов и комбобоксов
        void Filling()
        {


            TeacherComboBox.DataSource = Schedule.ReturnItems();

            listBoxLessons.DataSource = queueTable.Select(x => x.QueueName);
            listBoxClasses.DataSource = peopleGroupTable.Select(x => x.GroupName);
            listBoxClassrooms.DataSource = classroomTable.Select(x => x.RoomName);

            var items = scheduleTable.Select(x => x.GroupName + "/" + x.DataText + "/" + x.ControlName + "/" + x.RoomName + "/" + x.QueueName);
            
            Array.Sort(items.ToArray());
            listBoxSchedule.Items.AddRange(items.ToArray());

        }
        #endregion

        #region Функция просмотра будущей ячейки элемента расписания
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] arr = TeacherComboBox.SelectedItem.ToString().Split(',');
            lblTeacher.Text = arr[0];
            lblTheme.Text = arr[1];
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblLesson.Text = listBoxLessons.SelectedItem.ToString() + " урок";
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblClass.Text = listBoxClasses.SelectedItem.ToString() + " класс";
        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRoom.Text = listBoxClassrooms.SelectedItem.ToString() + " кабинет";
        }
        #endregion

        #region Функции добавления ячейки в расписание
        private void button1_Click(object sender, EventArgs e)
        {
            CreateCell();
        }
        void CreateCell()
        {
            string[] arr = TeacherComboBox.SelectedItem.ToString().Split(',');

            SchoolScheduler Scheduler = new SchoolScheduler(entityTable, scheduleTable);
            Schedule schedule = new Schedule();

            schedule.QueueName = listBoxLessons.SelectedItem.ToString();
            schedule.DataText = arr[1];
            schedule.ControlName = arr[0];
            schedule.RoomName = listBoxClassrooms.SelectedItem.ToString();
            schedule.GroupName = listBoxClasses.SelectedItem.ToString();

            scheduleTable.InsertOnSubmit(schedule);
            dc.SubmitChanges();
            var items = scheduleTable.Select(x => x.DataText + "/" + x.ControlName + "/" + x.RoomName + "/" + x.QueueName + "/" + x.GroupName);
            Array.Sort(items.ToArray());
            listBoxSchedule.DataSource = items;
        }
        #endregion
        
    }
}
