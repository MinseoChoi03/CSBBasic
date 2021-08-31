using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic7
{
    class Products
    {
        private List<string>list;
        public Products()
        {
            list.Add("탕수육");
            list.Add("차돌 짬뽕");
            list.Add("볶음 짬뽕");
            list.Add("깐쇼새우");
            list.Add("양장피");
            list.Add("간짜장");
        }
        public string this[int i]
        {
            get { return list[i]; }
            set { Console.WriteLine(i + "번째 상품 설정"); }
        }
    }
    class Program
    {
        class Wanted<T>
            //where T : Student
        {
            public T Value;
            public Wanted(T value)
            {
                this.Value = value;
            }
        }
        class Student
        {
            public override string ToString()
            {
                return "학생";
            }
        }
        static void Main(string[] args)
        {
            Products ps = new Products();
            Random rs = new Random();
            int i = rs.Next(0, 6);
            Console.WriteLine(ps[i]);

            Wanted<string> ws = new Wanted<string>("string");
            Wanted<int> wi = new Wanted<int>(10);
            Wanted<Student> wstu = new Wanted<Student>(new Student());
            Console.WriteLine(ws);
            Console.WriteLine(wi);
            Console.WriteLine(wstu);

        }
    }
}
