using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_4;

namespace Практическая_работа_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //создаем объект
        FatherWorker father = new FatherWorker();
        //показать отчет
        private void показатьОтчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(father.GetInfoAboutPerson());//выводим отчет с использованием библиотеки
        }
        //сохранить поля
        private void сохранитьПоляToolStripMenuItem_Click(object sender, EventArgs e)
        {//сохраняем все поля из формы с помощью библиотеки
            father.FirstName = firstName.Text;
            father.LastName = lastName.Text;
            father.Patronymic = patronymic.Text;
            if (Int32.TryParse(age.Text, out int age1)) father.Age = age1;
            father.Position = position.Text;
            father.PhoneNumber = phone.Text;
            if (Int32.TryParse(salary.Text, out int salary1)) father.Salary = salary1;
            father.Email = mail.Text;
            if (Int32.TryParse(children.Text, out int children1)) father.AmountOfChildren = children1;
            father.Status = status.Text;
        }
        //очистить поля
        private void очиститьПоляToolStripMenuItem_Click(object sender, EventArgs e)
        {//очищаем поля пересоздав объект и очистив поля
            FatherWorker father = new FatherWorker();
            firstName.Text = "";
                lastName.Text = "";
            patronymic.Text = "";
            age.Text = "";
            position.Text = "";
            phone.Text = "";
            salary.Text = "";
            mail.Text = "";
            children.Text = "";
            status.Text = "";
        }
        //выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //о программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №8\n" +
                "Монахов Андрей ИСП-31\n" +
                "4. Создать интерфейсы - работник и отец-семейства.  " +
                "Создать класс работника-отца семейства. Класс должен включать конструктор, " +
                "функцию для формирования строки информации о работнике. Сравнение производить по фамилии. ");
        }

        private void сравнитьЗпСПрожиточнымМинимумомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FatherWorker salaryMin = new FatherWorker();
            salaryMin.Salary = 10123;
            FatherWorker salaryRab = new FatherWorker();
            if (Int32.TryParse(salary.Text, out int salary1)) salaryRab.Salary = salary1;
            if (salaryMin.CompareTo(salaryRab) <0) MessageBox.Show("ЗП больше прожиточного минимума");
            else MessageBox.Show("ЗП не больше прожиточного минимума");
        }

        private void клонироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ссылка
            FatherWorker x1 = father;
            //поверхностное клонирование
            FatherWorker x2 = father.ShallowClone();
            //полное клонирование
            FatherWorker x3 = (FatherWorker)father.Clone();
        }
    }
    
    
}
