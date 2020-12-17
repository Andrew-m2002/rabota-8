namespace Практическая_работа_8
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьПоляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьОтчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьПоляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.children = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.стандартныеИнтерфейсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сравнитьЗпСПрожиточнымМинимумомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клонироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.стандартныеИнтерфейсыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(621, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьПоляToolStripMenuItem,
            this.показатьОтчётToolStripMenuItem,
            this.очиститьПоляToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьПоляToolStripMenuItem
            // 
            this.сохранитьПоляToolStripMenuItem.Name = "сохранитьПоляToolStripMenuItem";
            this.сохранитьПоляToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьПоляToolStripMenuItem.Text = "Сохранить поля";
            this.сохранитьПоляToolStripMenuItem.Click += new System.EventHandler(this.сохранитьПоляToolStripMenuItem_Click);
            // 
            // показатьОтчётToolStripMenuItem
            // 
            this.показатьОтчётToolStripMenuItem.Name = "показатьОтчётToolStripMenuItem";
            this.показатьОтчётToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.показатьОтчётToolStripMenuItem.Text = "Показать отчёт";
            this.показатьОтчётToolStripMenuItem.Click += new System.EventHandler(this.показатьОтчётToolStripMenuItem_Click);
            // 
            // очиститьПоляToolStripMenuItem
            // 
            this.очиститьПоляToolStripMenuItem.Name = "очиститьПоляToolStripMenuItem";
            this.очиститьПоляToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститьПоляToolStripMenuItem.Text = "Очистить поля";
            this.очиститьПоляToolStripMenuItem.Click += new System.EventHandler(this.очиститьПоляToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.position);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.salary);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.mail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(13, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(300, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работник:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Должность";
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(6, 47);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(156, 26);
            this.position.TabIndex = 6;
            this.position.Text = "Работник";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Зарплата";
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(168, 103);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(125, 26);
            this.salary.TabIndex = 4;
            this.salary.Text = "25000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Телефон";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(6, 103);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(156, 26);
            this.phone.TabIndex = 2;
            this.phone.Text = "89308725009";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(6, 162);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(287, 26);
            this.mail.TabIndex = 1;
            this.mail.Text = "andrey2002@ya.ru";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Электронная почта";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.status);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.children);
            this.groupBox2.Location = new System.Drawing.Point(320, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 88);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отец семейства:";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(185, 48);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(92, 26);
            this.status.TabIndex = 3;
            this.status.Text = "Занят";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Семейное положение:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Количество детей:";
            // 
            // children
            // 
            this.children.Location = new System.Drawing.Point(185, 21);
            this.children.Name = "children";
            this.children.Size = new System.Drawing.Size(92, 26);
            this.children.TabIndex = 0;
            this.children.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.age);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.patronymic);
            this.groupBox3.Controls.Add(this.firstName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lastName);
            this.groupBox3.Location = new System.Drawing.Point(13, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 86);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Человек:";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(361, 47);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(68, 26);
            this.age.TabIndex = 7;
            this.age.Text = "18";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Возраст";
            // 
            // patronymic
            // 
            this.patronymic.Location = new System.Drawing.Point(245, 47);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(110, 26);
            this.patronymic.TabIndex = 5;
            this.patronymic.Text = "Андреевич";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(139, 47);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 26);
            this.firstName.TabIndex = 4;
            this.firstName.Text = "Андрей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(6, 47);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(127, 26);
            this.lastName.TabIndex = 0;
            this.lastName.Text = "Монахов";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить все поля";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.сохранитьПоляToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(283, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Показать отчёт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.показатьОтчётToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(283, 26);
            this.button3.TabIndex = 6;
            this.button3.Text = "Очистить поля";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.очиститьПоляToolStripMenuItem_Click);
            // 
            // стандартныеИнтерфейсыToolStripMenuItem
            // 
            this.стандартныеИнтерфейсыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сравнитьЗпСПрожиточнымМинимумомToolStripMenuItem,
            this.клонироватьToolStripMenuItem});
            this.стандартныеИнтерфейсыToolStripMenuItem.Name = "стандартныеИнтерфейсыToolStripMenuItem";
            this.стандартныеИнтерфейсыToolStripMenuItem.Size = new System.Drawing.Size(163, 19);
            this.стандартныеИнтерфейсыToolStripMenuItem.Text = "Стандартные интерфейсы";
            // 
            // сравнитьЗпСПрожиточнымМинимумомToolStripMenuItem
            // 
            this.сравнитьЗпСПрожиточнымМинимумомToolStripMenuItem.Name = "сравнитьЗпСПрожиточнымМинимумомToolStripMenuItem";
            this.сравнитьЗпСПрожиточнымМинимумомToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.сравнитьЗпСПрожиточнымМинимумомToolStripMenuItem.Text = "Сравнить зп с прожиточным минимумом";
            this.сравнитьЗпСПрожиточнымМинимумомToolStripMenuItem.Click += new System.EventHandler(this.сравнитьЗпСПрожиточнымМинимумомToolStripMenuItem_Click);
            // 
            // клонироватьToolStripMenuItem
            // 
            this.клонироватьToolStripMenuItem.Name = "клонироватьToolStripMenuItem";
            this.клонироватьToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.клонироватьToolStripMenuItem.Text = "Клонировать";
            this.клонироватьToolStripMenuItem.Click += new System.EventHandler(this.клонироватьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 333);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Практическая работа №8";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox children;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьПоляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьОтчётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьПоляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.ToolStripMenuItem стандартныеИнтерфейсыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сравнитьЗпСПрожиточнымМинимумомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клонироватьToolStripMenuItem;
    }
}

