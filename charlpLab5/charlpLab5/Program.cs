using student;
using reader;
using System;

namespace student
{
    class Student
    {
        public string Fullname;
        public int GroupId;
        private int age;

        public Student(string Fullname, int GroupId, int age)
        {
            this.Fullname = Fullname;
            this.GroupId = GroupId;
            this.age = age;
        }
        internal void Print()
        {
            Console.WriteLine($"имя: {Fullname}, номер в группе: {GroupId}, возвраст: {age}");
        }
    }
}
namespace reader
{
    class Reader
    {

        private string Fullname;
        public int BiletId;
        public string Faculty;
        private string Birthday;
        public string Phone;

        public Reader(string Fullname, int BilletId, string Faculty, string Birthday,string Phone)
        {
            this.Fullname = Fullname;
            this.BiletId = BilletId;
            this.Faculty = Faculty;
            this.Birthday = Birthday;
            this.Phone = Phone;

        }

        public void takeBook()
        {
            Console.WriteLine($"Введите количесвто взятых {Fullname} книг");
            int books = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{Fullname} взял {books} книги");
        }

        public void takeBook(params string[] booksName)
        {
            foreach (string i in booksName){
                Console.WriteLine($"{Fullname} взял {i}");
            }
        }

        public void returnBook()
        {
            Console.WriteLine($"Введите количесвто взятых {Fullname} книг");
            int books = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{Fullname} вернул {books} книги");
        }

        public void returnBook(params string[] booksName)
        {
            foreach (string i in booksName)
            {
                Console.WriteLine($"{Fullname} вернул {i}");
            }
        }
    }
}
namespace charlpLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];

            students[0] = new Student("Иванов И.И.", 1, 18);
            students[1] = new Student("Синичкин А.Б.", 2, 28);
            students[2] = new Student("Медведев У.Г.", 3, 16);

            Reader[] readers = new Reader[3];

            readers[0] = new Reader("Иванов И.И.", 1, "Инжинерный факультет","13.10.2004","+79002863456");
            readers[1] = new Reader("Синичкин А.Б.", 2, "Технический факультет", "15.07.1996", "+791323463458");
            readers[2] = new Reader("Медведев У.Г.", 3, "Ботанический факультет", "03.01.2006", "+79581233434");

            students[0].Print();
            students[1].Print();
            students[2].Print();

            readers[0].takeBook("Математика", "Энциклопедия");
            readers[0].returnBook();

            readers[1].takeBook();
            readers[1].returnBook("Энциклопедия", " Математика");

            readers[2].takeBook();
            readers[2].returnBook();
        }
    }
}
