using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_4
{//Интерфейс Работник
    interface Worker 
    {//свойства
        string FirstName { get; set; }//имя
        string LastName { get; set; }//фамилия
        string Patronymic { get; set; }//отчество
        int Age { get; set; }//возраст
        string Position { get; set; }//должность
        string PhoneNumber { get; set; }//номер телеофна
        string Email { get; set; }//почта
        int Salary { get; set; }//зарплата



        string GetInfoAboutPerson();//получить информацию о человеке метод
    }
    //Интерфейс Отец семейства
    interface Farther
    {
        string FirstName { get; set; }//имя
        string LastName { get; set; }//фамилия
        string Patronymic { get; set; }//отчество
        int Age { get; set; }//возраст
       string Status { get; set; }//семейное положение
       string GetInfoAboutPerson();  //получить инф о человеке
        int AmountOfChildren { get; set; }//кол-во детей
    }
    //Класс Работник-Отец семейства
    public class FatherWorker : Farther, Worker, ICloneable, IComparable
    {
        int age,//описываем необходимые поля
            salary,
            children;
        string phoneNumber;


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                //если длина строки с номером телефона соответствует 11 цифрам
                if(value.Length==11)
                {
                    for(int i = 0; i<11;i++)
                    {

                        if(Char.IsDigit(value[i])==false)//если не является цифрой
                        {
                            MessageBox.Show("Введите 11 цифр номера телефона");//ошибка
                            return;
                        }
                    }//запоминаем телефон
                    phoneNumber = value;
                }
                else
                {
                    MessageBox.Show("Введите 11 цифр номера телефона");
                }
            }
        }
        public int AmountOfChildren
        {
            get
            {
                return children;
            }
            set
            {//исключаем отрицательное количество детей
                if (value >= 0) children = value;
                else
                {
                    MessageBox.Show("Количество детей должно быть не меньше нуля");
                }
            }
        }
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {//зарплата должна быть больше нуля
                if (value >= 0)
                {
                    salary = value;
                }
                else
                {
                    MessageBox.Show("Ошибка! Зарплата должна быть > 0");
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {//возраст должен быть больше нуля
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    MessageBox.Show("Ошибка! Возраст должен быть > 0");
                }
            }
        }
       //получаем информацию о человеке в методе
        public string GetInfoAboutPerson()
        {
            //выводим все данные, необходимые для нформации о работнике
            return "ФИО: " + LastName + " " + FirstName + " " + Patronymic + "\n" + "Возраст: " + age.ToString() + " лет\n"
                + "Должность: " + Position + "\n" + "Зарплата: " + Salary + "\n" + "Email: " + Email + "\n" + "Телефон: " + PhoneNumber;
        }
        public int CompareTo(object obj)
        {
            FatherWorker temp = (FatherWorker)obj;
            if (this.salary > temp.salary) return 1;
            if (this.salary < temp.salary) return -1;
            return 0;
        }
        //Поверхностное клонирование
        public FatherWorker ShallowClone()
        {
            return (FatherWorker)this.MemberwiseClone();
        }
        //полное клонирование
        public object Clone()
        {
            FatherWorker clone = new FatherWorker();
            clone.FirstName = this.FirstName;
            clone.LastName = this.LastName;
            clone.Patronymic = this.Patronymic;
            clone.Salary = this.Salary;
            clone.Patronymic = this.Patronymic;
            return clone;
        }
    }

}
