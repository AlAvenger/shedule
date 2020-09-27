namespace shedule
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TeacherComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxSchedule = new System.Windows.Forms.ListBox();
            this.lblTheme = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxClassrooms = new System.Windows.Forms.ListBox();
            this.lblLesson = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxClasses = new System.Windows.Forms.ListBox();
            this.listBoxLessons = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeacherComboBox
            // 
            this.TeacherComboBox.FormattingEnabled = true;
            this.TeacherComboBox.Location = new System.Drawing.Point(6, 22);
            this.TeacherComboBox.Name = "TeacherComboBox";
            this.TeacherComboBox.Size = new System.Drawing.Size(170, 21);
            this.TeacherComboBox.TabIndex = 0;
            this.TeacherComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.listBoxSchedule);
            this.panel1.Controls.Add(this.lblTheme);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.listBoxClassrooms);
            this.panel1.Controls.Add(this.lblLesson);
            this.panel1.Controls.Add(this.lblRoom);
            this.panel1.Controls.Add(this.lblTeacher);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listBoxClasses);
            this.panel1.Controls.Add(this.listBoxLessons);
            this.panel1.Controls.Add(this.TeacherComboBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 235);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Расписание";
            // 
            // listBoxSchedule
            // 
            this.listBoxSchedule.FormattingEnabled = true;
            this.listBoxSchedule.Location = new System.Drawing.Point(530, 22);
            this.listBoxSchedule.Name = "listBoxSchedule";
            this.listBoxSchedule.Size = new System.Drawing.Size(268, 212);
            this.listBoxSchedule.TabIndex = 16;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(59, 84);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(52, 13);
            this.lblTheme.TabIndex = 13;
            this.lblTheme.Text = "Предмет";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(6, 97);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(38, 13);
            this.lblClass.TabIndex = 12;
            this.lblClass.Text = "Класс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = " Кабинет";
            // 
            // listBoxClassrooms
            // 
            this.listBoxClassrooms.FormattingEnabled = true;
            this.listBoxClassrooms.Location = new System.Drawing.Point(402, 22);
            this.listBoxClassrooms.Name = "listBoxClassrooms";
            this.listBoxClassrooms.Size = new System.Drawing.Size(104, 160);
            this.listBoxClassrooms.TabIndex = 10;
            this.listBoxClassrooms.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // lblLesson
            // 
            this.lblLesson.AutoSize = true;
            this.lblLesson.Location = new System.Drawing.Point(59, 56);
            this.lblLesson.Name = "lblLesson";
            this.lblLesson.Size = new System.Drawing.Size(33, 13);
            this.lblLesson.TabIndex = 9;
            this.lblLesson.Text = "Урок";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(59, 97);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(49, 13);
            this.lblRoom.TabIndex = 8;
            this.lblRoom.Text = "Кабинет";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(59, 110);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(86, 13);
            this.lblTeacher.TabIndex = 7;
            this.lblTeacher.Text = "Преподаватель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Преподаватель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Класс";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Урок";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxClasses
            // 
            this.listBoxClasses.FormattingEnabled = true;
            this.listBoxClasses.Location = new System.Drawing.Point(292, 22);
            this.listBoxClasses.Name = "listBoxClasses";
            this.listBoxClasses.Size = new System.Drawing.Size(104, 160);
            this.listBoxClasses.TabIndex = 2;
            this.listBoxClasses.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBoxLessons
            // 
            this.listBoxLessons.FormattingEnabled = true;
            this.listBoxLessons.Location = new System.Drawing.Point(182, 22);
            this.listBoxLessons.Name = "listBoxLessons";
            this.listBoxLessons.Size = new System.Drawing.Size(104, 160);
            this.listBoxLessons.TabIndex = 1;
            this.listBoxLessons.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 259);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Школьное расписание";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox TeacherComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxLessons;
        private System.Windows.Forms.ListBox listBoxClasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLesson;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxClassrooms;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxSchedule;
    }
}

