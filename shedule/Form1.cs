using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using schedule.Core.Main.Concrete.School;
using schedule.DataBase.Models;
using System.Data.Linq;
using shedule.DataBase.String;

namespace shedule
{
    public partial class Form1 : Form
    {
        DataContext dc;
        SсhoolSchedule Schedule;
        SchoolScheduler Scheduler;

        Table<Entity> entityTable;
        Table<EntityControl> entityControlTable;
        Table<Data> lessonTable;
        Table<PeopleGroup> peopleGroupTable;
        Table<Room> classroomTable;
        Table<Schedule> scheduleTable;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dc = new DataContext(ConnectionString.ConnectionStr);

            entityTable = dc.GetTable<Entity>();
            entityControlTable = dc.GetTable<EntityControl>();
            lessonTable = dc.GetTable<Data>();
            peopleGroupTable = dc.GetTable<PeopleGroup>();
            classroomTable = dc.GetTable<Room>();
            scheduleTable = dc.GetTable<Schedule>();

            

            try
            {
                Schedule = new SсhoolSchedule(entityControlTable, lessonTable, peopleGroupTable, classroomTable, scheduleTable);
                Scheduler = new SchoolScheduler(entityTable);
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Одно или несколько полей не было выбрано.");
            }

            Filling();
           

        }


        void Filling()
        {
            var Lesson = new List<string>();
            Lesson.Add("1");
            Lesson.Add("2");
            Lesson.Add("3");
            Lesson.Add("4");
            Lesson.Add("5");
            Lesson.Add("6");
            Lesson.Add("7");
            Lesson.Add("8");

            comboBox1.DataSource = Schedule.ReturnSchedule();
            listBox1.DataSource = Lesson;
            listBox2.DataSource = peopleGroupTable.Select(x => x.GroupName);
        }

    }
}
